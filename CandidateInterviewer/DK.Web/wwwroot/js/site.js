$('.js-toggleNavMobile').on('click', function (e) {
    e.preventDefault();
    $(this).closest('.header').find('.header__nav').toggleClass('header__nav--open');
});