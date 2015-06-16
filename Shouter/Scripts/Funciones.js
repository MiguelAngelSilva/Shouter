$(document).ready(function () {
    $(".btn").click(function () {
        $(".error").remove();
        if ($("#commentText").val() == "") {
            $(".comment").focus().after("<span class='error'>Please, insert a comment.</span>");
            return false;
        }
    });

});