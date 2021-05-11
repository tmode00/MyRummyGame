-- phpMyAdmin SQL Dump
-- version 4.7.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Erstellungszeit: 10. Mai 2021 um 21:48
-- Server-Version: 10.3.22-MariaDB-1:10.3.22+maria~stretch
-- PHP-Version: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `tmode00_bousers`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `romegame`
--

CREATE TABLE `romegame` (
  `id` int(11) NOT NULL,
  `GameID` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `GameCreationTime` timestamp NOT NULL DEFAULT current_timestamp(),
  `Player1Cards` varchar(600) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Player2Cards` varchar(600) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `UsedCards` varchar(600) NOT NULL,
  `Player1KartenInHand` int(11) NOT NULL,
  `Player2KartenInHand` int(11) NOT NULL,
  `ZugID` int(11) NOT NULL,
  `Spielphase` varchar(50) NOT NULL,
  `Weristdran` varchar(20) NOT NULL,
  `DropZone1` varchar(600) NOT NULL,
  `DropZone2` varchar(600) NOT NULL,
  `DropZone3` varchar(600) NOT NULL,
  `DropZone4` varchar(600) NOT NULL,
  `DropZone5` varchar(600) NOT NULL,
  `DropZone6` varchar(600) NOT NULL,
  `DropZone7` varchar(600) NOT NULL,
  `DropZone8` varchar(600) NOT NULL,
  `DropZone9` varchar(600) NOT NULL,
  `DropZone10` varchar(600) NOT NULL,
  `Player1hat30` tinyint(1) NOT NULL,
  `Player2hat30` tinyint(1) NOT NULL,
  `StrafpunkteP1` int(11) NOT NULL,
  `StrafpunkteP2` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `romegame`
--
ALTER TABLE `romegame`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `romegame`
--
ALTER TABLE `romegame`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2056;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
