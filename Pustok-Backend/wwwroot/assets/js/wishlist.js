$(function () {




    $(document).on("click", ".wishlist-add", function (e) {
       
        let id = $(this).parent().parent().attr("data-id");
        let addedItemWishlist = document.querySelector(".added-item-wishlist");
        let alreadyInishlist = document.querySelector(".remove-item-wishlist");

        $.ajax({
            url: `/shop/addwishlist?id=${id}`,
            type: "Post",
            success: function (res) {
                if (res === false) {
                    // Show "Product added to wishlist" message
                    addedItemWishlist.style.display = "block";
                    setTimeout(function () {
                        addedItemWishlist.style.display = "none";
                    }, 2000);
                }
                else {
                    // Show "Product is already in wishlist" message
                    alreadyInishlist.style.display = "block";
                          setTimeout(function () {
                              alreadyInishlist.style.display = "none";
                          }, 2000);
                }
            }
        })


    })

    $(document).on("click", ".cart-add-basket", function () {

        let addedItemBasket = document.querySelector(".added-item-basket");
        let id = $(this).attr("data-id");;
        let count = $(".basket-count").text();
        $.ajax({
            url: `shop/addbasket?id=${id}`,
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


            }
        })

    })

    $(document).on("click", ".delete-wishlist-item", function (e) {


        let id = parseInt($(this).attr("data-id"));

        $.ajax({
            url: `wishlist/delete?id=${id}`,
            type: "Post",
            success: function (res) {
               res--
                $(e.target).closest("tr").remove();
                if (res === 0) {
                    $(".empty-wishlist").removeClass("d-none");
                    $(".wishlist-table").addClass("d-none");
                    $(".tiny-header").addClass("d-none");

                }


            }
        })


    })
})