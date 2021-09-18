-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  Dim 16 fév. 2020 à 11:23
-- Version du serveur :  10.1.28-MariaDB
-- Version de PHP :  7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `hopitale`
--
create database hopitale;
use hopitale;
DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddEditmedcin` (`_ID` INT, `_Name` VARCHAR(45), `_lastName` VARCHAR(45), `_user` VARCHAR(50), `_Passe` VARCHAR(45))  BEGIN
IF _BookID = 0 THEN
INSERT INTO `medcin` (`Nom`, `prenom`, `email`, `password`) VALUES ( _Name, _lastName, _user, _Passe);
ELSE 
UPDATE `medcin`
SET
`Nom` = _Name,
`prenom` = _lastName,

`email` = _user,
`password`=_Passe
WHERE
`id` = _ID;
END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `MedcinTble` ()  BEGIN
SELECT * FROM medcin;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `nom` varchar(45) DEFAULT NULL,
  `prenom` varchar(45) DEFAULT NULL,
  `mail` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`id`, `nom`, `prenom`, `mail`, `password`) VALUES
(1, 'Moussaoui', 'Tarek', 'tarikmoussaoui@mt.mt', 'mt00722');

-- --------------------------------------------------------

--
-- Structure de la table `creneau_libre`
--

CREATE TABLE `creneau_libre` (
  `id` int(11) NOT NULL,
  `heure_debut` varchar(45) DEFAULT NULL,
  `heure_fin` varchar(45) DEFAULT NULL,
  `idMedcin` int(11) NOT NULL,
  `Etat` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `creneau_libre`
--

INSERT INTO `creneau_libre` (`id`, `heure_debut`, `heure_fin`, `idMedcin`, `Etat`) VALUES
(2, '12:00', '12:30', 0, 1),
(3, '1', '1', 0, 0),
(4, '1', '1', 0, 0),
(5, '1', '1', 0, 0),
(6, '1', '1', 0, 1),
(8, '1', '1', 11, 1),
(9, '13', '13:30', 11, 1);

-- --------------------------------------------------------

--
-- Structure de la table `creneau_libre_has_medcin`
--

CREATE TABLE `creneau_libre_has_medcin` (
  `creneau_libre_id` int(11) NOT NULL,
  `Medcin_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `etat_patient`
--

CREATE TABLE `etat_patient` (
  `id` int(11) NOT NULL,
  `id_patient` int(11) DEFAULT NULL,
  `discription` varchar(450) DEFAULT NULL,
  `tension` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `tempirature` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `etat_patient`
--

INSERT INTO `etat_patient` (`id`, `id_patient`, `discription`, `tension`, `Date`, `tempirature`) VALUES
(1, 1, 'tarik', 15, '2020-02-14', 40),
(2, 2, 'ug', 1, '2001-01-01', 1);

-- --------------------------------------------------------

--
-- Structure de la table `infermier`
--

CREATE TABLE `infermier` (
  `id` int(11) NOT NULL,
  `nom` varchar(45) DEFAULT NULL,
  `prenom` varchar(45) DEFAULT NULL,
  `mail` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `id_admin` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `infermier`
--

INSERT INTO `infermier` (`id`, `nom`, `prenom`, `mail`, `password`, `id_admin`) VALUES
(1, 'AA', 'AA', 'AAAA', 'AAAAA', NULL),
(2, 'a', 'a', 'a', 'a', NULL),
(3, 'T', 'T', 'T', 'T', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `medcin`
--

CREATE TABLE `medcin` (
  `id` int(11) NOT NULL,
  `Nom` varchar(45) DEFAULT NULL,
  `prenom` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `id_admin` int(11) DEFAULT NULL,
  `Medcincol` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `medcin`
--

INSERT INTO `medcin` (`id`, `Nom`, `prenom`, `email`, `password`, `id_admin`, `Medcincol`) VALUES
(1, 'tarek', 'moussaoui', 'tarikms1aa', 'MT AG 1', NULL, NULL),
(3, '_Name', '_lastName', ' _user', ' _Passe', NULL, NULL),
(4, 'tarik', 'moussaoui', 'mt@', 'mt', NULL, NULL),
(7, '1', 'AAA', 'AA', 'AA', NULL, NULL),
(10, '1', '1', '1', '1', NULL, NULL),
(11, 't', 't', 't', 't', NULL, NULL),
(13, '1', '1', '1', '1', NULL, NULL),
(14, 'tar', 'mou', 'mt@mt.mt', 'mt', NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

CREATE TABLE `patient` (
  `id` int(11) NOT NULL,
  `nom` varchar(45) DEFAULT NULL,
  `prenom` varchar(45) DEFAULT NULL,
  `age` varchar(45) DEFAULT NULL,
  `sex` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`id`, `nom`, `prenom`, `age`, `sex`) VALUES
(2, 't', 'moussaoui', '13', 'male'),
(4, 'u', 'u', '15', 'tG');

-- --------------------------------------------------------

--
-- Structure de la table `patient_has_rdv`
--

CREATE TABLE `patient_has_rdv` (
  `patient_id` int(11) NOT NULL,
  `RDV_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `rdv`
--

CREATE TABLE `rdv` (
  `id` int(11) NOT NULL,
  `id_patient` int(11) DEFAULT NULL,
  `id_medc` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `rdv`
--

INSERT INTO `rdv` (`id`, `id_patient`, `id_medc`) VALUES
(1, 1, 11),
(2, 2, 11),
(3, 2, 11),
(4, 4, 11);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `creneau_libre`
--
ALTER TABLE `creneau_libre`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `creneau_libre_has_medcin`
--
ALTER TABLE `creneau_libre_has_medcin`
  ADD PRIMARY KEY (`creneau_libre_id`,`Medcin_id`),
  ADD KEY `fk_creneau_libre_has_Medcin_Medcin1_idx` (`Medcin_id`),
  ADD KEY `fk_creneau_libre_has_Medcin_creneau_libre1_idx` (`creneau_libre_id`);

--
-- Index pour la table `etat_patient`
--
ALTER TABLE `etat_patient`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_etat_patient_patient_idx` (`id_patient`);

--
-- Index pour la table `infermier`
--
ALTER TABLE `infermier`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_infermier_Admin1_idx` (`id_admin`);

--
-- Index pour la table `medcin`
--
ALTER TABLE `medcin`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_Medcin_Admin1_idx` (`id_admin`);

--
-- Index pour la table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `patient_has_rdv`
--
ALTER TABLE `patient_has_rdv`
  ADD PRIMARY KEY (`patient_id`,`RDV_id`),
  ADD KEY `fk_patient_has_RDV_RDV1_idx` (`RDV_id`),
  ADD KEY `fk_patient_has_RDV_patient1_idx` (`patient_id`);

--
-- Index pour la table `rdv`
--
ALTER TABLE `rdv`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_RDV_Medcin1_idx` (`id_medc`),
  ADD KEY `fk_RDV_patient1_idx` (`id_patient`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `creneau_libre`
--
ALTER TABLE `creneau_libre`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `etat_patient`
--
ALTER TABLE `etat_patient`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `infermier`
--
ALTER TABLE `infermier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `medcin`
--
ALTER TABLE `medcin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pour la table `patient`
--
ALTER TABLE `patient`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `rdv`
--
ALTER TABLE `rdv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
