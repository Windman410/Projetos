<?php

	include_once "conexao.php";

	$nome = $_POST["form_nome"];
	$sobrenome = $_POST["form_sobrenome"];
	$email = $_POST["form_email"];
	$telefone = $_POST["form_telefone"];
	$senha = $_POST["form_senha"];

	$sql = "INSERT INTO TB_PESSOA
				(EMAI_CADA, NOME_CADA, SOBR_CADA, TELE_CADA, SENH_CADA)
			VALUES
				('$nome', '$sobrenome', '$email', '$telefone', '$senha')";

	mysql_query($sql) or die("Erro: ".mysql_error());

	if(mysql_affected_rows($conexao) == 1){
		echo "Cadastro efetuado! <br>";
	} else{
		echo "Erro no cadastro <br>";
	}

	mysql_close($conexao);

	include_once "consulta.php";
?>
