
$(document).ready(function () {
    $('.help-block').each(function () {
        if ($(this).text() !== '') {
            $(this).closest('div.form-group').addClass('has-error');
        }
    });
});

function clearValidations() {s
    $('.help-block').text('');
    $('.has-error').removeClass('has-error');
}

function clearAllTextInputs() {
    $('input[type="text"], input[type="Password"]').each(function () {
        $(this).val('');
    });
}