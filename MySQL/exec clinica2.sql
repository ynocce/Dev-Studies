-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Abr-2022 às 17:47
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

create database senai;
use senai;

CREATE TABLE `ambulatorios` (
  `nroa` int(11) NOT NULL,
  `andar` decimal(3,0) NOT NULL,
  `capacidade` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `ambulatorios` (`nroa`, `andar`, `capacidade`) VALUES
(1, '1', 14),
(2, '2', 9),
(3, '3', 3),
(4, '4', 2),
(5, '5', 5),
(6, '6', 0),
(7, '7', 5),
(8, '8', 5),
(9, '9', 3),
(10, '10', 10),
(11, '11', 10),
(12, '12', 5),
(13, '13', 4),
(14, '14', 10),
(15, '15', 13),
(16, '16', 1),
(17, '17', 13),
(18, '18', 13),
(19, '19', 5),
(20, '20', 14),
(21, '21', 6),
(22, '22', 8),
(23, '23', 8),
(24, '24', 3),
(25, '25', 9),
(26, '26', 11),
(27, '27', 4),
(28, '28', 14),
(29, '29', 5);


CREATE TABLE `consultas` (
  `codm` int(11) NOT NULL,
  `codp` int(11) NOT NULL,
  `data` date NOT NULL,
  `hora` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `consultas` (`codm`, `codp`, `data`, `hora`) VALUES
(1, 2, '2022-03-28', '09:00:00'),
(1, 3, '2022-04-05', '15:00:00'),
(1, 3, '2022-04-16', '16:00:00'),
(1, 4, '2022-03-26', '14:00:00'),
(1, 6, '2022-04-09', '17:00:00'),
(1, 10, '2022-03-20', '13:00:00'),
(1, 10, '2022-03-31', '16:00:00'),
(1, 12, '2022-04-14', '09:00:00'),
(1, 13, '2022-04-03', '08:00:00'),
(1, 15, '2022-03-08', '16:00:00'),
(1, 15, '2022-04-01', '14:00:00'),
(1, 18, '2022-04-14', '11:00:00'),
(1, 18, '2022-04-18', '15:00:00'),
(1, 20, '2022-03-13', '16:00:00'),
(2, 1, '2022-03-18', '10:00:00'),
(2, 3, '2022-04-17', '08:00:00'),
(2, 7, '2022-04-08', '10:00:00'),
(2, 9, '2022-04-18', '08:00:00'),
(2, 10, '2022-03-28', '10:00:00'),
(2, 10, '2022-04-11', '14:00:00'),
(2, 12, '2022-03-25', '10:00:00'),
(2, 17, '2022-03-02', '09:00:00'),
(2, 17, '2022-03-19', '17:00:00'),
(2, 17, '2022-04-04', '10:00:00'),
(2, 19, '2022-04-10', '14:00:00'),
(2, 21, '2022-04-17', '13:00:00'),
(3, 3, '2022-03-18', '08:00:00'),
(3, 3, '2022-04-14', '14:00:00'),
(3, 6, '2022-03-19', '17:00:00'),
(3, 7, '2022-03-11', '08:00:00'),
(3, 7, '2022-04-17', '13:00:00'),
(3, 10, '2022-03-08', '08:00:00'),
(3, 13, '2022-04-13', '08:00:00'),
(3, 15, '2022-03-11', '17:00:00'),
(3, 15, '2022-04-18', '09:00:00'),
(3, 16, '2022-03-08', '08:00:00'),
(3, 17, '2022-03-06', '12:00:00'),
(3, 17, '2022-03-06', '16:00:00'),
(3, 17, '2022-03-15', '17:00:00'),
(3, 18, '2022-03-04', '10:00:00'),
(4, 2, '2022-03-27', '13:00:00'),
(4, 3, '2022-03-21', '15:00:00'),
(4, 5, '2022-03-24', '09:00:00'),
(4, 8, '2022-03-08', '09:00:00'),
(4, 8, '2022-03-18', '12:00:00'),
(4, 8, '2022-03-19', '10:00:00'),
(4, 9, '2022-04-03', '08:00:00'),
(4, 11, '2022-03-18', '12:00:00'),
(4, 17, '2022-04-07', '15:00:00'),
(4, 18, '2022-04-02', '17:00:00'),
(5, 2, '2022-03-05', '16:00:00'),
(5, 7, '2022-03-22', '12:00:00'),
(5, 9, '2022-04-17', '08:00:00'),
(5, 10, '2022-03-24', '17:00:00'),
(5, 12, '2022-03-05', '12:00:00'),
(5, 12, '2022-03-25', '09:00:00'),
(5, 14, '2022-04-16', '10:00:00'),
(5, 15, '2022-03-21', '14:00:00'),
(5, 16, '2022-03-12', '11:00:00'),
(5, 16, '2022-04-19', '15:00:00'),
(5, 17, '2022-03-11', '10:00:00'),
(5, 19, '2022-03-06', '08:00:00'),
(6, 7, '2022-03-15', '13:00:00'),
(6, 7, '2022-04-16', '08:00:00'),
(6, 8, '2022-04-06', '11:00:00'),
(6, 9, '2022-04-08', '09:00:00'),
(6, 11, '2022-04-04', '10:00:00'),
(6, 13, '2022-03-09', '09:00:00'),
(6, 16, '2022-04-08', '12:00:00'),
(6, 21, '2022-03-18', '09:00:00'),
(7, 1, '2022-03-25', '12:00:00'),
(7, 2, '2022-03-19', '10:00:00'),
(7, 3, '2022-03-21', '13:00:00'),
(7, 4, '2022-04-19', '09:00:00'),
(7, 9, '2022-04-03', '09:00:00'),
(7, 11, '2022-03-21', '15:00:00'),
(7, 12, '2022-03-04', '14:00:00'),
(7, 12, '2022-03-06', '15:00:00'),
(7, 14, '2022-03-20', '16:00:00'),
(7, 14, '2022-03-30', '17:00:00'),
(7, 15, '2022-03-06', '09:00:00'),
(7, 15, '2022-03-11', '14:00:00'),
(7, 15, '2022-04-08', '08:00:00'),
(7, 21, '2022-04-09', '08:00:00'),
(8, 1, '2022-03-17', '17:00:00'),
(8, 3, '2022-03-15', '08:00:00'),
(8, 3, '2022-03-23', '13:00:00'),
(8, 4, '2022-03-20', '16:00:00'),
(8, 7, '2022-03-30', '12:00:00'),
(8, 10, '2022-03-20', '17:00:00'),
(8, 10, '2022-04-11', '15:00:00'),
(8, 11, '2022-03-24', '12:00:00'),
(8, 13, '2022-03-10', '09:00:00'),
(8, 13, '2022-03-14', '16:00:00'),
(8, 13, '2022-03-29', '12:00:00'),
(8, 14, '2022-03-31', '08:00:00'),
(8, 16, '2022-03-16', '14:00:00'),
(8, 18, '2022-04-06', '12:00:00'),
(8, 18, '2022-04-06', '13:00:00'),
(9, 3, '2022-03-22', '10:00:00'),
(9, 4, '2022-04-17', '08:00:00'),
(9, 5, '2022-03-25', '15:00:00'),
(9, 6, '2022-04-01', '16:00:00'),
(9, 6, '2022-04-03', '17:00:00'),
(9, 7, '2022-03-25', '09:00:00'),
(9, 8, '2022-03-23', '15:00:00'),
(9, 10, '2022-04-08', '14:00:00'),
(9, 12, '2022-03-26', '11:00:00'),
(9, 17, '2022-03-12', '13:00:00'),
(10, 1, '2022-04-04', '11:00:00'),
(10, 2, '2022-04-05', '15:00:00'),
(10, 4, '2022-03-18', '17:00:00'),
(10, 4, '2022-03-25', '12:00:00'),
(10, 5, '2022-03-14', '11:00:00'),
(10, 5, '2022-03-18', '12:00:00'),
(10, 7, '2022-04-16', '17:00:00'),
(10, 9, '2022-03-30', '09:00:00'),
(10, 10, '2022-03-08', '13:00:00'),
(10, 12, '2022-02-28', '16:00:00'),
(10, 14, '2022-03-29', '14:00:00'),
(10, 19, '2022-04-10', '09:00:00'),
(10, 20, '2022-03-21', '16:00:00'),
(11, 3, '2022-04-02', '14:00:00'),
(11, 5, '2022-03-01', '12:00:00'),
(11, 7, '2022-03-05', '10:00:00'),
(11, 7, '2022-03-25', '11:00:00'),
(11, 8, '2022-03-06', '10:00:00'),
(11, 8, '2022-03-08', '17:00:00'),
(11, 11, '2022-03-20', '08:00:00'),
(11, 15, '2022-03-26', '12:00:00'),
(11, 15, '2022-03-27', '08:00:00'),
(11, 17, '2022-04-17', '11:00:00'),
(11, 21, '2022-03-14', '09:00:00'),
(12, 1, '2022-03-25', '12:00:00'),
(12, 2, '2022-04-01', '12:00:00'),
(12, 5, '2022-04-03', '16:00:00'),
(12, 5, '2022-04-05', '10:00:00'),
(12, 7, '2022-03-13', '13:00:00'),
(12, 8, '2022-03-12', '15:00:00'),
(12, 11, '2022-03-19', '15:00:00'),
(12, 14, '2022-03-10', '13:00:00'),
(12, 17, '2022-04-14', '12:00:00'),
(13, 2, '2022-04-11', '10:00:00'),
(13, 7, '2022-02-28', '12:00:00'),
(13, 7, '2022-03-25', '08:00:00'),
(13, 8, '2022-03-27', '08:00:00'),
(13, 9, '2022-04-03', '13:00:00'),
(13, 11, '2022-04-06', '14:00:00'),
(13, 12, '2022-04-04', '11:00:00'),
(13, 13, '2022-03-12', '14:00:00'),
(13, 13, '2022-03-13', '10:00:00'),
(13, 15, '2022-03-18', '15:00:00'),
(13, 17, '2022-03-06', '11:00:00'),
(13, 21, '2022-03-12', '13:00:00'),
(13, 21, '2022-03-26', '11:00:00'),
(14, 5, '2022-03-30', '16:00:00'),
(14, 6, '2022-03-17', '15:00:00'),
(14, 8, '2022-04-13', '08:00:00'),
(14, 9, '2022-03-17', '12:00:00'),
(14, 12, '2022-03-03', '14:00:00'),
(14, 13, '2022-03-15', '12:00:00'),
(14, 14, '2022-03-14', '17:00:00'),
(14, 15, '2022-03-26', '14:00:00'),
(14, 16, '2022-04-07', '09:00:00'),
(14, 17, '2022-03-12', '16:00:00'),
(15, 1, '2022-04-16', '09:00:00'),
(15, 2, '2022-03-01', '10:00:00'),
(15, 2, '2022-03-09', '13:00:00'),
(15, 2, '2022-04-17', '08:00:00'),
(15, 3, '2022-04-13', '15:00:00'),
(15, 4, '2022-04-10', '11:00:00'),
(15, 6, '2022-03-24', '09:00:00'),
(15, 7, '2022-04-17', '14:00:00'),
(15, 11, '2022-03-16', '13:00:00'),
(15, 11, '2022-04-04', '16:00:00'),
(15, 13, '2022-03-29', '17:00:00'),
(15, 15, '2022-03-16', '16:00:00'),
(15, 15, '2022-04-10', '08:00:00'),
(15, 16, '2022-03-08', '11:00:00'),
(15, 18, '2022-04-12', '16:00:00'),
(16, 1, '2022-04-10', '17:00:00'),
(16, 6, '2022-03-26', '15:00:00'),
(16, 10, '2022-02-28', '17:00:00'),
(16, 10, '2022-03-05', '14:00:00'),
(16, 14, '2022-04-04', '15:00:00'),
(16, 19, '2022-03-23', '14:00:00'),
(16, 20, '2022-03-10', '09:00:00'),
(16, 20, '2022-04-01', '17:00:00'),
(17, 1, '2022-03-31', '09:00:00'),
(17, 3, '2022-03-08', '10:00:00'),
(17, 3, '2022-04-16', '17:00:00'),
(17, 4, '2022-03-12', '16:00:00'),
(17, 6, '2022-03-05', '12:00:00'),
(17, 6, '2022-03-18', '10:00:00'),
(17, 6, '2022-03-21', '14:00:00'),
(17, 9, '2022-04-09', '12:00:00'),
(17, 13, '2022-03-16', '17:00:00'),
(17, 13, '2022-04-06', '10:00:00'),
(17, 15, '2022-03-17', '11:00:00'),
(17, 17, '2022-04-08', '10:00:00'),
(17, 21, '2022-04-13', '09:00:00'),
(18, 1, '2022-03-03', '10:00:00'),
(18, 2, '2022-03-30', '15:00:00'),
(18, 9, '2022-04-14', '16:00:00'),
(18, 11, '2022-04-02', '13:00:00'),
(18, 12, '2022-03-29', '10:00:00'),
(18, 12, '2022-04-15', '16:00:00'),
(18, 13, '2022-04-14', '13:00:00'),
(18, 14, '2022-04-04', '11:00:00'),
(18, 14, '2022-04-11', '17:00:00'),
(18, 17, '2022-03-05', '11:00:00'),
(18, 20, '2022-03-24', '13:00:00'),
(18, 20, '2022-04-17', '12:00:00'),
(18, 21, '2022-03-26', '17:00:00'),
(19, 1, '2022-03-08', '15:00:00'),
(19, 4, '2022-03-13', '16:00:00'),
(19, 6, '2022-04-11', '14:00:00'),
(19, 7, '2022-03-19', '14:00:00'),
(19, 9, '2022-03-21', '17:00:00'),
(19, 12, '2022-04-14', '10:00:00'),
(19, 13, '2022-03-15', '13:00:00'),
(19, 13, '2022-04-08', '14:00:00'),
(19, 15, '2022-03-01', '08:00:00'),
(19, 15, '2022-04-07', '11:00:00'),
(19, 15, '2022-04-07', '13:00:00'),
(20, 3, '2022-03-25', '12:00:00'),
(20, 5, '2022-03-11', '16:00:00'),
(20, 6, '2022-03-29', '11:00:00'),
(20, 12, '2022-03-12', '11:00:00'),
(20, 14, '2022-03-24', '14:00:00'),
(20, 16, '2022-04-02', '17:00:00'),
(20, 18, '2022-04-12', '11:00:00'),
(20, 20, '2022-02-28', '15:00:00'),
(20, 20, '2022-03-16', '11:00:00'),
(21, 2, '2022-03-05', '09:00:00'),
(21, 5, '2022-03-23', '13:00:00'),
(21, 10, '2022-03-01', '11:00:00'),
(21, 11, '2022-04-03', '12:00:00'),
(21, 14, '2022-03-18', '08:00:00'),
(21, 14, '2022-04-08', '13:00:00'),
(50, 10, '2022-04-11', '11:00:00'),
(50, 14, '2022-04-12', '15:00:00'),
(50, 20, '2022-04-09', '16:00:00');


CREATE TABLE `dependetes` (
  `codd` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `nascimento` date DEFAULT NULL,
  `codf` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `dependetes` (`codd`, `nome`, `nascimento`, `codf`) VALUES
(1, 'Miguel', '2005-03-28', 32),
(2, 'Arthur', '2007-04-05', 34),
(3, 'Gael', '2007-04-16', 24),
(4, 'Heitor', '2005-03-26', 7),
(5, 'Theo', '2007-04-09', 9),
(6, 'Davi', '2005-03-20', 31),
(7, 'Gabriel', '2005-03-31', 19),
(8, 'Bernardo', '2007-04-14', 9),
(9, 'Samuel', '2007-04-03', 1),
(10, 'Joao', '2005-03-08', 12),
(11, 'Helena', '2007-04-01', 41),
(12, 'Alice', '2007-04-14', 17),
(13, 'Laura', '2007-04-18', 9),
(14, 'Maria', '2005-03-13', 25),
(15, 'Valentina', '2005-03-18', 35),
(16, 'Heloisa', '2007-04-17', 34),
(17, 'Maria', '2007-04-08', 5),
(18, 'Maria', '2007-04-18', 26),
(19, 'Maria', '2005-03-28', 14),
(20, 'Sophia', '2007-04-11', 11),
(21, 'Isabella', '2005-03-25', 35),
(22, 'Sofia', '2005-03-02', 30),
(23, 'Sofya', '2005-03-19', 26),
(24, 'Sofia', '2007-04-04', 4),
(25, 'Sophia', '2007-04-10', 33),
(26, 'Zs?fia', '2007-04-17', 4),
(27, 'Emilie', '2005-03-18', 42),
(28, 'Emili', '2007-04-14', 26),
(29, 'Emilie', '2005-03-19', 8),
(30, 'Emily', '2005-03-11', 7),
(31, 'Emmilie', '2007-04-17', 17),
(32, 'emilie', '2005-03-08', 12),
(33, 'emily', '2007-04-13', 18),
(34, 'Amelia', '2005-03-11', 9),
(35, 'Mila', '2007-04-18', 30),
(36, 'Emma', '2005-03-08', 27),
(37, 'Mia', '2005-03-06', 26),
(38, 'Lili', '2005-03-06', 39),
(39, 'Lilli', '2005-03-15', 17),
(40, 'Lillie', '2005-03-04', 23),
(41, 'Lilly', '2005-03-27', 31),
(42, 'Lily', '2005-03-21', 40),
(43, 'Lyli', '2005-03-24', 41),
(44, 'Liya', '2005-03-08', 36),
(45, 'Lia', '2005-03-18', 4),
(46, 'Liah', '2005-03-19', 33),
(47, 'Liia', '2007-04-03', 34),
(48, 'Lya', '2005-03-18', 28),
(49, 'Lia', '2007-04-07', 27),
(50, 'emilia', '2007-04-02', 9),
(51, 'Emilia', '2005-03-05', 8),
(52, 'Emilja', '2005-03-22', 35),
(53, 'Emilya', '2007-04-17', 8),
(54, 'Emilia', '2005-03-24', 24),
(55, 'Emmilia', '2005-03-05', 27),
(56, 'Emmylia', '2005-03-25', 18),
(57, 'Emylia', '2007-04-16', 16),
(58, 'Emilia', '2005-03-21', 11),
(59, 'Emilia', '2005-03-12', 8),
(60, 'Lyla', '2007-04-19', 18),
(61, 'Laila', '2005-03-11', 7),
(62, 'Alyssia', '2005-03-06', 17),
(63, 'Alycia', '2005-03-15', 25),
(64, 'emie', '2007-04-16', 10),
(65, 'Emi', '2007-04-06', 12),
(66, 'Emie', '2007-04-08', 32),
(67, 'Emmie', '2007-04-04', 6),
(68, 'Emmy', '2005-03-09', 26),
(69, 'Emy', '2007-04-08', 21),
(70, 'emy', '2005-03-18', 34),
(71, 'Hannah', '2005-03-25', 23),
(72, 'Sophy', '2005-03-19', 15),
(73, 'Sofi', '2005-03-21', 42),
(74, 'Sofie', '2007-04-19', 24),
(75, 'Sofy', '2007-04-03', 26),
(76, 'Sophi', '2005-03-21', 11),
(77, 'Sophie', '2005-03-04', 11),
(78, 'Cloe', '2005-03-06', 14),
(79, 'Chloe', '2005-03-20', 16),
(80, 'Cloe', '2005-03-30', 15),
(81, 'Khloe', '2005-03-06', 7),
(82, 'Khloe', '2005-03-11', 17),
(83, 'Kloe', '2007-04-08', 29),
(84, 'Adeline', '2007-04-09', 3),
(85, 'Addeline', '2005-03-17', 38),
(86, 'Elea', '2005-03-15', 22),
(87, 'Olivia', '2005-03-23', 35),
(88, 'Charlotte', '2005-03-20', 18),
(89, 'Mahlia', '2005-03-30', 36),
(90, 'Maliah', '2005-03-20', 27),
(91, 'Maliya', '2007-04-11', 36),
(92, 'Maliyah', '2005-03-24', 35),
(93, 'Malia', '2005-03-10', 5),
(94, 'Thalia', '2005-03-14', 36),
(95, 'Tahlia', '2005-03-29', 15),
(96, 'Talia', '2005-03-31', 2),
(97, 'Talja', '2005-03-16', 36),
(98, 'Talya', '2007-04-06', 3),
(99, 'Thalya', '2007-04-06', 17),
(100, 'Louna', '2005-03-22', 6),
(101, 'Luna', '2007-04-17', 12),
(102, 'Loelia', '2005-03-25', 23),
(103, 'Ciara', '2007-04-01', 16),
(104, 'Kyara', '2007-04-03', 38),
(105, 'Ella', '2005-03-25', 15),
(106, 'Yaelle', '2005-03-23', 28),
(107, 'Maya', '2007-04-08', 34),
(108, 'Maia', '2005-03-26', 5),
(109, 'Lalie', '2005-03-12', 1),
(110, 'Myrthe', '2007-04-04', 6),
(111, 'Mirthe', '2007-04-05', 35),
(112, 'Zoe', '2005-03-18', 41),
(113, 'Zoey', '2005-03-25', 13),
(114, 'ZoE', '2005-03-14', 34),
(115, 'Zoe', '2005-03-18', 30),
(116, 'Allison', '2007-04-16', 27),
(117, 'Alyson', '2005-03-30', 11),
(118, 'Julia', '2005-03-08', 38),
(119, 'Thea', '2018-02-28', 18),
(120, 'Tea', '2005-03-29', 30),
(121, 'Ellyna', '2007-04-10', 34),
(122, 'Elyna', '2005-03-21', 23),
(123, 'Maisie', '2007-04-02', 17),
(124, 'Anae', '2005-03-01', 34),
(125, 'Kali', '2005-03-05', 6),
(126, 'Cali', '2005-03-25', 9),
(127, 'Calie', '2005-03-06', 30),
(128, 'Eloise', '2005-03-08', 19),
(129, 'Maiwen', '2005-03-20', 20),
(130, 'Ava', '2005-03-26', 39),
(131, 'Lyana', '2005-03-27', 27),
(132, 'Maylis', '2007-04-17', 42),
(133, 'Ophelia', '2005-03-14', 34),
(134, 'Alya', '2005-03-25', 34),
(135, 'Alia', '2007-04-01', 34),
(136, 'Karlin', '2007-04-03', 34),
(137, 'Ilyana', '2007-04-05', 15),
(138, 'Amelie', '2005-03-13', 6),
(139, 'Kaylee', '2005-03-12', 42);



CREATE TABLE `funcionarios` (
  `codf` int(11) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `idade` smallint(6) DEFAULT NULL,
  `cpf` decimal(11,0) DEFAULT NULL,
  `cidade` varchar(30) DEFAULT NULL,
  `salario` decimal(10,0) DEFAULT NULL,
  `cargo` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `funcionarios` (`codf`, `nome`, `idade`, `cpf`, `cidade`, `salario`, `cargo`) VALUES
(1, 'jose', 22, '10000022', 'cambe', '1250', 'secretario'),
(2, 'Olivia', 23, '10000023', 'ibipora', '1500', 'assistente'),
(3, 'Sophia', 29, '10000024', 'apucarana', '1600', 'tecnico enfermagem'),
(4, 'Lily', 32, '10000025', 'londrina', '1400', 'tecnico de informati'),
(5, 'Ava', 41, '10000026', 'cambe', '1575', 'secretario'),
(6, 'Mia', 25, '10000027', 'ibipora', '1630', 'assistente'),
(7, 'Isla', 33, '10000028', 'apucarana', '1685', 'tecnico enfermagem'),
(8, 'Amelia', 22, '10000029', 'londrina', '1740', 'tecnico de informati'),
(9, 'Freya', 23, '10000030', 'cambe', '1795', 'secretario'),
(10, 'Isabella', 29, '10000031', 'ibipora', '1850', 'assistente'),
(11, 'Emily', 32, '10000032', 'apucarana', '1905', 'tecnico enfermagem'),
(12, 'Aria', 41, '10000033', 'londrina', '1960', 'tecnico de informati'),
(13, 'Evie', 25, '10000034', 'cambe', '2015', 'secretario'),
(14, 'Grace', 33, '10000035', 'ibipora', '2070', 'assistente'),
(15, 'Isabelle', 22, '10000036', 'apucarana', '2125', 'tecnico enfermagem'),
(16, 'Ella', 23, '10000037', 'londrina', '2180', 'tecnico de informati'),
(17, 'Ivy', 29, '10000038', 'cambe', '2235', 'secretario'),
(18, 'Sophie', 32, '10000039', 'ibipora', '2290', 'assistente'),
(19, 'Willow', 41, '10000040', 'apucarana', '2345', 'tecnico enfermagem'),
(20, 'Charlotte', 25, '10000041', 'londrina', '2400', 'tecnico de informati'),
(21, 'Elsie', 33, '10000042', 'cambe', '2455', 'secretario'),
(22, 'Antonio', 26, '11122233345', 'londrina', '1250', 'secretario'),
(23, 'Sofia', 30, '11123233346', 'cambe', '1500', 'assistente'),
(24, 'Maria', 31, '11122233347', 'ibipora', '1600', 'tecnico enfermagem'),
(25, 'Lucia', 32, '11122233348', 'arapongas', '1400', 'tecnico de informati'),
(26, 'Martina', 28, '11122233349', 'londrina', '1575', 'secretario'),
(27, 'Catalina', 29, '11122233306', 'cambe', '1630', 'assistente'),
(28, 'Elena', 26, '11122233317', 'ibipora', '1685', 'tecnico enfermagem'),
(29, 'Emilia', 30, '11122233324', 'arapongas', '1740', 'tecnico de informati'),
(30, 'Valentina', 31, '11122233335', 'londrina', '1795', 'secretario'),
(31, 'Paula', 32, '11122233346', 'cambe', '1850', 'assistente'),
(32, 'Zoe', 28, '11122233357', 'ibipora', '1905', 'tecnico enfermagem'),
(33, 'Santiago', 29, '11122233364', 'arapongas', '1960', 'tecnico de informati'),
(34, 'Mateo', 26, '11122233375', 'londrina', '2015', 'secretario'),
(35, 'Juan', 30, '11122233386', 'cambe', '2070', 'assistente'),
(36, 'Matias', 31, '11122233947', 'ibipora', '2125', 'tecnico enfermagem'),
(37, 'Nicolis', 32, '11122233144', 'arapongas', '2180', 'tecnico de informati'),
(38, 'Benjamin', 28, '11122233245', 'londrina', '2235', 'secretario'),
(39, 'Pedro', 29, '11122232246', 'cambe', '2290', 'assistente'),
(40, 'Tomis', 26, '11122233547', 'ibipora', '2345', 'tecnico enfermagem'),
(41, 'Thiago', 30, '11122233394', 'arapongas', '2400', 'tecnico de informati'),
(42, 'Santino', 31, '11122233344', 'londrina', '2455', 'secretario');


CREATE TABLE `medicos` (
  `codm` int(11) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `idade` smallint(6) NOT NULL,
  `especialidade` char(20) DEFAULT NULL,
  `cpf` decimal(11,0) DEFAULT NULL,
  `cidade` varchar(30) DEFAULT NULL,
  `nroa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT INTO `medicos` (`codm`, `nome`, `idade`, `especialidade`, `cpf`, `cidade`, `nroa`) VALUES
(1, 'Antonio', 26, 'ortopedia', '11122233345', 'londrina', 1),
(2, 'Sofia', 30, 'otorrinolaringologia', '11123233346', NULL, 2),
(3, 'Maria', 31, 'cardiologista', '11122233347', 'ibipora', 1),
(4, 'Lucia', 32, NULL, '11122233348', 'arapongas', NULL),
(5, 'Martina', 28, 'ortopedia', '11122233349', 'londrina', 6),
(6, 'Catalina', 29, 'otorrinolaringologia', '11122233306', 'cambe', 5),
(7, 'Elena', 26, 'cardiologista', '11122233317', 'ibipora', NULL),
(8, 'Emilia', 30, 'psiquiatra', '11122233324', 'arapongas', 9),
(9, 'Valentina', 31, 'ortopedia', '11122233335', 'londrina', 3),
(10, 'Paula', 32, 'otorrinolaringologia', '11122233346', 'cambe', 20),
(11, 'Zoe', 2, 'cardiologista', '11122233357', 'ibipora', 15),
(12, 'Santiago', 29, 'psiquiatra', '11122233364', 'arapongas', 12),
(13, 'Mateo', 26, 'ortopedia', '11122233375', 'londrina', 1),
(14, 'Juan', 30, 'otorrinolaringologia', '11122233386', 'cambe', 2),
(15, 'Matias', 31, 'cardiologista', '11122233947', NULL, 3),
(16, 'Nicolis', 32, 'psiquiatra', '11122233144', 'arapongas', 4),
(17, 'Benjamin', 28, 'ortopedia', '11122233245', 'londrina', 6),
(18, 'Pedro', 29, 'otorrinolaringologia', '11122232246', 'cambe', 5),
(19, 'Tomis', 26, 'cardiologista', '11122233547', 'ibipora', 8),
(20, 'Thiago', 30, NULL, '11122233394', 'arapongas', NULL),
(21, 'Santino', 31, 'ortopedia', '11122233344', NULL, 3),
(50, 'carone', 35, 'ortopedia', '152', 'cidade', 2);



CREATE TABLE `pacientes` (
  `codp` int(11) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `idade` smallint(6) NOT NULL,
  `cidade` char(30) DEFAULT NULL,
  `cpf` decimal(11,0) DEFAULT NULL,
  `doenca` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;



INSERT INTO `pacientes` (`codp`, `nome`, `idade`, `cidade`, `cpf`, `doenca`) VALUES
(1, 'carlos', 21, 'londrina', '11122233344', 'cancer'),
(2, 'Miguel', 22, '', '11122233345', 'Alzheimer'),
(3, 'Arthur', 25, '', '11123233346', 'Amebiase'),
(4, 'Gael', 31, '', '11122233347', 'Amidalite'),
(5, 'Heitor', 28, '', '11122233348', 'Amiloidose'),
(6, 'Theo', 27, '', '11122233349', 'Amnesia'),
(7, 'Davi', 32, '', '11122233306', 'cancer'),
(8, 'Gabriel', 32, '', '11122233317', 'Alzheimer'),
(9, 'Bernardo', 19, '', '11122233324', 'Amebiase'),
(10, 'Samuel', 25, '', '11122233335', 'Amidalite'),
(11, 'Joao Miguel', 20, '', '11122233346', 'Amiloidose'),
(12, 'Helena', 30, '', '11122233357', 'Amnesia'),
(13, 'Alice', 29, '', '11122233364', 'cancer'),
(14, 'Laura', 21, '', '11122233375', 'Alzheimer'),
(15, 'Maria Alice', 32, '', '11122233386', 'Amebiase'),
(16, 'Valentina', 31, '', '11122233947', 'Amidalite'),
(17, 'Heloisa', 31, '', '11122233144', 'Amiloidose'),
(18, 'Maria Clara', 32, '', '11122233245', 'Amnesia'),
(19, 'Maria Cecilia', 30, '', '11122232246', 'cancer'),
(20, 'Maria Julia', 22, '', '11122233547', 'Alzheimer'),
(21, 'Sophia', 26, '', '11122233394', 'Amebiase');


ALTER TABLE `ambulatorios`
  ADD PRIMARY KEY (`nroa`);

ALTER TABLE `consultas`
  ADD PRIMARY KEY (`codm`,`codp`,`data`,`hora`),
  ADD KEY `codp` (`codp`);

ALTER TABLE `dependetes`
  ADD PRIMARY KEY (`codd`),
  ADD KEY `codf` (`codf`);


ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`codf`),
  ADD UNIQUE KEY `cpf` (`cpf`);


ALTER TABLE `medicos`
  ADD PRIMARY KEY (`codm`),
  ADD KEY `nroa` (`nroa`);


ALTER TABLE `pacientes`
  ADD PRIMARY KEY (`codp`),
  ADD UNIQUE KEY `cpf` (`cpf`);


ALTER TABLE `consultas`
  ADD CONSTRAINT `consultas_ibfk_1` FOREIGN KEY (`codm`) REFERENCES `medicos` (`codm`),
  ADD CONSTRAINT `consultas_ibfk_2` FOREIGN KEY (`codp`) REFERENCES `pacientes` (`codp`);

ALTER TABLE `dependetes`
  ADD CONSTRAINT `dependetes_ibfk_1` FOREIGN KEY (`codf`) REFERENCES `funcionarios` (`codf`);


ALTER TABLE `medicos`
  ADD CONSTRAINT `medicos_ibfk_1` FOREIGN KEY (`nroa`) REFERENCES `ambulatorios` (`nroa`);
COMMIT;

alter table departamento add 
constraint 
foreign key(fk_empregado_numero_seguro_social)
references empregado(numero_seguro_social);

#a)    A quantidade e média de idade para médicos, pacientes e funcionários (3 consultas).

select count(*) as quantidade, avg(idade) as media_idade from medicos;
select count(*) as quantidade, avg(idade) as media_idade from pacientes;
select count(*) as quantidade, avg(idade) as media_idade from funcionarios;



#b)    A média de capacidade dos ambulatórios

select avg(capacidade) as media_capacidade from ambulatorios;

#c)    A quantidade de consultas por paciente(codp)

select codp as paciente, count(*) as quantidade_consultas from consultas group by codp;

#d)    A quantidade de consultas por dia

select data, count(*) from consultas group by data;

#e)    A quantidade de consultas por médico(codm)

select codm, count(*) from consultas group by codm;

#f)    A quantidade de consultas por período (manhã, tarde)

select count(*) as manha from consultas where hora<="12:00";#manha

select count(*) as manha from consultas where hora>"12:00";#tarde

select hora>"12:00", hora<="12:00", count(*) from consultas group by hora>"12:00", hora<="12:00";
select periodo, count(*) from (
select case 
	when hora<="12:00" 
		then "manhã" 
        else "tarde" 
	end as periodo 
    from consultas
    ) consultas group by periodo;
    
select case when hora<="12:00" then 1 end as manha, 
		case when hora>"12:00" then 1 end as tarde, consultas.* from consultas;  

select count(case when hora<="12:00" then 1 end) as manha, 
		count(case when hora>"12:00" then 1 end) as tarde from consultas;


select nroa as ambulatorio, count(*) as quantidade_medicos from medicos group by nroa;


select sum(salario) as custo_mensal from funcionarios;




select andar, count(*) as quantidade from ambulatorios group by andar order by quantidade desc limit 1;

select andar, sum(capacidade) as quantidade from ambulatorios group by andar order by quantidade desc limit 1;




select * from funcionarios order by salario desc limit 3;



select * from consultas where data between "2022-02-02" and subdate(now(), 1) ;

select subdate(now(), 1) from dual;#ontem


select cidade, sum(salario) as soma_salario from funcionarios 
group by cidade 
order by soma_salario desc limit 1;


select nome, idade, cidade from medicos
union
select nome, idade, cidade from funcionarios;


select * from funcionarios where cidade in ("ibipora", "londrina");

select * from funcionarios where cidade = "cambe" or cidade = "londrina";

#o)    Funcionários que não são de londrina nem de cambé 

select * from funcionarios where cidade not in ("cambe", "londrina");

select * from funcionarios where cidade <> "cambe" and cidade <> "londrina";



select nome, idade, cidade from medicos
union all
select nome, idade, cidade from funcionarios;


select nome, idade, cidade, "medicos" as origem from medicos
union all
select nome, idade, cidade, "funcionarios" as origem from funcionarios;


select nome, idade, cidade, "medicos" as origem from medicos
union 
select nome, idade, cidade, "funcionarios" as origem from funcionarios;


select * from (
select nome, idade, cidade from medicos
intersect 
select nome, idade, cidade from funcionarios
) inter;

SELECT DISTINCT  nome, idade, cidade  FROM medicos  
INNER JOIN funcionarios USING(nome, idade, cidade); 
