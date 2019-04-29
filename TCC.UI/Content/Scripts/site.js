
$.validator.setDefaults({
    highlight: function (element) {
        console.log(element);
        $(element).closest('.form-group').addClass('has-error');
        $(element).closest('.field-validation-error').addClass('help-block');
    },
    unhighlight: function (element) {
        $(element).closest('.form-group').removeClass('has-error');
        $(element).closest('.field-validation-error').removeClass('help-block');
    }
});

function clearValidations() {
    $('.help-block').text('');
    $('.has-error').removeClass('has-error');
}

function clearAllTextInputs() {
    $('input[type="text"], input[type="Password"]').each(function () {
        $(this).val('');
    });
}