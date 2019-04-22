
$(document).ready(function () {
    $('.help-block').each(function () {
        if ($(this).text() !== '') {
            $(this).closest('div[class="form-group"]').addClass('has-error');
        }
    });
});