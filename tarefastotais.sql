-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 02-Out-2024 às 14:13
-- Versão do servidor: 5.7.11
-- PHP Version: 7.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tarefas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tarefastotais`
--

DROP TABLE IF EXISTS `tarefastotais`;
CREATE TABLE IF NOT EXISTS `tarefastotais` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nomeTarefa` varchar(50) NOT NULL,
  `Data` varchar(50) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `Prioridade` varchar(235) NOT NULL,
  `conclusao` char(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tarefastotais`
--

INSERT INTO `tarefastotais` (`id`, `nomeTarefa`, `Data`, `descricao`, `Prioridade`, `conclusao`) VALUES
(5, 'limpar a pia', 'hoje', 'a pia esta suja', 'Alta', 'p');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
