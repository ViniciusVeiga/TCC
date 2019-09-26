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

$('#Append').on('click', '#AddPostit', function () {
    appendPostit($(this));
});

$('#Append').on('click', '.close', function () {
    removePostit($(this));
});

$('#Append').on('click', '.remove-line', function () {
    removeLine($(this));
});

$('#Append').on('keypress', '#Text', function (e) {
    if (e.keyCode === 13)
        $('#Send').click();
});

function writeMessage(text) {
    $('.board-message')
        .text(text)
        .fadeIn();
}

function hideMessage() {
    $('.board-message').fadeOut();
}