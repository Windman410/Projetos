<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" type="text/css" href=" css/estilo.css">
		<meta charset="UTF-8">
	<title> </title>
</head>
<body>

	
	<header id="topo">		
		<figure>
			<img src="img/img01.png" alt="logo">
		</figure>	
		<?php include_once "paginas/menu.php" ?>
	</header>

	
	<form class="form" method="post" action="popula.php">
		<h1>Cadastre-se</h1>
		<p>*Dados Obrigatórios</p>

		<div class="campo">
			<label> Nome:* </label>
			<input type="text" name="form_nome" required id="form_nome"><br>
		</div>

		<div class="campo">
			<label> Sobrenome:* </label>
			<input type="text" name="form_sobrenome" id="form_sobrenome"><br>
		</div>

		<div class="campo">
			<label> E-mail:* </label>
			<input type="email" name="form_email" id="form_email"><br>
		</div>

		<div class="campo">
			<label> Repetir e-mail:* </label>
			<input type="text" name="form_repetiremail" id="form_email2"><br>
		</div>

		<div class="campo">
			<label> Telefone:* </label>
			<input type="text" name="form_telefone" id="form_telefone"><br>
		</div>

		<div class="campo">
			<label> Criar Senha:* </label>
			<input type="text" name="form_senha" id="form_senha"><br>
		</div>
	
		<div class="campo">
			<input type="image" alt="enviar" src="img/botao.png"><br>
		</div>

	</form>

	
</body>
</html>

