var ePostit = $('#Postit').html();
var eRemovePostit = $('#RemovePostit').html();
var eRemoveLinePostit = $('#RemoveLinePostit').html();
var ePlusPostit = $('#PlusPostit').html();
var countLines = 0;

$(document).ready(function () {
    start();
});

$('#Append').on('click', '#Send', function () {
    writeLine();
});

$('#SaveButton').click(function () {
    sendToSave();
});

$('#Append').on('click', '#AddPostit', function () {
    appendPostit();
});

$('#Append').on('click', '.close', function () {
    removePostit();
});

$('#Append').on('click', '.remove-line', function () {
    removeLine();
});

$('#Append').on('keypress', '#Text', function (e) {
    if (e.keyCode == 13)
        $('#Send').click();
});

$('#Append').on('click', '.postit.select', function () {
    $('.postit').removeClass('active');
    $(this).addClass('active');
});