$(function () {

    $('.owl-carousel-review').owlCarousel({
        items: 1,
        mouseDrag: false,
        touchDrag: false,
        nav: false
    });

    $('.owl-carousel--company').owlCarousel({
        items: 1,
        mouseDrag: false,
        touchDrag: false,
        nav: false,
        autoplay: true,
        autoplayTimeout: 5000,
        smartSpeed: 1500,
        loop: true,
        autoplayHoverPause: true,
        responsive: {
            0: {
                autoHeight: true
            },
            768: {
                autoHeight: false
            }
        }
    });

    var owlProject = $('.owl-carousel-project');

    owlProject.owlCarousel({
        nav: false,
        loop: true,
        autoplay: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: true,
        smartSpeed: 700,
        responsive: {
            0: {
                items: 1,
                margin: 0
            },
            768: {
                items: 2,
                margin: 30
            },
            900: {
                items: 3,
                margin: 50
            }
        }
    });

    var owlClient = $('.owl-carousel-client');

    owlClient.owlCarousel({
        nav: false,
        loop: true,
        autoplay: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: true,
        smartSpeed: 700,
        responsive: {
            0: {
                items: 1,
                margin: 10
            },
            768: {
                items: 2,
                margin: 30
            },
            900: {
                items: 3,
                margin: 50
            }
        }
    });

    function set_owl_center() {
        owlProject.find('.active').removeClass('owl-center');
        setTimeout(function () {
            owlProject.find('.active').each(function (i) {
                if (i === 1) $(this).addClass('owl-center');
            });
        }, 80);
        owlClient.find('.active').removeClass('owl-center');
        setTimeout(function () {
            owlClient.find('.active').each(function (i) {
                if (i === 1) $(this).addClass('owl-center');
            });
        }, 80);
    }
    set_owl_center();

    owlProject.on('changed.owl.carousel', function () {
        set_owl_center();
    });

    owlClient.on('changed.owl.carousel', function () {
        set_owl_center();
    });
});
