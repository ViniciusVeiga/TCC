
function clearValidations() {
    $('.help-block').text('');
    $('.has-error').removeClass('has-error');
}

function clearAllTextInputs() {
    $('input[type="text"], input[type="Password"]').each(function () {
        $(this).val('');
    });
}