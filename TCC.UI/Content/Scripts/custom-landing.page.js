
$(document).ready(function () {
    defineHeaderColor();
});

$(document).scroll(function () {
    defineHeaderColor();
});

function defineHeaderColor() {
    var header = $(".skin-blue .main-header .navbar");

    if ($(window).scrollTop() < $(window).height() - header.height()) {
        header.css("background-color", "transparent");
    }
    else {
        header.css("background-color", "#3c8dbc");
    }
}