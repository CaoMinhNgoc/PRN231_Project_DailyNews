$(document).ready(function () {
    var catID = document.getElementById("categoryID").innerHTML;
    ShowCatName();
    ShowArticles();

    function ShowArticles() {
        $("#articles").html("");
        $.ajax({
            url: "http://localhost:5166/api/Articles/GetAllArticles?$filter=categoryId%20eq%20" + catID,
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                $.each(result, function (index, value) {
                    $("#articles").append($("<a class=\"article\" href=\"#\">"));
                    $("#articles .article").last().append($("<div class=\"title\">"));
                    $("#articles .article").last().append($("<div class=\"des\">"));
                    $("#articles .title").last().html(value["title"]);
                    $("#articles .des").last().html(value["shortDescription"]);
                })
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
    }

    function ShowCatName() {
        $("#title").html("");
        $.ajax({
            url: "http://localhost:5166/api/Categories/GetCategoryById/" + catID,
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                $("#title").html(result["categoryName"]);
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
    }
})