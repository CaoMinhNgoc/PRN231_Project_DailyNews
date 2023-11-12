$(document).ready(function () {
    ShowHomeFocus();
    ShowArticles();

    function ShowHomeFocus() {
        ShowCurrentArticles();
        ShowMostReadArticles();
    }

    function ShowCurrentArticles() {
        $("#current-article").html("");
        $.ajax({
            url: "http://localhost:5166/api/Articles/GetAllArticles?orderBy=createdDate%20desc&&top=5",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                $.each(result, function (index, value) {
                    $("#current-article").append($("<a class=\"cur-article\" href=\"#\">"))
                    $("#current-article .cur-article").last().append("<div class=\"cur-article-title\">");
                    $("#current-article .cur-article").last().append("<div class=\"cur-article-des\">");
                    $("#current-article .cur-article-title").last().html(value["title"]);
                    $("#current-article .cur-article-des").last().html(value["shortDescription"]);
                })
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
    }

    function ShowMostReadArticles() {
        $("#most-read-article").html("");
        $.ajax({
            url: "http://localhost:5166/api/Articles/GetAllArticles?orderBy=createdDate%20asc&&top=5",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                $.each(result, function (index, value) {
                    $("#most-read-article").append($("<a class=\"most-read-article\" href=\"#\">"))
                    $("#most-read-article .most-read-article").last().append("<div class=\"most-read-article-title\">");
                    $("#most-read-article .most-read-article").last().append("<div class=\"most-read-article-des\">");
                    $("#most-read-article .most-read-article-title").last().html(value["title"]);
                    $("#most-read-article .most-read-article-des").last().html(value["shortDescription"]);
                })
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
    }

    function ShowArticles() {
        $("#articles").html("");
        $.ajax({
            url: "http://localhost:5166/api/Categories/GetAllCategoriesWithArticle",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                $.each(result, function (index, value) {
                    $("#articles").append($("<div class=\"category\">"));
                    $("#articles .category").last().append($("<div class=\"category-name\">"));
                    $("#articles .category").last().append($("<a class=\"see-more\" href=\"#\">"));
                    $("#articles .see-more").last().html("See more");
                    $("#articles .category-name").last().html(value["categoryName"]);
                    $("#articles .category").last().append($("<div class=\"category-articles\">"));

                    var listArticle = [].slice.call(value["articles"]);
                    var x = listArticle.length >= 2 ? 2 : listArticle.length; console.log(x);
                    for (var i = 0; i < x; i++) {
                        $("#articles .category-articles").last().append($("<a class=\"article\" href=\"\">"));
                        $("#articles .article").last().append($("<div class=\"article-title\">").html(listArticle[i]["title"]));
                        $("#articles .article").last().append($("<div class=\"article-description\">").html(listArticle[i]["shortDescription"]));
                    }
                })
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
    }
})