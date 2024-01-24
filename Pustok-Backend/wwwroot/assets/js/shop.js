

$(document).ready(function () {
  // filter js
  let minValue = document.getElementById("min-value");
  let maxValue = document.getElementById("max-value");

  function validateRange(minPrice, maxPrice) {
    if (minPrice > maxPrice) {
      // Swap to Values
      let tempValue = maxPrice;
      maxPrice = minPrice;
      minPrice = tempValue;
    }

    minValue.innerHTML = "$" + minPrice;
    maxValue.innerHTML = "$" + maxPrice;
  }

  const inputElements = document.querySelectorAll(".range-slider input");
  inputElements.forEach((element) => {
    element.addEventListener("change", (e) => {
      let minPrice = parseInt(inputElements[0].value);
      let maxPrice = parseInt(inputElements[1].value);

      validateRange(minPrice, maxPrice);
    });
  });

    validateRange(inputElements[0].value, inputElements[1].value);



    $(document).on("submit", "#filter-form", function (e) {
        e.preventDefault();
        let minValue = $(".min-price").val();
        let maxValue = $(".max-price").val();
        let data = { minValue: minValue, maxValue: maxValue }

        let parent = $(".product-list");
        $.ajax({
            url: "/Shop/GetProductsByRange",
            type: "Get",
            data: data,
            success: function (res) {
                $(parent).html(res);
                console.log(minValue);
                console.log(maxValue);
               
            }
        })
    })

  //   product icon js

  // feauture product hover btns show

  $(".product-card").mouseover(function () {
    $(this)
      .children()
      .closest(".product-card-body")
      .find(".hover-content")
      .addClass("show-hover-btns");
  });

  $(".product-card").mouseout(function () {
    $(this)
      .children()
      .closest(".product-card-body")
      .find(".hover-content")
      .removeClass("show-hover-btns");
  });

  // product modal js


    $(".open-modal").click(function (e) {
        e.preventDefault();
        $(".detail-modal").removeClass("d-none");
        $(".modal-overlay").removeClass("d-none");

        $("body").addClass("modal-is-open");

        // if ($(".product-image").hasClass("slick-initialized")) {
        //   $(".product-image").slick("unslick");
        // }

        // if ($(".slider-nav-thumbnails").hasClass("slick-initialized")) {
        //   $(".slider-nav-thumbnails").slick("unslick");
        // }

        // $(".product-image").empty();
        // $(".slider-nav-thumbnails").empty();

        $(".product-image").slick({
            infinite: true,
            // prevArrow: $(".prev"),
            // nextArrow: $(".next"),
            asNavFor: ".slider-nav-thumbnails",
        });

        $(".slider-nav-thumbnails").slick({
            slidesToShow: 4,
            slidesToScroll: 1,
            asNavFor: ".product-image",

            focusOnSelect: true,
        });

        $(".slider-nav-thumbnails .slick-slide").removeClass("slick-active");
        $(".slider-nav-thumbnails .slick-slide").eq(0).addClass("slick-active");

        $(".product-image").on(
            "beforeChange",
            function (event, slick, currentSlide, nextSlide) {
                var mySlideNumber = nextSlide;
                $(".slider-nav-thumbnails .slick-slide").removeClass("slick-active");
                $(".slider-nav-thumbnails .slick-slide")
                    .eq(mySlideNumber)
                    .addClass("slick-active");
            }
        );
    });

    $(".close-modal").click(function (e) {
        e.preventDefault();
        $(".detail-modal").addClass("d-none");
        $(".modal-overlay").addClass("d-none");
        $("body").removeClass("modal-is-open");
    });



    //filter by category

    function getProductsByFilter(clickedElem, url) {
        $(document).on("click", clickedElem, function (e) {
            e.preventDefault();
            console.log("salam")
            let id = $(this).attr("data-id");
            let data = { id: id };
            let parent = $(".product-list")
            $.ajax({
                url: url,
                type: "Get",
                data: data,
                success: function (res) {
                    $(parent).html(res);
                }
            })
        })

    }


    getProductsByFilter(".prod-cat-item", "/Shop/GetProductsByCategory")
    getProductsByFilter(".cat-item", "/Shop/GetAll")


    //SORT
    $(document).on("change", "#sort", function (e) {
        e.preventDefault();
        let sortValue = $(this).val();
        console.log(sortValue)

        let data = { sortValue: sortValue };
        let parent = $(".product-list");

        $.ajax({
            url: "/Shop/GetProductsBySort",
            type: "Get",
            data: data,
            success: function (res) {
                console.log(sortValue)
                $(parent).html(res);

            }

        })
    })

    //modal ajax
    $(document).on("click", ".open-modal", function (e) {

        let id = $(this).attr("data-id");
        let name = $(".detail-modal .product-name")
        let description = $(".detail-modal .product-desc")
        let price = $(".detail-modal .actual-price")
        let discountPrice = $(".detail-modal .discount-price")
        let category = $(".detail-modal .category")
        let sku = $(".detail-modal .sku")
        let tags = $(".detail-modal .tags")
        let imageContainer = document.querySelector(".detail-modal .product-image");
        let thumbnailContainer = document.querySelector(".detail-modal .slider-nav-thumbnails");

        if ($(".product-image").hasClass("slick-initialized")) {
            $(".product-image").slick("unslick");
        }

        if ($(".slider-nav-thumbnails").hasClass("slick-initialized")) {
            $(".slider-nav-thumbnails").slick("unslick");
        }

        $(".product-image").empty();
        $(".slider-nav-thumbnails").empty();

        $.ajax({
            type: "Get",
            url: `/Home/GetProductDatasModal/${id}`,
            success: function (res) {
                console.log("Salam")
                let actualPrice = res.price - (((res.price * res.discount) / 100));
                description.text(res.description)
                name.text(res.name)
                discountPrice.text("$" + res.price)
                price.text("$" + actualPrice)
                category.text(res.categoryName)
                sku.text(res.sku)
                tags.text(res.tags)
                console.log(res.images.length)

                for (let i = 0; i < res.images.length; i++) {
                    let img = document.createElement("img");
                    img.src = "/assets/images/" + res.images[i];
                    imageContainer.appendChild(img);

                    let thumbnailImg = document.createElement("img");
                    thumbnailImg.src = "/assets/images/" + res.images[i];
                    thumbnailContainer.appendChild(thumbnailImg);
                }



                $(".product-image").slick({
                    infinite: true,
                    prevArrow: $(".prev"),
                    nextArrow: $(".next"),
                    asNavFor: ".slider-nav-thumbnails",
                });

                $(".slider-nav-thumbnails").slick({
                    slidesToShow: 4,
                    slidesToScroll: 1,
                    focusOnSelect: true,
                    asNavFor: ".product-image",
                });




            }
        })


    })



   

});
