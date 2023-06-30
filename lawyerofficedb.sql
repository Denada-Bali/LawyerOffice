-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 18, 2023 at 08:06 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lawyerofficedb`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetCases` ()   BEGIN
    SELECT * FROM cases;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetClients` ()   BEGIN
    SELECT * FROM client;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLawyers` ()   BEGIN
    SELECT * FROM lawyer;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getLawyersWithMaxThreeActiveClients` ()   BEGIN
    SELECT L.lawyerId, L.name
    FROM lawyer L
    LEFT JOIN (
        SELECT lawyerId, COUNT(*) AS activeClientCount
        FROM cases
        WHERE statusCase = 'active'
        GROUP BY lawyerId
    ) C ON L.lawyerId = C.lawyerId
    WHERE C.activeClientCount IS NULL OR C.activeClientCount <= 3;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `cases`
--

CREATE TABLE `cases` (
  `CaseId` int(11) NOT NULL,
  `lawyerId` int(11) NOT NULL,
  `clientId` int(11) NOT NULL,
  `startDate` date NOT NULL,
  `statusCase` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cases`
--

INSERT INTO `cases` (`CaseId`, `lawyerId`, `clientId`, `startDate`, `statusCase`) VALUES
(1, 2, 1, '2023-05-18', 'Pending '),
(2, 1, 3, '2023-05-18', 'Pending '),
(5, 7, 18, '2021-02-21', 'Close'),
(6, 4, 17, '2023-01-12', 'Pending '),
(7, 2, 8, '2020-12-28', 'Close'),
(8, 6, 9, '2023-04-06', 'Active '),
(14, 10, 21, '2023-04-18', 'Pending '),
(17, 1, 16, '2019-06-29', 'Close'),
(19, 1, 15, '2023-05-15', 'Pending '),
(21, 11, 26, '2023-05-20', 'Pending '),
(24, 4, 21, '2019-07-04', 'Close'),
(27, 1, 3, '2023-06-17', 'Active '),
(28, 1, 3, '2023-06-18', 'Pending '),
(29, 10, 37, '2023-06-18', 'Close'),
(31, 6, 36, '2023-06-18', 'Active '),
(32, 6, 33, '2023-06-18', 'Active '),
(33, 6, 3, '2023-06-18', 'Active ');

--
-- Triggers `cases`
--
DELIMITER $$
CREATE TRIGGER `after_delete_backup_cases` AFTER DELETE ON `cases` FOR EACH ROW INSERT IGNORE INTO cases_backup (id, lawyerId, clientId, startDate, statusCase)
    VALUES (OLD.CaseId, OLD.lawyerId, OLD.clientId, OLD.startDate, OLD.statusCase)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_insert_backup_cases` AFTER INSERT ON `cases` FOR EACH ROW INSERT INTO cases_backup (id, lawyerId, clientId, startDate, statusCase)
    VALUES (NEW.CaseId, NEW.lawyerId, NEW.clientId, NEW.startDate, NEW.statusCase)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_update_backup_cases` AFTER UPDATE ON `cases` FOR EACH ROW INSERT INTO cases_backup (id, lawyerId, clientId, startDate, statusCase)
    VALUES (NEW.CaseId, NEW.lawyerId, NEW.clientId, NEW.startDate, NEW.statusCase)
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `cases_backup`
--

CREATE TABLE `cases_backup` (
  `casebackupid` int(11) NOT NULL,
  `id` int(11) NOT NULL,
  `lawyerId` int(11) NOT NULL,
  `clientId` int(11) NOT NULL,
  `startDate` date NOT NULL,
  `statusCase` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cases_backup`
--

INSERT INTO `cases_backup` (`casebackupid`, `id`, `lawyerId`, `clientId`, `startDate`, `statusCase`) VALUES
(1, 0, 0, 0, '2023-05-18', 'Pending '),
(2, 0, 0, 0, '2023-04-18', 'Pending '),
(3, 0, 0, 0, '2019-06-12', 'Close'),
(4, 0, 0, 0, '2019-06-29', 'Close'),
(5, 0, 0, 0, '2023-05-20', 'Active '),
(6, 0, 0, 0, '2023-05-15', 'Pending '),
(7, 20, 11, 26, '2023-05-20', 'Pending '),
(8, 20, 11, 26, '2023-05-20', 'Active '),
(9, 20, 11, 26, '2023-05-20', 'Active '),
(10, 21, 11, 26, '2023-05-20', 'Pending '),
(11, 22, 10, 28, '2023-05-22', 'Pending '),
(12, 22, 10, 28, '2023-05-22', 'Active '),
(13, 22, 10, 28, '2023-05-22', 'Active '),
(14, 23, 10, 30, '2023-05-24', 'Active '),
(15, 23, 10, 30, '2023-05-24', 'Close'),
(16, 23, 10, 30, '2023-05-24', 'Close'),
(17, 24, 4, 21, '2019-07-04', 'Close'),
(18, 25, 11, 36, '2023-06-06', 'Active '),
(19, 25, 11, 36, '2023-06-06', 'Pending '),
(20, 25, 11, 36, '2023-06-06', 'Pending '),
(21, 26, 1, 3, '0000-00-00', 'Active'),
(22, 26, 1, 3, '0000-00-00', 'Active'),
(23, 27, 1, 3, '2023-06-17', 'Active '),
(24, 28, 1, 3, '2023-06-18', 'Pending '),
(25, 29, 10, 37, '2023-06-18', 'Close'),
(26, 30, 2, 41, '2018-10-18', 'Close'),
(27, 30, 2, 41, '2018-10-18', 'Active '),
(28, 30, 2, 41, '2018-10-18', 'Active '),
(29, 31, 6, 36, '2023-06-18', 'Active '),
(30, 32, 6, 33, '2023-06-18', 'Active '),
(31, 33, 6, 3, '2023-06-18', 'Active ');

-- --------------------------------------------------------

--
-- Stand-in structure for view `caseview`
-- (See below for the actual view)
--
CREATE TABLE `caseview` (
`LawyerName` varchar(60)
,`ClientName` varchar(60)
);

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `clientId` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `surname` varchar(60) NOT NULL,
  `address` varchar(100) NOT NULL,
  `phoneNumber` varchar(13) NOT NULL,
  `email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`clientId`, `name`, `surname`, `address`, `phoneNumber`, `email`) VALUES
(1, 'Denalda', 'Bali', 'Elbasan', '111000222', 'denaldabali@gmail.com'),
(3, 'Dne', 'Bal', 'Tirane', '444000555', 'd@gmail.com'),
(8, 'Jane', 'Gray', 'New York', '1002000', 'Jane.gray@outlook.edu.al'),
(9, 'Brown', 'Carpet', 'Manhattan', '1200455', 'b.c@outlook.com'),
(15, 'Miley ', 'Cyrus', 'Los Angeles ', '99988333', 'mileycyrus@gmail.com'),
(16, 'Lana Del ', 'Rey', 'California', '10002228', 'lanadlrey@something.com'),
(17, 'Rahul', 'Gray', 'New York', '77788866', 'rahulg@outlook.com'),
(18, 'Nadia ', 'Gray', 'New York', '66888777', 'nadiag@outlook.com'),
(19, 'Elon', 'Musk', 'California', '665544', 'musk@something.com'),
(21, 'Tom', 'Cruise', 'Texas', '44433355', 'tom.cruise@gmail.com'),
(26, 'Tom', 'Smith', 'Alaska', '5554444666', 'tm@smith.com'),
(28, 'Dea ', 'Senka', 'Tirane', '44555445', 'd.senka@gmail.com'),
(29, 'Mayci', 'Nelay', 'Tirane', '77788886', 'maycin@gmail.com'),
(30, 'Jacob', 'Nelay', 'USA', '6666555544', 'j.n@something.com'),
(32, 'Tom', 'Cruise', 'Texas', '44433355', 'tom.cruise@gmail.com'),
(33, 'Miley ', 'Cyrus', 'Los Angeles ', '99988333', 'mileycyrus@gmail.com'),
(34, 'Lana Del ', 'Rey', 'California', '10002228', 'lanadlrey@somthing.com'),
(35, 'Rahul', 'Gray', 'New York', '77788866', 'rahulg@outlook.com'),
(36, 'Nadia ', 'Gray', 'New York', '66888777', 'nadiag@outlook.com'),
(37, 'Anne', 'Frank', 'frankfurt', '66665554', 'f@gmail.com'),
(44, 'ts', 'se', 'es', '434343', 'es');

--
-- Triggers `client`
--
DELIMITER $$
CREATE TRIGGER `after_delete_backup` AFTER DELETE ON `client` FOR EACH ROW INSERT INTO client_backup (Id, name, surname, address, phoneNumber, email)
    VALUES (OLD.clientId, OLD.name, OLD.surname, OLD.address, OLD.phoneNumber, OLD.email)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_insert_backup` AFTER INSERT ON `client` FOR EACH ROW INSERT INTO client_backup (Id, name, surname, address, phoneNumber, email)
    VALUES (NEW.clientId, NEW.name, NEW.surname, NEW.address, NEW.phonenumber, NEW.email)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_update_backup` AFTER UPDATE ON `client` FOR EACH ROW INSERT INTO client_backup (Id, name, surname, address, phoneNumber, email)
    VALUES (NEW.clientId, NEW.name, NEW.surname, NEW.address, NEW.phonenumber, NEW.email)
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `client_backup`
--

CREATE TABLE `client_backup` (
  `clientbackupId` int(11) NOT NULL,
  `id` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `surname` varchar(60) NOT NULL,
  `address` varchar(100) NOT NULL,
  `phoneNumber` int(13) NOT NULL,
  `email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `client_backup`
--

INSERT INTO `client_backup` (`clientbackupId`, `id`, `name`, `surname`, `address`, `phoneNumber`, `email`) VALUES
(1, 0, 'Robert ', 'Downey', 'New York', 888844443, 'r.downey@something.com'),
(2, 0, 'Elizabeth', 'Taylor', 'Texas', 776665554, 't@something.com'),
(3, 0, 'Dne', 'Bal', 'Tirane', 444000555, 'd@gmail.com'),
(4, 0, 'Lana Del ', 'Rey', 'California', 10002228, 'lanadlrey@something.com'),
(5, 0, 'Elon', 'Musk', 'California', 665544, 'musk@something.com'),
(6, 0, 'Robert ', 'Downey', 'New York', 888844443, 'r.downey@something.com'),
(7, 0, 'Elizabeth', 'Taylor', 'Texas', 776665554, 't@something.com'),
(8, 0, 'tom ', 'smith', 'Alaska', 55544466, 'tm@something'),
(9, 25, 'Tom', 'Smith', 'Alaska', 55544466, 'tm@something'),
(10, 25, 'Tom', 'Smith', 'Alaska', 55544466, 'tm@something'),
(11, 0, 'Tom', 'Smith', 'Alaska', 2147483647, 'tm@smith.com'),
(12, 0, 'test001', 'test', 'Tirane', 666777888, 'test@gmail.com'),
(13, 27, 'Dea', 'Senka', 'Tirane', 666777888, 'd@gmail,com'),
(14, 27, 'Dea', 'Senka', 'Tirane', 666777888, 'd@gmail,com'),
(15, 0, 'Dea ', 'Senka', 'Tirane', 44555445, 'd.senka@gmail.com'),
(16, 0, 'Mayci', 'Nelay', 'Tirane', 77788886, 'maycin@gmail.com'),
(17, 30, 'jacob', 'Nelay', 'USa', 545454545, 'jn@something.com'),
(18, 30, 'Jacob', 'Nelay', 'USA', 2147483647, 'j.n@something.com'),
(19, 31, 'test', 'test', 'tirane', 444444555, 'test@gmail.com'),
(20, 31, 'Bela', 'B', 'Tirane', 444444555, 'test@gmail.com'),
(21, 31, 'Bela', 'B', 'Tirane', 444444555, 'test@gmail.com'),
(22, 32, 'Tom', 'Cruise', 'Texas', 44433355, 'tom.cruise@gmail.com'),
(23, 33, 'Miley ', 'Cyrus', 'Los Angeles ', 99988333, 'mileycyrus@gmail.com'),
(24, 34, 'Lana Del ', 'Rey', 'California', 10002228, 'lanadlrey@somthing.com'),
(25, 35, 'Rahul', 'Gray', 'New York', 77788866, 'rahulg@outlook.com'),
(26, 36, 'Nadia ', 'Gray', 'New York', 66888777, 'nadiag@outlook.com'),
(27, 37, 'Anne', 'Frank', 'frankfurt', 66665554, 'f@gmail.com'),
(28, 38, 'Mike', 'Cyrus', 'Los Angles', 666677777, 'm@something.com'),
(29, 38, 'Mic', 'Cyrus', 'Los Angles', 0, 'm@something.com'),
(30, 38, 'Mic', 'Cyrus', 'Los Angles', 0, 'm@something.com'),
(31, 39, 'Nala', 'B', 'Tirn', 545454, 'nal@gmail.com'),
(32, 39, 'Nala', 'B', 'Tirn', 545454, 'nal@gmail.com'),
(33, 40, 'test001', 'tst', 'tiran', 77777, 't@gmai.com'),
(34, 40, 'test001', 'tst', 'tiran', 77777, 't@gmai.com'),
(35, 40, 'test00', 'test', 'tiran', 77777, 't@gmai.com'),
(36, 40, 'test00', 'test', 'tiran', 77777, 't@gmai.com'),
(37, 41, 'test', 'test', 'Tirane', 7777777, 'test@gmail.com'),
(38, 41, 'testi', 'est', 'Tirane', 7777777, 'test@gmail.com'),
(39, 41, 'testi', 'est', 'Tirane', 7777777, 'test@gmail.com'),
(40, 42, 'test', 'test', 'Turane', 4444, 'te@gmail.com'),
(41, 42, 'test', 'test', 'Turane', 4444, 'te@gmail.com'),
(42, 43, 'test', 'ese', 'TEtd', 44444, 'e@fnf.xom'),
(43, 43, 'test', 'ese', 'TEtd', 44444, 'e@fnf.xom'),
(44, 44, 'ts', 'se', 'es', 434343, 'es');

-- --------------------------------------------------------

--
-- Table structure for table `lawyer`
--

CREATE TABLE `lawyer` (
  `lawyerId` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `surname` varchar(60) NOT NULL,
  `specialization` varchar(100) NOT NULL,
  `salary` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lawyer`
--

INSERT INTO `lawyer` (`lawyerId`, `name`, `surname`, `specialization`, `salary`) VALUES
(1, 'Mickey', 'Cat', 'Criminal Law', 2000),
(2, 'Capo', 'Cat', 'Health Care Law', 2000),
(4, 'Jane', 'Doe', 'Environmental Law', 2100),
(6, 'John', 'Doe', 'First Amendment Law', 3100),
(7, 'Mary Jane', 'Watson', 'Constitutional Law', 3200),
(10, 'Emma', 'Watson', 'Environmental Law', 4300),
(11, 'Meghan', 'Markle', 'First Amendment Law', 3500);

--
-- Triggers `lawyer`
--
DELIMITER $$
CREATE TRIGGER `after_delete_backup_lawyer` AFTER DELETE ON `lawyer` FOR EACH ROW INSERT IGNORE INTO lawyer_backup (id, name, surname, specialization, salary)
    VALUES (OLD.lawyerId, OLD.name, OLD.surname, OLD.specialization, OLD.salary)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_insert_backup_lawyer` AFTER INSERT ON `lawyer` FOR EACH ROW INSERT INTO lawyer_backup (id, name, surname, specialization, salary)
    VALUES (NEW.lawyerId, NEW.name, NEW.surname, NEW.specialization, NEW.salary)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_update_backup_lawyer` AFTER UPDATE ON `lawyer` FOR EACH ROW INSERT INTO lawyer_backup (id, name, surname, specialization, salary)
    VALUES (NEW.lawyerId, NEW.name, NEW.surname, NEW.specialization, NEW.salary)
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Stand-in structure for view `lawyerclientcaseview`
-- (See below for the actual view)
--
CREATE TABLE `lawyerclientcaseview` (
`ClientFullName` varchar(121)
,`LawyerFullName` varchar(121)
,`specialization` varchar(100)
,`startDate` date
,`statusCase` varchar(10)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `lawyerclientview`
-- (See below for the actual view)
--
CREATE TABLE `lawyerclientview` (
`ClientFullName` varchar(121)
,`LawyerFullName` varchar(121)
,`specialization` varchar(100)
);

-- --------------------------------------------------------

--
-- Table structure for table `lawyer_backup`
--

CREATE TABLE `lawyer_backup` (
  `lawyerbackupId` int(11) NOT NULL,
  `id` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `surname` varchar(60) NOT NULL,
  `specialization` varchar(100) NOT NULL,
  `salary` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lawyer_backup`
--

INSERT INTO `lawyer_backup` (`lawyerbackupId`, `id`, `name`, `surname`, `specialization`, `salary`) VALUES
(1, 0, 'Mickey', 'Cat', 'Criminal Law', 2000),
(2, 0, 'Greta', 'Garbo', 'Constitutional Law', 3400),
(3, 0, 'Emma', 'Watson', 'Environmental Law', 4300),
(4, 11, 'Meghan', 'Markle', 'First Amendment Law', 4000),
(5, 11, 'Meghan', 'Markle', 'First Amendment Law', 3500),
(6, 12, 'test', 'test', 'test', 9000),
(7, 12, 'test', 'test', 'test', 9000),
(8, 13, 'Dea', 'senka', 'Health Care Law', 5000),
(9, 13, 'Dea', 'Senka', 'Health Care Law', 4500),
(10, 13, 'Dea', 'Senka', 'Health Care Law', 4500),
(11, 14, 'julia', 'G', 'Constitutional Law', 7000),
(12, 14, 'Julia', 'Gray', 'Criminal Law', 6000),
(13, 14, 'Julia', 'Gray', 'Criminal Law', 6000),
(14, 15, 'Mona', 'Watson', 'First Amendment Law', 4300),
(15, 15, 'Monna', 'Markle', 'Environmental Law', 5000),
(16, 15, 'Monna', 'Markle', 'Environmental Law', 5000),
(17, 16, 'testes', 'teste', 'testets', 10000),
(18, 16, 'testes', 'ddddddddddd', 'dsssss', 399999),
(19, 16, 'testes', 'ddddddddddd', 'dsssss', 399999),
(20, 17, 'test', 'testese', 'estese', 299999),
(21, 17, 'testtest', 'test', 'testtesttesttest', 38888),
(22, 17, 'testtest', 'test', 'testtesttesttest', 38888);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userId` int(11) NOT NULL,
  `username` varchar(60) NOT NULL,
  `password` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userId`, `username`, `password`) VALUES
(1, 'admin', '8888'),
(3, 'unyt', 'unyt100');

-- --------------------------------------------------------

--
-- Structure for view `caseview`
--
DROP TABLE IF EXISTS `caseview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `caseview`  AS SELECT `lawyer`.`name` AS `LawyerName`, `client`.`name` AS `ClientName` FROM ((`cases` join `lawyer` on(`cases`.`lawyerId` = `lawyer`.`lawyerId`)) join `client` on(`cases`.`clientId` = `client`.`clientId`))  ;

-- --------------------------------------------------------

--
-- Structure for view `lawyerclientcaseview`
--
DROP TABLE IF EXISTS `lawyerclientcaseview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `lawyerclientcaseview`  AS SELECT concat(`client`.`name`,' ',`client`.`surname`) AS `ClientFullName`, concat(`lawyer`.`name`,' ',`lawyer`.`surname`) AS `LawyerFullName`, `lawyer`.`specialization` AS `specialization`, `cases`.`startDate` AS `startDate`, `cases`.`statusCase` AS `statusCase` FROM ((`cases` join `lawyer` on(`cases`.`lawyerId` = `lawyer`.`lawyerId`)) join `client` on(`cases`.`clientId` = `client`.`clientId`))  ;

-- --------------------------------------------------------

--
-- Structure for view `lawyerclientview`
--
DROP TABLE IF EXISTS `lawyerclientview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `lawyerclientview`  AS SELECT concat(`client`.`name`,' ',`client`.`surname`) AS `ClientFullName`, concat(`lawyer`.`name`,' ',`lawyer`.`surname`) AS `LawyerFullName`, `lawyer`.`specialization` AS `specialization` FROM ((`cases` join `lawyer` on(`cases`.`lawyerId` = `lawyer`.`lawyerId`)) join `client` on(`cases`.`clientId` = `client`.`clientId`))  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cases`
--
ALTER TABLE `cases`
  ADD PRIMARY KEY (`CaseId`),
  ADD KEY `clientFK` (`clientId`),
  ADD KEY `lawyerFK` (`lawyerId`);

--
-- Indexes for table `cases_backup`
--
ALTER TABLE `cases_backup`
  ADD PRIMARY KEY (`casebackupid`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`clientId`);

--
-- Indexes for table `client_backup`
--
ALTER TABLE `client_backup`
  ADD PRIMARY KEY (`clientbackupId`);

--
-- Indexes for table `lawyer`
--
ALTER TABLE `lawyer`
  ADD PRIMARY KEY (`lawyerId`);

--
-- Indexes for table `lawyer_backup`
--
ALTER TABLE `lawyer_backup`
  ADD PRIMARY KEY (`lawyerbackupId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cases`
--
ALTER TABLE `cases`
  MODIFY `CaseId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `cases_backup`
--
ALTER TABLE `cases_backup`
  MODIFY `casebackupid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `clientId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `client_backup`
--
ALTER TABLE `client_backup`
  MODIFY `clientbackupId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `lawyer`
--
ALTER TABLE `lawyer`
  MODIFY `lawyerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `lawyer_backup`
--
ALTER TABLE `lawyer_backup`
  MODIFY `lawyerbackupId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cases`
--
ALTER TABLE `cases`
  ADD CONSTRAINT `clientFK` FOREIGN KEY (`clientId`) REFERENCES `client` (`clientId`),
  ADD CONSTRAINT `lawyerFK` FOREIGN KEY (`lawyerId`) REFERENCES `lawyer` (`lawyerId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
