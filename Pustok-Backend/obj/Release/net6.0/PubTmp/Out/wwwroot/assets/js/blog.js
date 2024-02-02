$(document).ready(function () {


    function getBlogsByTagId(clickedElem, url) {
        $(document).on("click", clickedElem, function (e) {
            e.preventDefault();
            let id = $(this).attr("data-id");
            let data = { id: id };
            let parent = $(".blog-list")
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


    getBlogsByTagId(".blog-tag", "/Blog/GetBlogsByTag")


    $(document).on("click", ".blog-search-btn", function (e) {
        e.preventDefault();
      console.log("salam")
        let value = $(".input-area").val();
        let parent = $(".blog-list")
        $.ajax({

            url: `blog/SearchBlogs?searchText=${value}`,

            type: "Get",
         

            success: function (res) {

                $(parent).html(res);
            }

        })

    })

    $(document).on("click", ".image-delete button", function (e) {

        let id = parseInt($(this).attr("data-id"));

        $.ajax({
            url: `/admin/blog/deleteblogimage?id=${id}`,
            type: "Post",
            success: function (res) {
                $(e.target).parent().remove();
            }
        })

    })
  

})