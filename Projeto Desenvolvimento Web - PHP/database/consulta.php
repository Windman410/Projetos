<?php

	include_once "conexao.php";

	$sql = "SELECT * FROM TB_PESSOA";

	$resultado = mysql_query($sql) or die("Erro: ".mysql_error());

	while($registro = mysql_fetch_array($resultado)){
		echo $registro["EMAIL_CADA"];." - "
		echo $registro["NOME_CADA"];." - "
		echo $registro["SOBR_CADA"];." - "
		echo $registro["TELE_CADA"];." - "
		echo $registro["SENH_CADA"];."<br>"
	}

	mysql_close($conexao);
?>
