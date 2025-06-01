-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 01, 2025 at 10:23 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `BookID` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `PDFPath` varchar(500) NOT NULL,
  `CoverPath` varchar(500) DEFAULT NULL,
  `TotalPages` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`BookID`, `Title`, `Author`, `PDFPath`, `CoverPath`, `TotalPages`) VALUES
(5, 'test', 'eren', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Books\\82f0a985-4c12-46a3-ae20-f733391d7b1d.pdf', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Covers\\de604868-80e1-4bd6-8058-69694eb43aa0.jpg', 0),
(6, 'erewsrwer', 'fwef', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Books\\d4b11602-13a8-4edb-94ef-cb6f100abd03.pdf', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Covers\\1b59469e-98e1-44d2-9ef5-147a5f75f00f.jpg', 0),
(7, 'eren', 'deneme3123', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Books\\9d8042a0-d8fc-41c1-b583-23ebd96de5e2.pdf', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Covers\\1bbde8c0-0f69-4fa3-bde8-db15469e6a7c.jpg', 0),
(8, 'eren2324', 'deneme15', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Books\\bf68ead4-a034-42b3-a1f8-bf024db28c66.pdf', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Covers\\5a53aa89-db5d-46cf-b094-0e5008178256.jpg', 35),
(84, 'Oliver Twist', 'Charles Dickens', '', 'C:\\Covers\\Oliver_Twist_Charles_Dickens.jpg', 849),
(85, 'Frankenstein or The Modern Prometheus', 'Mary Shelley', '', 'C:\\Covers\\Frankenstein_or_The_Modern_Prometheus_Mary_Shelley.jpg', 424),
(86, 'Sense and Sensibility', 'Jane Austen', '', 'C:\\Covers\\Sense_and_Sensibility_Jane_Austen.jpg', 691),
(87, 'Gulliver\'s Travels', 'Jonathan Swift', '', 'C:\\Covers\\Gulliver\'s_Travels_Jonathan_Swift.jpg', 465),
(88, 'The Secret Garden', 'Frances Hodgson Burnett', '', 'C:\\Covers\\The_Secret_Garden_Frances_Hodgson_Burnett.jpg', 222),
(89, 'The Adventures of Tom Sawyer', 'Mark Twain', '', 'C:\\Covers\\The_Adventures_of_Tom_Sawyer_Mark_Twain.jpg', 511),
(90, 'Le Comte de Monte Cristo', 'Alexandre Dumas', '', 'C:\\Covers\\Le_Comte_de_Monte_Cristo_Alexandre_Dumas.jpg', 599),
(91, 'War and Peace', 'Лев Толстой', '', 'C:\\Covers\\War_and_Peace_Лев_Толстой.jpg', 371),
(92, 'Little men', 'Louisa May Alcott', '', 'C:\\Covers\\Little_men_Louisa_May_Alcott.jpg', 742),
(93, 'Animal Farm', 'George Orwell', '', 'C:\\Covers\\Animal_Farm_George_Orwell.jpg', 834),
(94, 'Heidi', 'Johanna Spyri', '', 'C:\\Covers\\Heidi_Johanna_Spyri.jpg', 433),
(95, 'Доктор Живаго', 'Boris Leonidovich Pasternak', '', 'C:\\Covers\\Доктор_Живаго_Boris_Leonidovich_Pasternak.jpg', 425),
(96, 'Das Schloß', 'Franz Kafka', '', 'C:\\Covers\\Das_Schloß_Franz_Kafka.jpg', 343),
(97, 'Death on the Nile', 'Agatha Christie', '', 'C:\\Covers\\Death_on_the_Nile_Agatha_Christie.jpg', 451),
(98, 'The A.B.C. Murders', 'Agatha Christie', '', 'C:\\Covers\\The_A.B.C._Murders_Agatha_Christie.jpg', 320),
(99, 'A Murder Is Announced', 'Agatha Christie', '', 'C:\\Covers\\A_Murder_Is_Announced_Agatha_Christie.jpg', 549),
(100, 'The Murder at the Vicarage', 'Agatha Christie', '', 'C:\\Covers\\The_Murder_at_the_Vicarage_Agatha_Christie.jpg', 211),
(101, 'The Body in the Library', 'Agatha Christie', '', 'C:\\Covers\\The_Body_in_the_Library_Agatha_Christie.jpg', 390),
(102, 'Black Beauty', 'Anna Sewell', '', 'C:\\Covers\\Black_Beauty_Anna_Sewell.jpg', 619),
(103, 'The Giver', 'Lois Lowry', '', 'C:\\Covers\\The_Giver_Lois_Lowry.jpg', 535),
(104, 'A Caribbean Mystery', 'Agatha Christie', '', 'C:\\Covers\\A_Caribbean_Mystery_Agatha_Christie.jpg', 880),
(105, 'Also sprach Zarathustra', 'Friedrich Nietzsche', '', 'C:\\Covers\\Also_sprach_Zarathustra_Friedrich_Nietzsche.jpg', 767),
(106, 'The Bridge of San Luis Rey', 'Thornton Wilder', '', 'C:\\Covers\\The_Bridge_of_San_Luis_Rey_Thornton_Wilder.jpg', 506),
(107, 'The Bobbsey Twins', 'Laura Lee Hope', '', 'C:\\Covers\\The_Bobbsey_Twins_Laura_Lee_Hope.jpg', 298),
(108, 'The Talisman', 'Sir Walter Scott', '', 'C:\\Covers\\The_Talisman_Sir_Walter_Scott.jpg', 387),
(109, 'SPIRITS REBELLIOUS', 'Kahlil Gibran', '', 'C:\\Covers\\SPIRITS_REBELLIOUS_Kahlil_Gibran.jpg', 349),
(110, 'The power and the Glory', 'Graham Greene', '', 'C:\\Covers\\The_power_and_the_Glory_Graham_Greene.jpg', 133),
(111, 'Chance', 'Joseph Conrad', '', 'C:\\Covers\\Chance_Joseph_Conrad.jpg', 807),
(112, 'Landfall, a channel story', 'Nevil Shute', '', 'C:\\Covers\\Landfall,_a_channel_story_Nevil_Shute.jpg', 533),
(113, 'How Green Was My Valley', 'Richard Llewellyn', '', 'C:\\Covers\\How_Green_Was_My_Valley_Richard_Llewellyn.jpg', 636),
(114, 'The Wayward Bus', 'John Steinbeck', '', 'C:\\Covers\\The_Wayward_Bus_John_Steinbeck.jpg', 354),
(115, 'The Black Stallion', 'Walter Farley', '', 'C:\\Covers\\The_Black_Stallion_Walter_Farley.jpg', 631),
(116, 'The Harvester', 'Gene Stratton-Porter', '', 'C:\\Covers\\The_Harvester_Gene_Stratton-Porter.jpg', 256),
(117, 'Miss Marple\'s Final Cases and Two Other Stories [8 stories]', 'Agatha Christie', '', 'C:\\Covers\\Miss_Marple\'s_Final_Cases_and_Two_Other_Stories_[8_stories]_Agatha_Christie.jpg', 407),
(118, 'The Honor of the Big Snows', 'James Oliver Curwood', '', 'C:\\Covers\\The_Honor_of_the_Big_Snows_James_Oliver_Curwood.jpg', 437),
(119, 'The Bastard', 'John Jakes', '', 'C:\\Covers\\The_Bastard_John_Jakes.jpg', 574),
(120, 'Disney\'s The jungle book', 'Rudyard Kipling', '', 'C:\\Covers\\Disney\'s_The_jungle_book_Rudyard_Kipling.jpg', 781),
(121, 'The city boy', 'Herman Wouk', '', 'C:\\Covers\\The_city_boy_Herman_Wouk.jpg', 765),
(122, 'The Sea For Breakfast', 'Lillian Beckwith', '', 'C:\\Covers\\The_Sea_For_Breakfast_Lillian_Beckwith.jpg', 898),
(123, 'Three Plays', 'Thornton Wilder', '', 'C:\\Covers\\Three_Plays_Thornton_Wilder.jpg', 324),
(124, 'The Eighth Day', 'Thornton Wilder', '', 'C:\\Covers\\The_Eighth_Day_Thornton_Wilder.jpg', 684),
(125, 'Lost in the Barrens - Collector\'s Edition', 'Farley Mowat', '', 'C:\\Covers\\Lost_in_the_Barrens_-_Collector\'s_Edition_Farley_Mowat.jpg', 900),
(126, 'Tilly', 'Catherine Cookson', '', '', 700),
(127, 'Hurry up, Franklin', 'Paulette Bourgeois', '', 'C:\\Covers\\Hurry_up,_Franklin_Paulette_Bourgeois.jpg', 128),
(128, 'Tomorrow will be better', 'Betty Smith', '', 'C:\\Covers\\Tomorrow_will_be_better_Betty_Smith.jpg', 731),
(129, 'The Seven-Per-Cent Solution', 'Nicholas Meyer', '', 'C:\\Covers\\The_Seven-Per-Cent_Solution_Nicholas_Meyer.jpg', 170),
(130, 'Pooh Goes Visiting and Pooh & Piglet Nearly Catch a Woozle', 'A. A. Milne', '', 'C:\\Covers\\Pooh_Goes_Visiting_and_Pooh_&_Piglet_Nearly_Catch_a_Woozle_A._A._Milne.jpg', 401),
(131, 'Inside, Outside', 'Herman Wouk', '', 'C:\\Covers\\Inside,_Outside_Herman_Wouk.jpg', 356),
(132, 'Flug nach Arras', 'Antoine de Saint-Exupéry', '', 'C:\\Covers\\Flug_nach_Arras_Antoine_de_Saint-Exupéry.jpg', 567),
(133, 'The Beloved Invader', 'Eugenia Price', '', 'C:\\Covers\\The_Beloved_Invader_Eugenia_Price.jpg', 461),
(134, 'Görsel Programlama 3. Hafta', 'Adnan Kürşat TEKE', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Books\\856d214c-4b73-4de4-ac31-66038442e8e4.pdf', 'C:\\Users\\ERENPAD\\source\\repos\\KutuphaneP\\KutuphaneP\\bin\\Debug\\Covers\\3e65d9c0-fad5-42e5-85b0-bde86dfea24e.png', 33);

-- --------------------------------------------------------

--
-- Table structure for table `book_categories`
--

CREATE TABLE `book_categories` (
  `BookID` int(11) NOT NULL,
  `CategoryID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `CategoryID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`CategoryID`, `Name`) VALUES
(1, 'Klasikler'),
(2, 'Ders Materyali'),
(3, 'Yeni Kategori');

-- --------------------------------------------------------

--
-- Table structure for table `userlibrary`
--

CREATE TABLE `userlibrary` (
  `UserLibraryID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `BookID` int(11) DEFAULT NULL,
  `LastPage` int(11) DEFAULT 0,
  `TotalPages` int(11) DEFAULT 0,
  `Completion` float DEFAULT 0,
  `IsFavorite` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userlibrary`
--

INSERT INTO `userlibrary` (`UserLibraryID`, `UserID`, `BookID`, `LastPage`, `TotalPages`, `Completion`, `IsFavorite`) VALUES
(8, 1, 5, 7, 16, 0.5, 0),
(9, 1, 6, 10, 16, 0.6875, 1),
(10, 1, 7, 2, 35, 0.0857143, 0),
(11, 1, 8, 7, 35, 0.228571, 0),
(12, 5, 5, 8, 16, 0.5625, 1),
(13, 1, 93, 0, 834, 0, 0),
(14, 6, 7, 10, 35, 0.314286, 1),
(15, 6, 134, 13, 33, 0.424242, 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `PasswordHash`) VALUES
(1, 'eren', '123'),
(2, 'eren1', '123'),
(3, 'eren12', '123'),
(4, 'eren2', '123'),
(5, 'wa', '123'),
(6, 'adnan', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`BookID`);

--
-- Indexes for table `book_categories`
--
ALTER TABLE `book_categories`
  ADD PRIMARY KEY (`BookID`,`CategoryID`),
  ADD KEY `CategoryID` (`CategoryID`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`CategoryID`);

--
-- Indexes for table `userlibrary`
--
ALTER TABLE `userlibrary`
  ADD PRIMARY KEY (`UserLibraryID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `BookID` (`BookID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=136;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `CategoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `userlibrary`
--
ALTER TABLE `userlibrary`
  MODIFY `UserLibraryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `book_categories`
--
ALTER TABLE `book_categories`
  ADD CONSTRAINT `book_categories_ibfk_1` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`) ON DELETE CASCADE,
  ADD CONSTRAINT `book_categories_ibfk_2` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`CategoryID`) ON DELETE CASCADE;

--
-- Constraints for table `userlibrary`
--
ALTER TABLE `userlibrary`
  ADD CONSTRAINT `userlibrary_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `userlibrary_ibfk_2` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
