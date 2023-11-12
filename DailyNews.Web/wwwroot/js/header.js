$(document).ready(function () {
    ShowCategories();

    function ShowCategories() {
        $("#category-header").html("");
        $.ajax({
            url: "http://localhost:5166/api/Categories/GetAllCategories",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                $.each(result, function (index, value) {
                    $("#category-header").append($("<a class=\"cate\" href=\"/Home/Articles?categoryID=" + value["categoryId"] +"\">"))
                    $("#category-header .cate").last().html(value["categoryName"]);
                })
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
    }
})