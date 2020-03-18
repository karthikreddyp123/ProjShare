let emailIDRegex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
let passwordRegex = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;

$('#submitcheck').click((event) => {
    //Validation for emaiLID
    let emailID = $('#emailID')
    if (emailID.val() == "" || !emailIDRegex.test(emailID.val())) {
        emailID.addClass('is-invalid');
        $('#emailHelper').removeClass('text-muted');
        $('#emailHelper').html("Invalid Email ID!");
        event.preventDefault();
    }
    else {
        $('#emailHelper').html("");
        emailID.removeClass('is-invalid');
        $('#emailHelper').addClass('text-muted');
    }

    //Validation for Password
    let password = $('#password')
    if (password.val() == "" || !passwordRegex.test(password.val())) {
        password.addClass('is-invalid');
        $('#passwordHelpBlock').removeClass('text-muted');
        $('#password').addClass('is-invalid');
        event.preventDefault();
    }
    else {
        $('#passwordHelpBlock').addClass('text-muted');
        $('#password').removeClass('is-invalid');
    }
})