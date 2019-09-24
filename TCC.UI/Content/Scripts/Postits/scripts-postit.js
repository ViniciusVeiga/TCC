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

$('#SaveButton').click(function (event) {
    sendToSave(event);
});

$('#Append').on('click', '#AddPostit', function (event) {
    appendPostit(event);
});

$('#Append').on('click', '.close', function (event) {
    removePostit(event);
});

$('#Append').on('click', '.remove-line', function (event) {
    removeLine(event);
});

$('#Append').on('keypress', '#Text', function (e) {
    if (e.keyCode === 13)
        $('#Send').click();
});