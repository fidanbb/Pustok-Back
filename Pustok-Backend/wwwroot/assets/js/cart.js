$(function () {

    $(document).on("click", ".cart-add", function () {

        let addedItemBasket = document.querySelector(".added-item-basket");

        let id = $(this).parent().parent().attr("data-id");;
        let count = $(".basket-count").text();
        $.ajax({
            url: `/shop/addbasket?id=${id}`,
            type: "Post",
            success: function (res) {

                // Show "Product added to basket" message
                addedItemBasket.style.display = "flex";
                setTimeout(function () {
                    addedItemBasket.style.display = "none";
                }, 2000);

                count++;
                $(".basket-count").text(count);
                /*  $(".total-count").text(count);*/
                $(".grand-total-price").text(res.toFixed(2));
                location.reload();

                checkProgress(res.toFixed(2))

               

            }
        })

    })

    $(document).on("click", ".basket-table .fa-plus", function (e) {

        let id = parseInt($(this).attr("data-id"))
        let count = $(".basket-count").text();
        $.ajax({

            url: `cart/IncreaseCount?id=${id}`,
            type: "Post",
            success: function (res) {

                $(e.target).prev().text(res.count)
                $(".last-price").text(res.grandTotal.toFixed(2));
                $(".grand-total-price").text(res.grandTotal.toFixed(2));

                

                $(e.target).parent().parent().next().children().text(res.productTotalPrice.toFixed(2))
                count++;

                $(".basket-count").text(count);
                $(".total-count").text(count);
                checkProgress(res.grandTotal.toFixed(2))

            }
        })

    })

    $(document).on("click", ".basket-table .fa-minus", function (e) {

        let id = parseInt($(this).attr("data-id"))
        let count = $(".basket-count").text();
        let a = 0;

        $.ajax({

            url: `cart/DecreaseCount?id=${id}`,
            type: "Post",
            success: function (res) {

                $(e.target).next().text(res.count)
                $(".last-price").text(res.grandTotal.toFixed(2));
                $(".grand-total-price").text(res.grandTotal.toFixed(2));

                $(".total-count").text(res.countBasket);
                $(e.target).parent().parent().next().children().text(res.productTotalPrice.toFixed(2))
                $(".basket-count").text(res.countBasket)
                checkProgress(res.grandTotal.toFixed(2))

            }
        })

    })



    $(document).on("click", ".delete-basket-item", function (e) {
        let id = parseInt($(this).attr("data-id"));

        $.ajax({
            url: `cart/delete?id=${id}`,
            type: "Post",
            success: function (res) {


                $(".basket-count").text(res.count);
                $(e.target).closest("tr").remove();
                $(".last-price").text(res.grandTotal.toFixed(2));
                $(".grand-total-price").text(res.grandTotal.toFixed(2));

                $(".total-count").text(res.count);
                checkProgress(res.grandTotal.toFixed(2))


                if (res.count === 0) {
                    $("#empty-basket").removeClass("d-none");
                    $("#basket").addClass("d-none");
                    $(".cart-empty").removeClass("d-none");
                    $(".single-cart-block").addClass("d-none");
                    $(".cart-btn").addClass("d-none");

                }


            }
        })


    })


  

 


    $(document).on("click", ".quantity .plus", function () {
        console.log("salam")
        let count = $(".quantity .num").text();
        count++;
        $(".quantity .num").text(count);
    })


    $(document).on("click", ".quantity .minus", function () {
        let count = $(".quantity .num").text();
         count--;
         if (count>=1) {
             $(".quantity .num").text(count);

         }
     })


    $(document).on("click", ".add-cart", function () {

        let addedItemBasket = document.querySelector(".added-item-basket");

        let id = $(this).attr("data-id");;
        let basketCount = $(".basket-count").text();
        let count = $(".quantity .num").text();
        let data = { id: id, count: count }
        $.ajax({
            url: `/shop/AddBasketWithCount`,
            type: "Post",
            data:data,
            
            success: function (res) {

                // Show "Product added to basket" message
                addedItemBasket.style.display = "flex";
                setTimeout(function () {
                    addedItemBasket.style.display = "none";
                }, 2000);

                basketCount = basketCount + count;

                $(".basket-count").text(basketCount);
                $(".grand-total-price").text(res.toFixed(2));
                location.reload();

                checkProgress(res.toFixed(2))



            }
        })

    })


    function checkProgress(totalPrice) {
        const progress = document.querySelector(".progress-done");



        if (totalPrice < 250) {
            let width = (totalPrice * 100) / 250;
            progress.setAttribute("data-done", width);
            progress.style.width = progress.getAttribute("data-done") + "%";
            progress.style.opacity = 1;
            document.querySelector(".free-shipping-notice").innerHTML = `Add
      <span>$</span><span class="price-amount">${(250 - totalPrice).toFixed(2)}</span>
      to cart and get free shipping!`;
            // document.querySelector(".price-amount").innerText = Math.round(
            //   250 - subTotalPrice
            // );
        } else if (totalPrice >= 250) {
            let width = 100;
            progress.setAttribute("data-done", width);
            progress.style.width = progress.getAttribute("data-done") + "%";
            progress.style.opacity = 1;
            document.querySelector(".free-shipping-notice").innerHTML =
                "Your order qualifies for free shipping!";
        }
    }


    let grandTotalPrice = $(".grand-total-price").text();

    checkProgress(grandTotalPrice);


})