
function clearValidations() {
    $('.help-block').text('');
    $('.has-error').removeClass('has-error');
}

function clearAllTextInputs() {
    $('input[type="text"], input[type="Password"]').each(function () {
        $(this).val('');
    });
}

function reloadPage() {
    window.location.reload();
}

$('a[name="MenuItem"]').click(function () {
    $('a[name="MenuItem"]').parent().removeClass('active');
    $(this).parent().addClass('active');
});

$(document).bind("ajaxSend", function () {
    $("#Loading").show();
}).bind("ajaxComplete", function () {
    setTimeout(function () {
        $("#Loading").hide();
    }, 200);
});
