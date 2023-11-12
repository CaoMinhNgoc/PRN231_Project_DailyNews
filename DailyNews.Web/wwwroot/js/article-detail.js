$(document).ready(function () {
    var articleID = document.getElementById("articleID").innerHTML;

    ShowArticleDetail();
    ShowArticleComments();

    function ShowArticleDetail() {
        $.ajax({
            url: "http://localhost:5166/api/Articles/GetArticleById/" + articleID,
            type: "get",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                const formattedDate = new Date(result.createdDate).toLocaleString();

                $("#created-date").text("Created at: " + formattedDate);
                $("#title").text(result.title);
                $("#short-description").text(result.shortDescription);
                $("#content").text(result.content);
            },
        })
    }

    function ShowArticleComments() {
        $.ajax({
            url: "http://localhost:5166/api/Comments/GetCommentsByArticleId/" + articleID,
            type: "get",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result, status, xhr) {
                const commentsContainer = $('#comments');
                $.each(result, function (index, value) {
                    const commentElement = $("<div>");
                    const timeElement = $("<i>").text("Commented at: " + new Date(value.commentTime).toLocaleString());
                    const contentElement = $("<p>").text(value.commentContent);
                    commentElement.append(timeElement);
                    commentElement.append(contentElement);
                    commentsContainer.append(commentElement);
                });
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        })
    }
})