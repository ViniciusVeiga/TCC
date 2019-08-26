var ePostit = $('#Postit').html();
var eRemovePostit = $('#RemovePostit').html();
var eRemoveLinePostit = $('#RemoveLinePostit').html();
var ePlusPostit = $('#PlusPostit').html();
var countLines = 0;

$('#Append').on('click', '#AddPostit', function () {
    $(this).parent().remove();
    $('#Append').append(ePostit);

    $('#Text').focus();
});

$('#Append').on('click', '.close', function () {
    $(this).closest('.to-remove').remove();
});

$('#Append').on('click', '.remove-line', function () {
    $(this).parent('p').remove();
    $('.postit:last p:last').append(eRemoveLinePostit);

    count();
});

$('#Append').on('keypress', '#Text', function (e) {
    if (e.keyCode == 13)
        $('#Send').click();
});

$('#Append').on('click', '.postit.select', function () {
    $('.postit').removeClass('active');
    $(this).addClass('active');
});