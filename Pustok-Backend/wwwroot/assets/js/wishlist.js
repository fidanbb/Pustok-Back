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

    //$(document).on("click", ".cart-add-basket", function () {


    //    let id = $(this).parent().attr("data-id");;
    //    let count = $(".basket-count").text();
    //    $.ajax({
    //        url: `shop/addbasket?id=${id}`,
    //        type: "Post",
    //        success: function (res) {

    //            count++;
    //            $(".basket-count").text(count);

    //        }
    //    })

    //})

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