<?php

	$nome = $_POST["form_nome"];
	$sobrenome = $_POST["form_sobrenome"];
	$email = $_POST["form_email"];
	$telefone = $_POST["form_telefone"];
	$senha = $_POST["form_senha"];

?>

<h1> Confirma os dados </h1>

<?php

	echo "Nome: ".$nome."<br>";
	echo "Sobrenome: ".$sobrenome."<br>";
	echo "E-mail: ".$email."<br>";
	echo "Telefone: ".$telefone."<br>";
	echo "Senha: ".$senha."<br>";

?>

	<form method="post" action="database/popula.php">
		<input type="hidden" name="form_nome"> <br> <br>
		<input type="hidden" name="form_sobrenome" id="form_sobrenome"> <br> <br>
		<input type="hidden" name="form_email" id="form_email"> <br> <br>
		<input type="hidden" name="form_email2" id="form_email2"> <br> <br>
		<input type="hidden" name="form_telefone" id="form_telefone"> <br> <br>
		<input type="hidden" name="form_senha" id="form_senha"> <br> <br>
		<input type="submit" value="submit"> <br> <br>
	</form>