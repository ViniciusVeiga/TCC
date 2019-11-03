var ePostit = $('#Postit').html();
var eRemovePostit = $('#RemovePostit').html();
var eRemoveLinePostit = $('#RemoveLinePostit').html();
var ePlusPostit = $('#PlusPostit').html();
var countLines = 0;

$(document).ready(function () {
    $('.example').remove();
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

function renderPDF(url, canvasContainer, options) {
    options = options || { scale: 1.4 };

    function renderPage(page) {
        var viewport = page.getViewport(options.scale);
        var wrapper = document.createElement("div");
        wrapper.className = "canvas-wrapper";
        var canvas = document.createElement('canvas');
        var ctx = canvas.getContext('2d');
        var renderContext = {
            canvasContext: ctx,
            viewport: viewport
        };

        canvas.height = viewport.height;
        canvas.width = viewport.width;
        wrapper.appendChild(canvas)
        canvasContainer.appendChild(wrapper);

        page.render(renderContext);
    }

    function renderPages(pdfDoc) {
        for (var num = 1; num <= pdfDoc.numPages; num++)
            pdfDoc.getPage(num).then(renderPage);
    }

    PDFJS.disableWorker = true;
    PDFJS.getDocument(url).then(renderPages);
}