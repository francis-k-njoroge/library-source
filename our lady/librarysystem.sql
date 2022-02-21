-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2021 at 03:00 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarysystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `bookid` int(11) NOT NULL,
  `bookno` varchar(15) NOT NULL,
  `booktitle` varchar(20) NOT NULL,
  `bookauthour` varchar(21) NOT NULL,
  `publisher` varchar(20) NOT NULL,
  `categoryname` varchar(20) NOT NULL,
  `description` varchar(70) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`bookid`, `bookno`, `booktitle`, `bookauthour`, `publisher`, `categoryname`, `description`) VALUES
(1, 'BS1 001 2019', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHER', 'ART', 'TEXT BOOK'),
(2, 'BS1 002 2019', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHER', 'ART', 'TEXT BOOK'),
(3, 'BS1 003 2019', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHER', 'ART', 'TEXT BOOK'),
(4, 'BS1 003 2019', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHER', 'ART', 'TEXT BOOK'),
(5, 'BS1 005 2019', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHER', 'ART', 'TEXT BOOK'),
(6, 'BS1 006 2020', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHERS', 'ART', 'TEXT BOOK'),
(7, 'BS1 007 2020', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHERS', 'ART', 'TEXT BOOK'),
(8, 'BS1 008 2020', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHERS', 'ART', 'TEXT BOOK'),
(9, 'BS1 009 2020', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHERS', 'ART', 'TEXT BOOK'),
(10, 'BS1 010 2020', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHERS', 'ART', 'TEXT BOOK'),
(11, 'HISTO1 001 2019', 'THE EVOLVING WORLD', 'CHALSE DAWIN', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(12, 'HISTO1 002 2019', 'THE EVELVING WORD', 'CHARLSE DAWIN', 'KLB PUBLISHER ', 'HUMANITIES', 'TEXT BOOK'),
(13, 'GEO1 001 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHERS', 'HUMANITIES', 'TEXT BOOK'),
(14, 'GEO1 003 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(15, 'GEO1 004 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(16, 'GEO1 005 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(17, 'GEO1 006 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(18, 'GEO1 007 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(19, 'GEO1 008 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(20, 'GEO1 009 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(21, 'GEO1 010 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(22, 'HISTO1 001 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(23, 'HISTO 002 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(24, 'HISTO 003 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(25, 'HISTO 004 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(26, 'HISTO 005 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(27, 'HISTO 006 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(28, 'HISTO 007 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(29, 'HISTO 008 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(30, 'HISTO 009 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(31, 'HISTO 010 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(32, 'HISTO 011 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(33, '447252', 'MAN OF PEOPLE', 'NGUGI WA THIONGO', 'KLB', 'NOVEL', 'MAN OF PEOPLE YAAH'),
(34, 'CRE1 001 2019', 'THE RELIGION', 'PST CEN SILVER', 'KLB', 'RELIGION', 'TEXT BOOK');

-- --------------------------------------------------------

--
-- Table structure for table `borrowedbook`
--

CREATE TABLE `borrowedbook` (
  `borrowid` int(6) NOT NULL,
  `bookid` int(5) NOT NULL,
  `bookno` varchar(15) NOT NULL,
  `booktitle` varchar(20) NOT NULL,
  `categoryname` varchar(21) NOT NULL,
  `borrowerid` int(11) NOT NULL,
  `adminno` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `form` int(2) NOT NULL,
  `borrowdate` timestamp NOT NULL DEFAULT current_timestamp(),
  `bookauthor` varchar(21) NOT NULL,
  `publisher` varchar(21) NOT NULL,
  `description` varchar(21) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `borrowedbook`
--

INSERT INTO `borrowedbook` (`borrowid`, `bookid`, `bookno`, `booktitle`, `categoryname`, `borrowerid`, `adminno`, `name`, `form`, `borrowdate`, `bookauthor`, `publisher`, `description`) VALUES
(35, 42, 'GEO1 005 2019', 'THE GALAXY', 'HUMANITIES', 15, 1013, 'MARY', 1, '2021-08-05 09:03:49', 'LINET MBOYA', 'KLB PUBLISHER', 'TEXT BOOK'),
(36, 8, 'HISTO1 003 2019', 'THE EVOLVING WORLD', 'HUMANITIES', 12, 1011, 'REGINA', 1, '2021-08-05 09:04:40', 'CHALSE DAWIN', 'KLB PUBLISHERS ', 'TEXT BOOK'),
(37, 13, 'GEO1 004 2019', 'THE GALAXY', 'HUMANITIES', 15, 1013, 'MARY', 1, '2021-08-05 09:05:28', 'LINET MBOYA', 'KLB PUBLISHER', 'TEXT BOOK'),
(38, 27, 'HISTO 005 2020', 'THE EVOLVING WORLD', 'HUMANITIES', 21, 1019, 'MARY', 1, '2021-08-05 09:20:22', 'CHARLE DAWING', 'KLB PUBLISHER', 'TEXT BOOK'),
(39, 16, 'GEO1 007 2019', 'THE GALAXY', 'HUMANITIES', 12, 1011, 'REGINA', 1, '2021-08-05 09:20:54', 'LINET MBOYA', 'KLB PUBLISHER', 'TEXT BOOK'),
(40, 9, 'HISTO1 004 2019', 'THE EVOLVING WORLD', 'HUMANITIES', 15, 1013, 'MARY', 1, '2021-08-05 09:21:09', 'CHALSE DAWIN', 'KLB PUBLISHERS ', 'TEXT BOOK'),
(41, 24, 'HISTO 002 2020', 'THE EVOLVING WORLD', 'HUMANITIES', 14, 0, 'SKITAH', 0, '2021-08-05 09:24:26', 'CHARLE DAWING', 'KLB PUBLISHER', 'TEXT BOOK'),
(42, 28, 'HISTO 006 2020', 'THE EVOLVING WORLD', 'HUMANITIES', 15, 1013, 'MARY', 1, '2021-08-05 12:00:09', 'CHARLE DAWING', 'KLB PUBLISHER', 'TEXT BOOK'),
(46, 50, 'CRE1 001 2019', 'THE RELIGION', 'RELIGION', 10, 1009, 'PHYILS', 1, '2021-08-07 10:46:05', 'PST CEN SILVER', 'KLB', 'TEXT BOOK');

-- --------------------------------------------------------

--
-- Table structure for table `borrowers`
--

CREATE TABLE `borrowers` (
  `borrowerid` int(11) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `middlename` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `form` int(6) NOT NULL,
  `adminno` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `borrowers`
--

INSERT INTO `borrowers` (`borrowerid`, `firstname`, `middlename`, `lastname`, `form`, `adminno`) VALUES
(2, 'JANE', 'NJOKI', 'GITAU', 1, 1002),
(3, 'MILKA', 'NJAMBI', 'KAMAU', 1, 1002),
(4, 'MARY', 'MOTHONI', 'WACHEKE', 1, 1003),
(5, 'JOAN', 'ACHIENG', 'ONEKO', 1, 1004),
(6, 'JENCINTA', 'WANJA', 'NZIUKO', 1, 1005),
(7, 'JANE', 'WAMAITHA', 'NJOROGE', 1, 1006),
(8, 'JANE', 'WANGARI', 'NJOGU', 1, 1007),
(9, 'SHAREEN', 'KALEKYE', 'MULWA', 1, 1008),
(10, 'PHYILS', 'BOSIBORI', 'TOO', 1, 1009),
(11, 'AGNES', 'JEPTOO', 'SANG', 1, 1010),
(12, 'REGINA', 'AKUDAI', 'LUKUMBA', 1, 1011),
(13, 'CHARITY', 'MARYANN', 'JOHN', 1, 1012),
(14, 'SKITAH', 'NJERI', 'TOO', 0, 0),
(15, 'MARY', 'ANN', 'WANJIKU', 1, 1013),
(16, 'MARGRET', 'WAIRIMU', 'NJOROGE', 1, 1014),
(17, 'ANN', 'ROSS', 'WAMBUI', 1, 1015),
(18, 'JOAN', 'WAITHERERO', 'NJUGU', 1, 1016),
(19, 'JOAN', 'WANGUI', 'NDUKU', 1, 1017),
(20, 'ANNITAH', 'NJOKI', 'NDUGU', 1, 1018),
(21, 'MARY', 'WANJIKU', 'NJOROGE', 1, 1019),
(22, 'MUTISYA', 'MUTISYA', 'MUTISYA', 6, 4231);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `categoryid` int(11) NOT NULL,
  `categoryname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`categoryid`, `categoryname`) VALUES
(1, 'SCIENCE'),
(2, 'HUMANITIES'),
(3, 'ART'),
(4, 'RELIGION'),
(5, 'LITREATURE'),
(6, 'SWAHILI'),
(7, 'NOVEL'),
(8, 'STORY BOOK'),
(9, 'FICTION'),
(10, 'LEISURE'),
(12, 'NEWS PAPER'),
(13, 'GENERAL');

-- --------------------------------------------------------

--
-- Table structure for table `hh`
--

CREATE TABLE `hh` (
  `2` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `listofbook`
--

CREATE TABLE `listofbook` (
  `listid` int(11) NOT NULL,
  `bookno` varchar(20) NOT NULL,
  `booktitle` varchar(20) NOT NULL,
  `bookauthor` varchar(21) NOT NULL,
  `publisher` varchar(20) NOT NULL,
  `categoryname` varchar(20) NOT NULL,
  `description` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `listofbook`
--

INSERT INTO `listofbook` (`listid`, `bookno`, `booktitle`, `bookauthor`, `publisher`, `categoryname`, `description`) VALUES
(19, 'GEO1 010 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(25, 'HISTO 003 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(26, 'HISTO 004 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(29, 'HISTO 007 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(31, 'HISTO 009 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(33, 'HISTO 011 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(35, 'GEO1 009 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(39, 'HISTO 010 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(41, 'HISTO1 001 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(43, 'GEO1 006 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(45, 'GEO1 003 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(46, 'HISTO 008 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(48, '447252', 'MAN OF PEOPLE', 'NGUGI WA THIONGO', 'KLB', 'NOVEL', 'MAN OF PEOPLE YAAH'),
(49, 'GEO1 008 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK');

-- --------------------------------------------------------

--
-- Table structure for table `returntable`
--

CREATE TABLE `returntable` (
  `returnid` int(6) NOT NULL,
  `borrowerid` int(6) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `booktitle` varchar(20) NOT NULL,
  `categoryname` varchar(20) NOT NULL,
  `returntime` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `returntable`
--

INSERT INTO `returntable` (`returnid`, `borrowerid`, `firstname`, `booktitle`, `categoryname`, `returntime`) VALUES
(4, 3, 'MILKA', 'THE INVENTORY', 'ART', '2021-08-03 19:29:49'),
(5, 4, 'MARY', 'THE INVENTORY', 'ART', '2021-08-03 19:33:12'),
(8, 12, 'REGINA', 'THE EVOLVING WORLD', 'HUMANITIES', '2021-08-04 15:28:13'),
(9, 3, 'MILKA', 'THE EVELVING WORD', 'HUMANITIES', '2021-08-04 15:46:53'),
(10, 10, 'PHYILS', 'THE INVENTORY', 'ART', '2021-08-04 18:40:36'),
(11, 15, 'MARY', 'THE GALAXY', 'HUMANITIES', '2021-08-04 18:48:56'),
(12, 0, '', '', '', '2021-08-05 06:33:12'),
(13, 0, '', '', '', '2021-08-05 06:33:19'),
(14, 0, '', '', '', '2021-08-05 06:33:25'),
(15, 12, 'REGINA', 'THE EVOLVING WORLD', 'HUMANITIES', '2021-08-05 06:39:20'),
(16, 0, '', '', '', '2021-08-05 06:39:33'),
(17, 12, 'REGINA', 'THE EVOLVING WORLD', 'HUMANITIES', '2021-08-05 06:50:53'),
(18, 6, 'JENCINTA', 'THE GALAXY', 'HUMANITIES', '2021-08-05 08:55:20'),
(19, 12, 'REGINA', 'THE GALAXY', 'HUMANITIES', '2021-08-05 09:08:16'),
(20, 15, 'MARY', 'THE GALAXY', 'HUMANITIES', '2021-08-05 09:12:44'),
(21, 9, 'SHAREEN', 'THE GALAXY', 'HUMANITIES', '2021-08-05 12:00:45'),
(22, 13, 'CHARITY', 'THE EVOLVING WORLD', 'HUMANITIES', '2021-08-05 12:39:51'),
(23, 22, 'MUTISYA', 'MAN OF PEOPLE', 'NOVEL', '2021-08-05 13:11:49'),
(24, 22, 'MUTISYA', 'THE GALAXY', 'HUMANITIES', '2021-08-07 06:55:57');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userid` int(11) NOT NULL,
  `username` varchar(21) NOT NULL,
  `firstname` varchar(21) NOT NULL,
  `lastname` varchar(21) NOT NULL,
  `password` varchar(21) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userid`, `username`, `firstname`, `lastname`, `password`) VALUES
(1, 'amoh', 'amoh', 'amoh', 'amoh'),
(2, 'francis', 'francis', 'njoroge', '2021'),
(3, 'john', 'john', 'ndugu', 'john'),
(4, 'gid', 'gid', 'gid', 'gid');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`bookid`);

--
-- Indexes for table `borrowedbook`
--
ALTER TABLE `borrowedbook`
  ADD PRIMARY KEY (`borrowid`);

--
-- Indexes for table `borrowers`
--
ALTER TABLE `borrowers`
  ADD PRIMARY KEY (`borrowerid`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`categoryid`);

--
-- Indexes for table `listofbook`
--
ALTER TABLE `listofbook`
  ADD PRIMARY KEY (`listid`);

--
-- Indexes for table `returntable`
--
ALTER TABLE `returntable`
  ADD PRIMARY KEY (`returnid`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `bookid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `borrowedbook`
--
ALTER TABLE `borrowedbook`
  MODIFY `borrowid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `borrowers`
--
ALTER TABLE `borrowers`
  MODIFY `borrowerid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `categoryid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `listofbook`
--
ALTER TABLE `listofbook`
  MODIFY `listid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `returntable`
--
ALTER TABLE `returntable`
  MODIFY `returnid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
