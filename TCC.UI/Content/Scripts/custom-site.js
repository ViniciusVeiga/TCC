
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

$(document).ready(function () {
    setTimeout(function () {
        $('#LoadingInitial').fadeOut();
    }, 2000);
});

$(document).bind("ajaxSend", function () {
    $("#Loading").show();
}).bind("ajaxComplete", function () {
    setTimeout(function () {
        $("#Loading").hide();
    }, 500);
});

function newPage(id, url) {
    $.ajax({
        type: 'POST',
        url: url,
        data: { 'id': id },
        success: function (data) {
            changeContent(data);
        }
    });
}

// Quando apertar enter.
$('.input-group .form-control').keypress(function (e) {
    if (e.keyCode === 13) {
        $('.input-group-btn button').click();
    }
});

function changeContent(data) {
    $('#Ajax_Update_Menu').empty().html(data);
}