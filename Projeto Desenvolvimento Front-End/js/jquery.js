$(document).ready(function(){
	// --- MENU MOBILE ---
	$('.botaoMenuMobile').click(function(){
		$('.menuMobile').animate({left: 0}, 300);
		$('body').css('overflow', 'hidden');
		$('.pelicula').show();

	});

	$('.pelicula, #fechar').click(function(){
		SumirMenuMobile();
	});
	// --- FIM MENU MOBILE ---

	// BOTÃO TOPO
	$('#botao_topo').click(function(){
		$('body, html').animate({scrollTop:0}, 300);
	}); 

	// --- BANNER ---
	$('.slides').hide();
	$('.conjuntoSlides').find('.slides').first().toggleClass('atual').fadeIn();

	$('#anterior').bind('click', function(){moverBanner(1)});
	$('#proximo').bind('click', function(){moverBanner(0)});	

	setInterval(function(){moverBanner(0)}, 8000); 
	// --- FIM BANNER ---

	// --- COMEÇO SUBARTIGO ---
	$('#artigosProduto, .subArtigo').hover(function(){
		$('.subArtigo').css('display', 'block');
	}, function(){
		$('.subArtigo').css('display', 'none');		
	});

	$('.subArtigo nav ul li').eq(0).bind('mouseover', function(){passarSubArtigo(0)});
	$('.subArtigo nav ul li').eq(1).bind('mouseover', function(){passarSubArtigo(1)});
	$('.subArtigo nav ul li').eq(2).bind('mouseover', function(){passarSubArtigo(2)});
	
	// --- FIM SUBARTIGO ---

});
// SUMIR O MENU MOBILE QUANDO A PAGINA CRESCE
$(window).resize(function(){
	var largura = $(window).width();
	
	if(largura > 1000){		
		SumirMenuMobile();	
	}

});


function SumirMenuMobile(){
	$('.menuMobile').animate({left: -271}, 300);
	$('body').css('overflow', 'initial');
	$('.pelicula').hide();	
}


function moverBanner(i){
	if(i == 0){
		var atual = $('.conjuntoSlides').find('.atual').next().index();
	} else if(i == 1){
		var atual = $('.conjuntoSlides').find('.atual').prev().index();
	}

	if((atual == -1) || (!$('.slides').eq(atual).length ) ){
		if(i == 0){
			var atual = $('.conjuntoSlides').find('.slides').first().index();
		} else if(i == 1){
			var atual = $('.conjuntoSlides').find('.slides').last().index();
		}
	}
	$('.conjuntoSlides').find('.atual').toggleClass('atual').fadeOut();
	$('.slides').eq(atual).toggleClass('atual').fadeIn();
}

function passarSubArtigo(i){
	if(i == 0){
		$('#subArtigoImagem01').fadeIn();
		$('#subArtigoImagem02').fadeOut();
		$('#subArtigoImagem03').fadeOut();
	} else if(i == 1){
		$('#subArtigoImagem01').fadeOut();
		$('#subArtigoImagem02').fadeIn();
		$('#subArtigoImagem03').fadeOut();
	} else if(i == 2){
		$('#subArtigoImagem01').fadeOut();
		$('#subArtigoImagem02').fadeOut();
		$('#subArtigoImagem03').fadeIn();
	}
}
