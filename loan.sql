-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2017 at 07:42 AM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loan`
--

-- --------------------------------------------------------

--
-- Table structure for table `app_a`
--

CREATE TABLE `app_a` (
  `SNID` int(11) NOT NULL,
  `fullName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `age` int(11) NOT NULL,
  `NID` varchar(255) NOT NULL,
  `profession` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `fatherName` varchar(255) NOT NULL,
  `motherName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `app_a`
--

INSERT INTO `app_a` (`SNID`, `fullName`, `email`, `address`, `age`, `NID`, `profession`, `phone`, `fatherName`, `motherName`) VALUES
(92256, 'xcvb', 'cxvb', 'xcvbcxv', 0, 'cxvb', 'cxb', 'cxvb', 'bvc', 'bxvb');

-- --------------------------------------------------------

--
-- Table structure for table `app_b`
--

CREATE TABLE `app_b` (
  `SNID` int(11) NOT NULL,
  `disName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `license` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ifi_user`
--

CREATE TABLE `ifi_user` (
  `ID` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ifi_user`
--

INSERT INTO `ifi_user` (`ID`, `email`, `password`) VALUES
(1, 'ifi1', '1234'),
(2, 'ifi2', '12345'),
(3, 'anikamin', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `sreda_app_a`
--

CREATE TABLE `sreda_app_a` (
  `SNID` int(11) NOT NULL,
  `fullName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `age` int(11) NOT NULL,
  `NID` varchar(255) NOT NULL,
  `profession` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `fatherName` varchar(255) NOT NULL,
  `motherName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sreda_app_b`
--

CREATE TABLE `sreda_app_b` (
  `SNID` int(11) NOT NULL,
  `disName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `license` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sreda_selecteda`
--

CREATE TABLE `sreda_selecteda` (
  `SNID` int(11) NOT NULL,
  `fullName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `age` int(11) NOT NULL,
  `NID` varchar(255) NOT NULL,
  `profession` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `fatherName` varchar(255) NOT NULL,
  `motherName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sreda_selecteda`
--

INSERT INTO `sreda_selecteda` (`SNID`, `fullName`, `email`, `address`, `age`, `NID`, `profession`, `phone`, `fatherName`, `motherName`) VALUES
(92244, 'anik', 'email@someone', 'dfgds', 663, '752852', 'dgvd', 'dfgsdg', 'dgdg', 'dgdg'),
(92245, 'touhid', 'sasdcds', 'savas', 0, 'sdcvas', 'sacvsa', 'sdvsa', 'asdvassa', 'sadvsav'),
(92249, 'anik amin', 'anikamin.info@gmail.com', 'bashundhara ra', 25, '884454848', 'student', '00054', 'ruhul amin', 'tuhin'),
(92250, 'xcvxzv', 'xvxzv', 'xcvzv', 0, 'xcvxzv', 'xzv', 'xzvzx', 'dsv', 'fdvdfv'),
(92252, 'dfhdf', 'sdgsd', 'bdfb', 0, 'dfv', 'sfgvsd', 'sdv', 'sdfvfddfdn', 'nfgnd');

-- --------------------------------------------------------

--
-- Table structure for table `sreda_selectedb`
--

CREATE TABLE `sreda_selectedb` (
  `SNID` int(11) NOT NULL,
  `disName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `license` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sreda_selectedb`
--

INSERT INTO `sreda_selectedb` (`SNID`, `disName`, `email`, `phone`, `address`, `license`) VALUES
(92579, 'd', 'fdhsd', 'hdhdsh', 'hsdh', 'dsh');

-- --------------------------------------------------------

--
-- Table structure for table `sreda_user`
--

CREATE TABLE `sreda_user` (
  `ID` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `pass` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sreda_user`
--

INSERT INTO `sreda_user` (`ID`, `email`, `pass`) VALUES
(1, 'sreda1', '1234'),
(2, 'sreda2', '12345'),
(3, 'sreda3', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `temp_app_a`
--

CREATE TABLE `temp_app_a` (
  `ID` int(11) NOT NULL,
  `SNID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `app_a`
--
ALTER TABLE `app_a`
  ADD PRIMARY KEY (`SNID`);

--
-- Indexes for table `app_b`
--
ALTER TABLE `app_b`
  ADD PRIMARY KEY (`SNID`);

--
-- Indexes for table `ifi_user`
--
ALTER TABLE `ifi_user`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `sreda_app_a`
--
ALTER TABLE `sreda_app_a`
  ADD PRIMARY KEY (`SNID`);

--
-- Indexes for table `sreda_app_b`
--
ALTER TABLE `sreda_app_b`
  ADD PRIMARY KEY (`SNID`);

--
-- Indexes for table `sreda_selecteda`
--
ALTER TABLE `sreda_selecteda`
  ADD PRIMARY KEY (`SNID`);

--
-- Indexes for table `sreda_selectedb`
--
ALTER TABLE `sreda_selectedb`
  ADD PRIMARY KEY (`SNID`);

--
-- Indexes for table `sreda_user`
--
ALTER TABLE `sreda_user`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `temp_app_a`
--
ALTER TABLE `temp_app_a`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `SNID` (`SNID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `app_a`
--
ALTER TABLE `app_a`
  MODIFY `SNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92257;

--
-- AUTO_INCREMENT for table `app_b`
--
ALTER TABLE `app_b`
  MODIFY `SNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92580;

--
-- AUTO_INCREMENT for table `ifi_user`
--
ALTER TABLE `ifi_user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `sreda_app_b`
--
ALTER TABLE `sreda_app_b`
  MODIFY `SNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92580;

--
-- AUTO_INCREMENT for table `sreda_selectedb`
--
ALTER TABLE `sreda_selectedb`
  MODIFY `SNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92580;

--
-- AUTO_INCREMENT for table `sreda_user`
--
ALTER TABLE `sreda_user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `temp_app_a`
--
ALTER TABLE `temp_app_a`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
