<?php
	$servidor = "localhost";
	$usuario = "root";
	$senha = "usbw";
	$database = "DB_CADASTRO";
	
	$conexao = mysql_connect($servidor, $usuario, $senha);

	if(!$conexao){
		echo mysql_error();
	} else{
		mysql_select_db($database, $conexao) or die(mysql_error());
	}
?>
