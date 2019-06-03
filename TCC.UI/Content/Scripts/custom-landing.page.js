
$(document).ready(function () {
    defineHeaderColor();
});

$(document).scroll(function () {
    defineHeaderColor();
});

function defineHeaderColor() {
    var header = $(".skin-blue .main-header .navbar");

    if ($(window).scrollTop() < $(window).height() - header.height()) {
        header.addClass("transparent");
    }
    else {
        header.removeClass("transparent");
    }
}

$("#KnowMore").click(function () {
    var header = $(".skin-blue .main-header .navbar");

    $('html, body').animate(
        { scrollTop: $(window).height() - header.height() }, 500, 'linear'
    );
});