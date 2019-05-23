$(document).ready(function(){ 
	$('#nome').empty();
	$('#email').empty();
	$('#mensagem').empty();
	
	$('#nome').focusout(function(){
		$('form .erro').remove();
		if( $('#nome').val() == "" )
		$(this).before('<p class="erro"> campo obrigatório </p>');		
	});
	$('#email').focusout(function(){
		$('form .erro').remove();
		if( $('#email').val() == "" )
		$(this).before('<p class="erro"> campo obrigatório </p>');		
	});
	$('#mensagem').focusout(function(){
		$('form .erro').remove();
		if( $('#mensagem').val() == "" )
		$(this).before('<p class="erro"> campo obrigatório </p>');		
	});
	
	$(':submit').click(function(){
		validaForm();		
	});

});

function validaForm(){
	$('form .erro').remove();
		
	var nome      = $('#nome').val();
	var sobrenome = $('#email').val();
	var mensagem = $('#mensagem').val();
		
	if( nome == "" )
		$('#nome').before('<p class="erro"> campo obrigatório </p>');
			
	if( sobrenome == "" )
		$('#email').before('<p class="erro"> campo obrigatório </p>');
	
	if( mensagem == "" )
		$('#mensagem').before('<p class="erro"> campo obrigatório </p>');
	
	if( $('form .erro').length > 0 )
		return false;	
}
