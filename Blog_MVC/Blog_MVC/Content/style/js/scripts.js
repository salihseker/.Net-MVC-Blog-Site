$(document).ready(function () {
"use strict";
	/*-----------------------------------------------------------------------------------*/
	/*	VIDEO
	/*-----------------------------------------------------------------------------------*/
    $('.player').fitVids();
	/*-----------------------------------------------------------------------------------*/
	/*	STICKY HEADER
	/*-----------------------------------------------------------------------------------*/
    var menu = $('.navbar'),
        pos = menu.offset();
    $(window).scroll(function () {
        if ($(this).scrollTop() > pos.top + menu.height() && menu.hasClass('default') && $(this).scrollTop() > 300) {
            menu.fadeOut('fast', function () {
                $(this).removeClass('default').addClass('fixed').fadeIn('fast');
            });
        } else if ($(this).scrollTop() <= pos.top + 300 && menu.hasClass('fixed')) {
            menu.fadeOut(0, function () {
                $(this).removeClass('fixed').addClass('default').fadeIn(0);
            });
        }
    });
	$('.navbar .nav li a').on('click',function(){
	    $('.navbar .navbar-collapse.in').collapse('hide');
	});
	/*-----------------------------------------------------------------------------------*/
	/*	MENU
	/*-----------------------------------------------------------------------------------*/
	$('.js-activated').dropdownHover({
	    instantlyCloseOthers: false,
	    delay: 0
	}).dropdown();
	$('.dropdown-menu a, .social .dropdown-menu, .social .dropdown-menu input').click(function (e) {
		e.stopPropagation();
	});
	$('.btn.responsive-menu').on('click', function() {
	    $(this).toggleClass('opn');
	});
	/*-----------------------------------------------------------------------------------*/
	/*	RETINA
	/*-----------------------------------------------------------------------------------*/
	$('.retina').retinise();
	/*-----------------------------------------------------------------------------------*/
	/*	PRETTIFY
	/*-----------------------------------------------------------------------------------*/
    window.prettyPrint && prettyPrint()
	/*-----------------------------------------------------------------------------------*/
	/*	IMAGE ICON HOVER
	/*-----------------------------------------------------------------------------------*/
    $('.icon-overlay a').prepend('<span class="icn-more"></span>');
	/*-----------------------------------------------------------------------------------*/
	/*	FANCYBOX
	/*-----------------------------------------------------------------------------------*/
    $(".fancybox-media").fancybox({
        arrows: true,
        padding: 0,
        closeBtn: true,
        openEffect: 'fade',
        closeEffect: 'fade',
        prevEffect: 'fade',
        nextEffect: 'fade',
        helpers: {
            media: {},
            overlay: {
                locked: false
            },
            buttons: false,
            thumbs: {
                width: 50,
                height: 50
            },
            title: {
                type: 'inside'
            }
        },
        beforeLoad: function () {
            var el, id = $(this.element).data('title-id');
            if (id) {
                el = $('#' + id);
                if (el.length) {
                    this.title = el.html();
                }
            }
        }
    });
	/*-----------------------------------------------------------------------------------*/
	/*	DATA REL
	/*-----------------------------------------------------------------------------------*/
    $('a[data-rel]').each(function () {
	    $(this).attr('rel', $(this).data('rel'));
	});
	/*-----------------------------------------------------------------------------------*/
	/*	SLIDER PRO
	/*-----------------------------------------------------------------------------------*/ 
		$( '.portfolio-slider' ).sliderPro({
			width: 1170,
			height: 600,
			arrows: true,
			buttons: true,
			autoHeight: true,
			waitForLayers: false,
			autoplay: true,
			autoScaleLayers: true,
			slideDistance: 0
		});
		
		$( '.blog-slider' ).sliderPro({
			width: 1170,
			height: 600,
			arrows: true,
			buttons: true,
			autoHeight: true,
			waitForLayers: false,
			autoplay: false,
			autoScaleLayers: true,
			slideDistance: 0
		});
		
		$( '.main-slider' ).sliderPro({
			width: 1170,
			height: 600,
			fade: true,
			arrows: true,
			buttons: false,
			autoHeight: true,
			autoScaleLayers: true,
			thumbnailArrows: false,
			autoplay: false,
			slideDistance: 0,
			thumbnailWidth: 141,
			thumbnailHeight: 106
		});
	/*-----------------------------------------------------------------------------------*/
	/*	TOOLTIP
	/*-----------------------------------------------------------------------------------*/
    if ($("[rel=tooltip]").length) {
        $("[rel=tooltip]").tooltip();
    }
	/*-----------------------------------------------------------------------------------*/
	/*	FORM
	/*-----------------------------------------------------------------------------------*/
    $('.forms').dcSlickForms();
    $('.comment-form input[title], .comment-form textarea, .forms textarea').each(function () {
        if ($(this).val() === '') {
            $(this).val($(this).attr('title'));
        }

        $(this).focus(function () {
            if ($(this).val() == $(this).attr('title')) {
                $(this).val('').addClass('focused');
            }
        });
        $(this).blur(function () {
            if ($(this).val() === '') {
                $(this).val($(this).attr('title')).removeClass('focused');
            }
        });
    });
	/*-----------------------------------------------------------------------------------*/
	/*	PARALLAX MOBILE
	/*-----------------------------------------------------------------------------------*/
    if (navigator.userAgent.match(/Android/i) ||
    navigator.userAgent.match(/webOS/i) ||
    navigator.userAgent.match(/iPhone/i) ||
    navigator.userAgent.match(/iPad/i) ||
    navigator.userAgent.match(/iPod/i) ||
    navigator.userAgent.match(/BlackBerry/i)) {
        $('.parallax').addClass('mobile');
    }
	/*-----------------------------------------------------------------------------------*/
	/*	TABS
	/*-----------------------------------------------------------------------------------*/
    $('.tabs.tabs-top').easytabs({
        animationSpeed: 300,
        updateHash: false
    });
	$('.panel-group').find('.panel-default:has(".in")').addClass('panel-active');
	
	$('.panel-group').on('shown.bs.collapse', function (e) {
	   $(e.target).closest('.panel-default').addClass(' panel-active');
	}).on('hidden.bs.collapse', function (e) {
	   $(e.target).closest('.panel-default').removeClass(' panel-active');
	});
	/*-----------------------------------------------------------------------------------*/
	/*	LOCALSCROLL
	/*-----------------------------------------------------------------------------------*/
	$('.navbar, .scroll').localScroll({
	    hash: true
    });
});
/*-----------------------------------------------------------------------------------*/
/*	PRELOADER
/*-----------------------------------------------------------------------------------*/
$(window).load(function() { // makes sure the whole site is loaded
		$('#status').fadeOut(); // will first fade out the loading animation
		$('#preloader').delay(350).fadeOut('slow'); // will fade out the white DIV that covers the website.
		$('body').delay(350).css({'overflow':'visible'});
})
/*-----------------------------------------------------------------------------------*/
/*	ISOTOPE
/*-----------------------------------------------------------------------------------*/
$( function() {
  // init Isotope
  var $container = $('.classic-masonry .isotope');
  
  $container.isotope({
    itemSelector: '.item',
    transitionDuration: '0.6s',
    masonry: { columnWidth: $container.width() / 12 },
    layoutMode: 'masonry'
  });
  
  $(window).resize(function(){
  	$container.isotope({
  		masonry: { columnWidth: $container.width() / 12 }
  	});
  });
  // bind filter button click
  $('.classic-masonry #filters').on( 'click', 'button', function() {
    var filterValue = $( this ).attr('data-filter');
    $container.isotope({ filter: filterValue });
  });
  // change is-checked class on buttons
  $('.classic-masonry .button-group').each( function( i, buttonGroup ) {
    var $buttonGroup = $( buttonGroup );
    $buttonGroup.on( 'click', 'button', function() {
      $buttonGroup.find('.is-checked').removeClass('is-checked');
      $( this ).addClass('is-checked');
    });
  });
  // layout Isotope again after all images have loaded
$container.imagesLoaded( function() {
  $container.isotope('layout');
});
});

$( function() {
  // init Isotope
  var $container = $('.full-portfolio .isotope').isotope({
    itemSelector: '.item',
    transitionDuration: '0.6s',
    masonry: {
      columnWidth: '.grid-sizer'
    }
  });
  // bind filter button click
  $('.full-portfolio #filters').on( 'click', 'button', function() {
    var filterValue = $( this ).attr('data-filter');
    $container.isotope({ filter: filterValue });
  });
  // change is-checked class on buttons
  $('.full-portfolio .button-group').each( function( i, buttonGroup ) {
    var $buttonGroup = $( buttonGroup );
    $buttonGroup.on( 'click', 'button', function() {
      $buttonGroup.find('.is-checked').removeClass('is-checked');
      $( this ).addClass('is-checked');
    });
  });
    // layout Isotope again after all images have loaded
$container.imagesLoaded( function() {
  $container.isotope('layout');
});
});

$('.button-group').click(function(e) {
        e.stopPropagation();
    });
    
$( function() {
  // init Isotope
  var $container = $('.grid-view.col2 .isotope');
  
  $container.isotope({
    itemSelector: '.post-grid',
    transitionDuration: '0.6s',
    masonry: { columnWidth: '.col-md-6.col-sm-12' },
    layoutMode: 'masonry'
  });
  
  $(window).resize(function(){
  	$container.isotope({
  		masonry: { columnWidth: '.col-md-6.col-sm-12' }
  	});
  });
  // layout Isotope again after all images have loaded
$container.imagesLoaded( function() {
  $container.isotope('layout');
});
});

$( function() {
  // init Isotope
  var $container = $('.grid-view.col3 .isotope');
  
  $container.isotope({
    itemSelector: '.post-grid',
    transitionDuration: '0.6s',
    masonry: { columnWidth: '.col-md-4.col-sm-12' },
    layoutMode: 'masonry'
  });
  
  $(window).resize(function(){
  	$container.isotope({
  		masonry: { columnWidth: '.col-md-4.col-sm-12' }
  	});
  });
  // layout Isotope again after all images have loaded
$container.imagesLoaded( function() {
  $container.isotope('layout');
});
});
/*-----------------------------------------------------------------------------------*/
/*	SCROLL NAVIGATION HIGHLIGHT
/*-----------------------------------------------------------------------------------*/
$( function() {
	headerWrapper		= parseInt($('.navbar').height(), 10);
    
    var header_height = $('.navbar').height();
	var shrinked_header_height = 61;
	
    $('.onepage section').css('padding-top', shrinked_header_height + 'px');  
    $('.onepage section').css('margin-top', -(shrinked_header_height) + 'px');
    $('.onepage section:first-of-type').css('padding-top', header_height + 'px');  
    $('.onepage section:first-of-type').css('margin-top', -(header_height) + 'px');
   
	offsetTolerance	= -(header_height);	
	//Detecting user's scroll
	$(window).scroll(function() {	
		//Check scroll position
		scrollPosition	= parseInt($(this).scrollTop(), 10);		
		//Move trough each menu and check its position with scroll position then add current class
		$('.navbar ul a').each(function() {
			thisHref				= $(this).attr('href');
			thisTruePosition	= parseInt($(thisHref).offset().top, 10);
			thisPosition 		= thisTruePosition - headerWrapper - offsetTolerance;			
			if(scrollPosition >= thisPosition) {				
				$('.current').removeClass('current');
				$('.navbar ul a[href='+ thisHref +']').parent('li').addClass('current');				
			}
		});	
		//If we're at the bottom of the page, move pointer to the last section
		bottomPage	= parseInt($(document).height(), 10) - parseInt($(window).height(), 10);		
		if(scrollPosition == bottomPage || scrollPosition >= bottomPage) {		
			$('.current').removeClass('current');
			$('.navbar ul a:last').parent('li').addClass('current');
		}
	});	
});