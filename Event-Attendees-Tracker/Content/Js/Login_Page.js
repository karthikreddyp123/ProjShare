$(document).ready(function () {
    $("#submitcheck").click(function () {
        if ($("#username").val() == "") {
            alert("There is no value in textbox");
        }
    });
});