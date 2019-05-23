<?php 
	
	include_once "conexao.php";

	$sql = "TRUNCATE TABLE TB_PESSOA";

	mysql_query($sql) or die ("Erro: ".mysql_error());

	echo "Dados apagados";

	mysql_close($conexao);
?>