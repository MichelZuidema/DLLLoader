-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql7.freemysqlhosting.net
-- Generation Time: Jun 21, 2018 at 03:07 PM
-- Server version: 5.5.58-0ubuntu0.14.04.1
-- PHP Version: 7.0.30-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql7243537`
--

-- --------------------------------------------------------

--
-- Table structure for table `loader`
--

CREATE TABLE `loader` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `HWID` varchar(255) DEFAULT NULL,
  `active_subscription` enum('TRUE','FALSE') DEFAULT 'FALSE'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `loader`
--

INSERT INTO `loader` (`id`, `name`, `HWID`, `active_subscription`) VALUES
(1, 'Enter your username here.', 'Enter your HWID here.', 'TRUE');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
