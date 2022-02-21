-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 21, 2022 at 06:28 PM
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
(34, 'CRE1 001 2019', 'THE RELIGION', 'PST CEN SILVER', 'KLB', 'RELIGION', 'TEXT BOOK'),
(35, '2345', 'asdfghj', 'asdfghj', 'asdfghj', 'SCIENCE', 'asdfg'),
(36, '', '', '', '', 'ART', ''),
(37, 'CHEM1 001 2019', 'PRINCIPLE OF CHEM', 'ALRBERT AUSTIN', 'FUCOS ', 'SCIENCE', 'TEXT BOOK'),
(38, 'CHEM1 002 2019', 'PRINCIPLE OF CHEM', 'ALRBERT AUSTIN', 'FUCOS ', 'SCIENCE', 'TEXT BOOK'),
(39, 'CHEM1 330 2019', 'THE CHEMSTRY', 'CHARLE SAM', 'KLB', 'SCIENCE', 'TEXT BOOK'),
(40, 'BS2 003 2021', 'INVERTOR', 'JAMES MULSK', 'FOCUS', 'ART', 'FOR REVISION AND COURSE WORKER'),
(41, 'BS 232 2022', 'INVETOR', 'JOHN HEE', 'FOCUS', 'ART', 'COURCE WORK'),
(42, 'BS1 006 2020', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHERS', 'ART', 'ART'),
(43, '', '', '', '', 'ART', ''),
(44, 'GEO 200 2020', 'THE EARTH', 'CHARLSE JONES', 'FUCOS PRESS', 'ART', 'COURSE WORK');

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
(36, 8, 'HISTO1 003 2019', 'THE EVOLVING WORLD', 'HUMANITIES', 12, 1011, 'REGINA', 1, '2021-08-05 09:04:40', 'CHALSE DAWIN', 'KLB PUBLISHERS ', 'TEXT BOOK'),
(38, 27, 'HISTO 005 2020', 'THE EVOLVING WORLD', 'HUMANITIES', 21, 1019, 'MARY', 1, '2021-08-05 09:20:22', 'CHARLE DAWING', 'KLB PUBLISHER', 'TEXT BOOK'),
(39, 16, 'GEO1 007 2019', 'THE GALAXY', 'HUMANITIES', 12, 1011, 'REGINA', 1, '2021-08-05 09:20:54', 'LINET MBOYA', 'KLB PUBLISHER', 'TEXT BOOK'),
(40, 9, 'HISTO1 004 2019', 'THE EVOLVING WORLD', 'HUMANITIES', 15, 1013, 'MARY', 1, '2021-08-05 09:21:09', 'CHALSE DAWIN', 'KLB PUBLISHERS ', 'TEXT BOOK'),
(41, 24, 'HISTO 002 2020', 'THE EVOLVING WORLD', 'HUMANITIES', 14, 0, 'SKITAH', 0, '2021-08-05 09:24:26', 'CHARLE DAWING', 'KLB PUBLISHER', 'TEXT BOOK'),
(42, 28, 'HISTO 006 2020', 'THE EVOLVING WORLD', 'HUMANITIES', 15, 1013, 'MARY', 1, '2021-08-05 12:00:09', 'CHARLE DAWING', 'KLB PUBLISHER', 'TEXT BOOK'),
(46, 50, 'CRE1 001 2019', 'THE RELIGION', 'RELIGION', 10, 1009, 'PHYILS', 1, '2021-08-07 10:46:05', 'PST CEN SILVER', 'KLB', 'TEXT BOOK'),
(47, 0, '', '', '', 0, 0, '', 0, '2021-08-08 11:39:59', '', '', ''),
(50, 0, '', '', '', 0, 0, '', 0, '2021-08-12 13:18:29', '', '', ''),
(51, 56, 'CHEM1 001 2019', 'PRINCIPLE OF CHEM', 'SCIENCE', 23, 5063, 'MARY', 1, '2021-08-17 09:14:48', 'ALRBERT AUSTIN', 'FUCOS ', 'TEXT BOOK'),
(55, 60, 'CHEM1 330 2019', 'THE CHEMSTRY', 'SCIENCE', 11, 1010, 'AGNES', 1, '2021-10-13 16:09:23', 'CHARLE SAM', 'KLB', 'TEXT BOOK'),
(57, 19, 'GEO1 010 2019', 'THE GALAXY', 'HUMANITIES', 17, 1015, 'ANN', 1, '2021-11-03 17:06:24', 'LINET MBOYA', 'KLB PUBLISHER', 'TEXT BOOK'),
(58, 55, 'CHEM1 002 2019', 'PRINCIPLE OF CHEM', 'SCIENCE', 23, 5063, 'MARY', 1, '2022-02-18 07:55:44', 'ALRBERT AUSTIN', 'FUCOS ', 'TEXT BOOK');

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
(15, 'MARY', 'ANN', 'WANJIKU', 1, 1013),
(16, 'MARGRET', 'WAIRIMU', 'NJOROGE', 1, 1014),
(17, 'ANN', 'ROSS', 'WAMBUI', 1, 1015),
(18, 'JOAN', 'WAITHERERO', 'NJUGU', 1, 1016),
(19, 'JOAN', 'WANGUI', 'NDUKU', 1, 1017),
(20, 'ANNITAH', 'NJOKI', 'NDUGU', 1, 1018),
(21, 'MARY', 'WANJIKU', 'NJOROGE', 1, 1019),
(23, 'MARY', 'WEAMBUI', 'NJUGUNA', 1, 5063),
(24, 'TERESIA', 'WAMBOI', 'NJOROGE', 1, 1001),
(26, 'JANE', 'NGINA', 'WANJIKU', 2, 2001),
(27, 'JANE', 'WAIRIMU', 'NGENDA', 3, 3000);

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
(20, 'LEISURES');

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
(26, 'HISTO 004 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(29, 'HISTO 007 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(31, 'HISTO 009 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(33, 'HISTO 011 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(35, 'GEO1 009 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(39, 'HISTO 010 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(41, 'HISTO1 001 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(45, 'GEO1 003 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(46, 'HISTO 008 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(51, '2345', 'asdfghj', 'asdfghj', 'asdfghj', 'SCIENCE', 'asdfg'),
(52, '447252', 'MAN OF PEOPLE', 'NGUGI WA THIONGO', 'KLB', 'NOVEL', 'MAN OF PEOPLE YAAH'),
(53, '', '', '', '', 'ART', ''),
(58, 'GEO1 006 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(59, 'GEO1 008 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(61, 'HISTO 003 2020', 'THE EVOLVING WORLD', 'CHARLE DAWING', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(62, '', '', '', '', '', ''),
(63, 'GEO1 005 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(64, 'GEO1 004 2019', 'THE GALAXY', 'LINET MBOYA', 'KLB PUBLISHER', 'HUMANITIES', 'TEXT BOOK'),
(65, 'GEO1 004 2019', '', 'LINET MBOYA', 'KLB PUBLISHER', '', 'TEXT BOOK'),
(67, 'BS2 003 2021', 'INVERTOR', 'JAMES MULSK', 'FOCUS', 'ART', 'FOR REVISION AND COUR'),
(68, 'BS 232 2022', 'INVETOR', 'JOHN HEE', 'FOCUS', 'ART', 'COURCE WORK'),
(69, 'BS1 006 2020', 'THE INVENTORY', 'SK MBESHA', 'KLB PUBLISHERS', 'ART', 'ART'),
(70, '', '', '', '', 'ART', ''),
(73, 'GEO 200 2020', 'THE EARTH', 'CHARLSE JONES', 'FUCOS PRESS', 'ART', 'COURSE WORK');

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
(24, 22, 'MUTISYA', 'THE GALAXY', 'HUMANITIES', '2021-08-07 06:55:57'),
(25, 22, 'MUTISYA', 'MAN OF PEOPLE', 'NOVEL', '2021-08-10 15:57:30'),
(26, 23, 'MARY', 'PRINCIPLE OF CHEM', 'SCIENCE', '2021-08-12 13:17:28'),
(27, 13, 'CHARITY', 'THE GALAXY', 'HUMANITIES', '2021-08-17 09:23:31'),
(28, 23, 'MARY', 'THE GALAXY', 'HUMANITIES', '2021-08-23 08:26:40'),
(29, 14, 'SKITAH', 'THE GALAXY', 'HUMANITIES', '2021-08-24 19:22:33'),
(30, 16, 'MARGRET', 'THE EVOLVING WORLD', 'HUMANITIES', '2021-11-03 17:04:02'),
(31, 0, '', '', '', '2021-11-03 17:04:59'),
(32, 15, 'MARY', 'THE GALAXY', 'HUMANITIES', '2021-11-03 17:05:10'),
(33, 15, 'MARY', 'THE GALAXY', 'HUMANITIES', '2021-12-17 13:22:16'),
(34, 0, '', '', '', '2021-12-17 13:22:24'),
(35, 26, 'JANE', 'INVERTOR', 'ART', '2022-02-18 10:09:09'),
(36, 20, 'ANNITAH', 'THE EARTH', 'ART', '2022-02-21 16:50:50'),
(37, 21, 'MARY', 'THE EARTH', 'ART', '2022-02-21 17:00:59');

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

-- --------------------------------------------------------

--
-- Table structure for table `userdb`
--

CREATE TABLE `userdb` (
  `id` int(11) NOT NULL,
  `fname` text NOT NULL,
  `email` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
-- Indexes for table `userdb`
--
ALTER TABLE `userdb`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `bookid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `borrowedbook`
--
ALTER TABLE `borrowedbook`
  MODIFY `borrowid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=62;

--
-- AUTO_INCREMENT for table `borrowers`
--
ALTER TABLE `borrowers`
  MODIFY `borrowerid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `categoryid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `listofbook`
--
ALTER TABLE `listofbook`
  MODIFY `listid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

--
-- AUTO_INCREMENT for table `returntable`
--
ALTER TABLE `returntable`
  MODIFY `returnid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `userdb`
--
ALTER TABLE `userdb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
