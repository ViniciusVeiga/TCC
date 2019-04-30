
$.validator.setDefaults({
    highlight: function (element) {
        $(element).closest('.form-group').addClass('has-error');
        $('[data-valmsg-for="' + element.name + '"]').addClass('help-block');
    },
    unhighlight: function (element) {
        $(element).closest('.form-group').removeClass('has-error');
        $('[data-valmsg-for="' + element.name + '"]').removeClass('help-block');
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