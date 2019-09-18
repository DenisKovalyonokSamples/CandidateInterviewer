$(function () {

    var header = $('.header');

    function scroll() {
        var top = $(window).scrollTop();
        if (top > 10) {
            header.addClass('header--fixed');
        } else {
            header.removeClass('header--fixed');
        }
    }
    scroll();

    var btnScroll = $('.js-scroll');

    function scrollBottom() {
        var windowTop = $(window).scrollTop();
        var company = $('.about--company');
        var companyHeight = company.innerHeight() - 180;

        if (windowTop >= companyHeight) {
            btnScroll.hide();
        }
        else if (windowTop <= 10) {
            btnScroll.show();
        }
    }
    scrollBottom();

    $(window).on('scroll', function () {
        scroll();
        scrollBottom();
    });

    btnScroll.on('click', function (e) {
        e.preventDefault();
        $('html,body').animate({
            scrollTop: $('.carousel').offset().top - 180
        }, 700);
    });
});