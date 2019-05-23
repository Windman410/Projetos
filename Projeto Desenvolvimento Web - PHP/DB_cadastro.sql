-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 21-Ago-2015 às 19:26
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `db_cadastro`
--
CREATE DATABASE IF NOT EXISTS `db_cadastro` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `db_cadastro`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cada`
--

CREATE TABLE IF NOT EXISTS `tb_cada` (
  `EMAI_CADA` varchar(30) NOT NULL,
  `NOME_CADA` varchar(30) NOT NULL,
  `SOBR_CADA` varchar(30) NOT NULL,
  `TELE_CADA` int(11) NOT NULL,
  `SENH_CADA` varchar(30) NOT NULL,
  PRIMARY KEY (`EMAI_CADA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cada`
--

INSERT INTO `tb_cada` (`EMAI_CADA`, `NOME_CADA`, `SOBR_CADA`, `TELE_CADA`, `SENH_CADA`) VALUES
('blajo@gmail.com', 'José', 'Tubarão', 2147483647, 'bados'),
('leleioe@gmail.com', 'João', 'lagosta', 2147483647, 'bamni'),
('nanche@gmail.com', 'Maria', 'Camarão', 2147483647, 'banco_de_dados_666'),
('turmi@gmail.com', 'Pedro', 'Lula', 2147483647, 'banco6');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
