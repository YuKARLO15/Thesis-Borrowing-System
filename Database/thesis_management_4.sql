-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2024 at 03:36 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `thesis_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` text NOT NULL,
  `password` text NOT NULL,
  `admin_name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`, `admin_name`) VALUES
('admin1', '25f43b1486ad95a1398e3eeb3d83bc4010015fcc9bedb35b432e00298d5021f7', '');

-- --------------------------------------------------------

--
-- Table structure for table `borrowing`
--

CREATE TABLE `borrowing` (
  `Borrowed_ID` varchar(10) NOT NULL,
  `Student_ID` varchar(10) NOT NULL,
  `Thesis_Name` varchar(150) NOT NULL,
  `Status` text NOT NULL,
  `Date_Borrowed` date NOT NULL,
  `Due_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `borrowing`
--

INSERT INTO `borrowing` (`Borrowed_ID`, `Student_ID`, `Thesis_Name`, `Status`, `Date_Borrowed`, `Due_Date`) VALUES
('B_003', '2210984', 'ALUMNI TRACER SYSTEM: A WEB-BASED APPLICATION TO CONNECT WITH THE CITE ALUMNI OF BALIUAG UNIVERSITY', 'Borrowing', '2024-09-29', '2024-12-01'),
('B_004', '2010437', 'ALUMNI TRACER SYSTEM: A WEB-BASED APPLICATION TO CONNECT WITH THE CITE ALUMNI OF BALIUAG UNIVERSITY', 'Borrowing', '2024-09-30', '2024-10-03'),
('B_005', '2010437', 'A Systematized TODA Registration using QR Code for Baliuag City with Fare Matrix', 'Borrowing', '2024-09-30', '2024-10-05');

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE `student_info` (
  `Student_ID` varchar(10) NOT NULL,
  `Password` text NOT NULL,
  `Student_Name` text NOT NULL,
  `Course` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`Student_ID`, `Password`, `Student_Name`, `Course`) VALUES
('2010437', '4f31fa50e5bd5ff45684e560fc24aeee527a43739ab611c49c51098a33e2b469', 'Inovero, Matt Andrew V.', 'BSIT'),
('2210984', '97ab98874db123d80c8b3b0e0f4577ed40cc05be11e27a7d36f7c0af32144b9b', 'Wagan, Karlo Robert C.', 'BSCS');

-- --------------------------------------------------------

--
-- Table structure for table `thesis_info`
--

CREATE TABLE `thesis_info` (
  `Thesis_Name` varchar(150) NOT NULL,
  `Year_Publish` text NOT NULL,
  `Copies` int(11) NOT NULL,
  `Category` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `thesis_info`
--

INSERT INTO `thesis_info` (`Thesis_Name`, `Year_Publish`, `Copies`, `Category`) VALUES
('8 WAVES TOUCHSCREEN INFORMATION KIOSK', '2019', 2, 'Internet of Things'),
('A HUNDRED WAYS TO SAY HELLO: A 2D…', '2019', 4, 'Games & Animation'),
('A Systematized TODA Registration using QR Code for Baliuag City with Fare Matrix', '2023', 5, 'Transportation'),
('A WEB-BASED APPLICATION SYSTEM FOR …', '2016', 1, 'Web-Based Spplications'),
('ALUMNI TRACER SYSTEM: A WEB-BASED APPLICATION TO CONNECT WITH THE CITE ALUMNI OF BALIUAG UNIVERSITY', '2023', 7, 'Web Application'),
('AN ANDROID EVENT SENDER APPLICATION: THE INTELLIGENT FLASH', '2018', 3, 'Mobile Applications'),
('AN OFFICIAL WEBSITE FOR SOLLAZZARE …', '2015', 1, 'Web-Based Application'),
('AN ONLINE RESERVATION, SALES AND INVENTORY SYSTEM', '2012', 1, 'Web-Based Application'),
('ANIMATED EDUCATIONAL MATERIAL IN COMPUTER SUBJECT FOR GRADE 1', '2012', 1, 'Learning and Education Tools'),
('APPLICATION: Barangay Management System', '2022', 1, 'Mobile Applications'),
('APPTRIKE: A MOBILE APPLICATION', '2018', 3, 'Mobile Applications'),
('ATTENDANCE MONITORING SYSTEM USING BIOMETRICS', '2016', 2, 'Attendance and Monitoring Systems'),
('ATTENDANCE MONITORING SYSTEM USING QR CODE WITH CONTACT TRACING FOR IT BUILDING', '2022', 2, 'Attendance and Monitoring Systems'),
('Auto-Off PC Scheduling System for Information Technology Building', '2018', 2, 'Internet of Things'),
('Baliuag University ITB Virtual Reality Tour a Mobile….', '2016', 1, 'Mobile Applications'),
('BALIUAG UNIVERSITY LIBRARY ARCHIVES & MUSEUM SYSTEMS', '2015', 2, 'Web-Based Application'),
('BALIWAG WATER DISTRICT EMPLOYEE INFORMATION SYSTEM', '2018', 2, 'Web-Based Applications'),
('BantayBaha: Flood Monitoring System with SMS Notification', '2019', 6, 'Healthcare & Safety'),
('BEEBAYIN: A MOBILE APPLICATION GAME TO REKINDLE BAYBAYIN AT BALIUAG UNIVERSITY', '2023', 3, 'Mobile Application'),
('BEEPAY: SCHOOL ID WITH E-WALLET OF BALIUAG UNIVERSITY', '2021', 3, 'Mobile Applications'),
('BEESAFE: Safety Application with Real-time Location Tracking', '2021', 3, 'Mobile Applications'),
('BI S.A.F.E: BALIWAGI SAFETY APP FOR EMERGENCY', '2018', 5, 'Healthcare & Safety'),
('BOOKHISLANDMARKS: A MOBILE APPLICATION', '2015', 1, 'Mobile Applications'),
('Bound: An Application Limiter with Usage Statistics', '2021', 5, 'Web-Based Applications'),
('BU ONLINE LEARNING ACCESS ON ACADEMIC RESOURCES', '2015', 1, 'Learning and Education Tools'),
('CAMPUSROOKIES: A VIDEO GAME TOUR GUIDE FOR INCOMING FRESHMEN IN BALIUAG UNIVERSITY', '2021', 3, 'Games & Animation'),
('CIELOCKS: CITE ELECTRONIC LOCKS', '2018', 5, 'Internet of Things'),
('CITE ALUMNI PORTAL', '2018', 3, 'Web-Based Applications'),
('CITE EVENT MESSAGING NOTIFICATION', '2018', 2, 'Mobile Applications'),
('CITE INFO TECH', '2018', 4, 'Mobile Applications'),
('Dynamic Website for Municipal Social Welfare and Development of San Rafael, Bulacan', '2022', 1, 'Web-Based Applications'),
('E-COMMERCE WEBSITE WITH SALES AND INVENTORY…', '2019', 4, 'E-Commerce and Sales'),
('EMC (ENERGY MANAGEMENT AND CONTROLLER) USING INTERNET OF THINGS FOR PUBLIC SCHOOLS', '2018', 3, 'Internet of Things'),
('EMPLOYEE PORTAL FOR AMBIT SECURITY AGENCY INC.', '2017', 1, 'Web-Based Applications'),
('ESP LEARNING TOOL FOR GRADE SIX STUDENTS OF BU', '2018', 2, 'Learning and Education Tools'),
('ESTABLISHING A DYNAMIC WEBSITE FOR HEALTHFIT ….', '2016', 1, 'Web-Based Application'),
('FFQ: Fire, Flood and Earthquake Alarm System', '2021', 5, 'Internet of Things'),
('Find-U in BU: A Professor Locator and Online Scheduling Application', '2022', 1, 'Mobile Applications'),
('FIRST AID ESSENTIALS: A MOBILE APPLICATION', '2016', 1, 'Games & Animation'),
('FITNESS GYM ATTENDANCE MONITORING USING BARCODE….', '2016', 1, 'Attendance and Monitoring Systems'),
('GRACEAN TAMBAYAN: A WEB APPLICATION FOR …', '2018', 3, 'Web-Based Applications'),
('I\'M BROKEN: AN ANIMATED FILM SHOWING THE ….', '2018', 4, 'Games & Animation'),
('iCare: A Smart Dog Food and Water Dispenser', '2019', 3, 'Healthcare & Safety'),
('Implementation of a Pathfinding Visualizer Application for the Baliuag University Main Campus', '2021', 6, 'Mobile Applications'),
('JUST FOR A SMOKE: A 2D ANIMATED SHORT FILM', '2019', 6, 'Games & Animation'),
('K TO 12 E-LEARNING  FOR EMPOWERMENT TECHNOLOGIES….', '2015', 2, 'Learning and Education Tools'),
('LAN BASED FACULTY EVALUATION SYSTEM', '2018', 4, 'Network-Based Applications'),
('Legend of Chocolate Hills: A RPG Game', '2016', 1, 'Web-Based Application'),
('MICARE: SELF TRACKER AND REMINDER RPG', '2022', 3, 'Healthcare & Safety'),
('MOBILE APPLICATION: FARE MATRIX FOR BALIWAG …', '2017', 1, 'Mobile Applications'),
('ON-THE-JOB MONITORING SYSTEM USING APPROXIMATE COMPUTING ALGORITHM', '2018', 5, 'Attendance and Monitoring Systems'),
('ONLINE RESERVATION, SALES AND INVENTORY SYSTEM FOR BELLE PEAU SALON AND SPA', '2012', 1, 'Web-Based Application'),
('PALITIMBANGAN: GARBAGE EXCHANGE POINT SYSTEM', '2019', 4, 'Internet of Things'),
('PEPPAFEED: AUTOMATIC HOG FEEDER', '2020', 5, 'Mobile Applications'),
('POCKET LAW: USING ANDROID OPERATING SYSTEM', '2013', 1, 'Mobile Applications'),
('PROPERTY AND EQUIPMENT TRACKING SYSTEM OF …', '2019', 8, 'Internet of Things'),
('QUEUEING MANAGEMENT SYSTEM FOR BALIUAG UNIVERSITY', '2018', 3, 'Internet of Things'),
('REALTIME ATTENDANCE CHECKER FOR BALIUAG UNIVERSITY', '2018', 3, 'Attendance and Monitoring Systems'),
('RECORD KEEPING WITH GRADING SYSTEM FOR BALIUAG UNIVERSITY', '2018', 2, 'Web-Based Applications'),
('RENTAP: RENT IN A TAP BALIWAG RENTAL SPACE LOCATOR MOBILE APPLICATION', '2023', 4, 'Mobile Applications'),
('RESERVE ME: ONLINE HOSPITAL RESERVATION FOR JESUS, THE GOOD SHEPHERD HOSPITAL', '2018', 2, 'Healthcare & Safety'),
('REVBUS: A MOBILE SEAT RESERVATION APP FOR BALIWAG TRANSIT INC.', '2021', 2, 'Mobile Applications'),
('RFID GATE MONITORING SYSTEM FOR BASIC …', '2019', 1, 'Internet of Things'),
('SABLAN DENTAL CLINIC PATIENT\'S INFORMATION SYSTEM', '2018', 3, 'Healthcare & Safety'),
('STAND UP: A 3D ANIMATED SHORT FILM', '2017', 1, 'Games & Animation'),
('TAP LIVE SAVE: AN ATTENTIVE MOBILE GAME…', '2015', 2, 'Games & Animation'),
('Technovation - Online Learning Video Platform', '2021', 2, 'Web-Based Applications'),
('THE HEIR: A 3D OPEN-WORLD MOBILE GAME….', '2017', 4, 'Games & Animation'),
('TURBO CEE ADVENTURE: A 2D PROGRAMMING GAME….', '2016', 2, 'Games & Animation'),
('VIDEO SHARING WEBSITE FOR BALIWAG WEB TV', '2018', 4, 'Web-Based Applications'),
('WAREHOUSE MANAGEMENT SYSTEM USING MD5 ALGORITHM FOR CARGILL PULILAN', '2018', 3, 'Web-Based Applications'),
('WEB AND MOBILE APP FOR ABRU BEACH FRONT RESORT…', '2017', 2, 'Web-Based Applications  and Mobile-App'),
('Web Based Medical Mission Reservation System Barangay San Jose', '2021', 2, 'Web-Based Applications'),
('WEB-BASED ATTENDANCE MONITORING FOR THE FACULTY OF COLLEGE OF IT EDUCATION USING RFID', '2023', 5, 'Attendance and Monitoring Systems'),
('WebCITE: Baliuag University College of Information Technology Education Web Portal', '2022', 1, 'Web-Based Applications');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD UNIQUE KEY `username` (`username`) USING HASH;

--
-- Indexes for table `borrowing`
--
ALTER TABLE `borrowing`
  ADD PRIMARY KEY (`Borrowed_ID`),
  ADD KEY `Student_ID` (`Student_ID`),
  ADD KEY `Thesis_Name` (`Thesis_Name`);

--
-- Indexes for table `student_info`
--
ALTER TABLE `student_info`
  ADD PRIMARY KEY (`Student_ID`);

--
-- Indexes for table `thesis_info`
--
ALTER TABLE `thesis_info`
  ADD PRIMARY KEY (`Thesis_Name`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `borrowing`
--
ALTER TABLE `borrowing`
  ADD CONSTRAINT `borrowing_ibfk_1` FOREIGN KEY (`Student_ID`) REFERENCES `student_info` (`Student_ID`) ON DELETE NO ACTION,
  ADD CONSTRAINT `borrowing_ibfk_2` FOREIGN KEY (`Thesis_Name`) REFERENCES `thesis_info` (`Thesis_Name`) ON DELETE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
