-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2024 at 05:21 PM
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
-- Database: `dbvaccine`
--

-- --------------------------------------------------------

--
-- Table structure for table `regis_form`
--

CREATE TABLE `regis_form` (
  `id_regis` int(11) NOT NULL,
  `nik` text NOT NULL,
  `email` text NOT NULL,
  `nama` text NOT NULL,
  `no_telp` text NOT NULL,
  `tgl_lahir` date NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `regis_form`
--

INSERT INTO `regis_form` (`id_regis`, `nik`, `email`, `nama`, `no_telp`, `tgl_lahir`, `username`, `password`) VALUES
(1, '1234567891234561', 'navira@gmail.com', 'Navira', '083627483748', '2007-05-16', 'naps', 'nap123'),
(2, '1234567891234562', 'nia@gmail.com', 'Aghnia Nurhidayah', '086384928084', '2001-10-24', 'nia', 'nia123'),
(3, '1234567891234563', 'ara@gmail.com', 'Ara Anjani', '086372849573', '2000-02-01', 'ara', 'ara123'),
(5, '1234567891234567', 'ina@gmail.com', 'Inaaa', '081234567899', '1996-11-13', 'ina', 'ina123'),
(12, '6571000000000000', 'risa@gmail.com', 'Aprisa Idma Mutiara', '081234567899', '2004-04-29', 'risa', 'risa123'),
(13, '6572000000000000', 'nap@gmail.com', 'Navira Arditha Aulia', '089612345678', '2004-04-28', 'nap', 'nap123');

-- --------------------------------------------------------

--
-- Table structure for table `vaccine_form`
--

CREATE TABLE `vaccine_form` (
  `id_form` int(11) NOT NULL,
  `nik` text NOT NULL,
  `nama` text NOT NULL,
  `tempat_lahir` text NOT NULL,
  `alamat` text NOT NULL,
  `no_hp` text NOT NULL,
  `ttl_lahir` date NOT NULL,
  `tgl_vaksin` date NOT NULL,
  `provinsi` text NOT NULL,
  `kab_kota` text NOT NULL,
  `jenis_vaksin` text NOT NULL,
  `jenis_kelamin` text NOT NULL,
  `tgl_aju` date NOT NULL,
  `status` text NOT NULL,
  `user` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vaccine_form`
--

INSERT INTO `vaccine_form` (`id_form`, `nik`, `nama`, `tempat_lahir`, `alamat`, `no_hp`, `ttl_lahir`, `tgl_vaksin`, `provinsi`, `kab_kota`, `jenis_vaksin`, `jenis_kelamin`, `tgl_aju`, `status`, `user`) VALUES
(4, '6409015428304561', 'Navira Arditha Aulia', 'Malang', 'Jalan Merdeka', '082164738498', '2024-04-28', '2024-05-28', 'Kalimantan Timur', 'Balikpapan', 'Covid-19', 'Perempuan', '2024-05-13', 'Selesai', 'naps'),
(5, '6408024568012346', 'Syakira Aulia Rahma', 'Malang', 'Jalan Merdeka', '081374839208', '2024-04-01', '2024-05-14', 'Kalimantan Timur', 'Balikpapan', 'Covid-19', 'Perempuan', '2024-05-13', 'Selesai', 'naps'),
(7, '0987654321112567', 'Aghnia Nurhidayah', 'Samarinda', 'Perjuangan', '082193092738', '2024-05-13', '2024-06-01', 'Kalimantan Timur', 'Bontang', 'Rabies', 'Perempuan', '2024-05-16', 'Tolak', 'nia'),
(8, '1989182981209839', 'Tiara Cahya', 'Balikpapan', 'Jalan Pramuka', '081374839082', '2024-05-02', '2024-05-24', 'Kalimantan Timur', 'Balikpapan', 'Covid-19', 'Perempuan', '2024-05-16', 'Proses', 'ara'),
(9, '2345678909876543', 'Tata Banana', 'Balikpapan', 'Jalan Merdeka', '081234567890', '2024-05-13', '2024-10-12', 'Kalimantan Timur', 'Samarinda', 'Covid-19', 'Perempuan', '2024-05-16', 'Proses', 'naps'),
(10, '3092028342746283', 'Abe n Rahmat', 'Balikpapan', 'Alam Segar', '089753555768', '2024-05-12', '2024-05-18', 'Kalimantan Timur', 'Banjarmasin', 'Covid-19', 'Laki-Laki', '2024-05-17', 'Tolak', 'naps'),
(11, '6471040000000019', 'Aghnia Nurhidayah', 'Bontang', 'Jalan Apa Kek', '089753457712', '2024-05-01', '2024-05-23', 'Kalimantan Timur', 'Kota Bontang', 'Influenza', 'Perempuan', '2024-05-17', 'Proses', 'nia'),
(17, '6571000000000000', 'Aprisa Idma Mutiara', 'Sangkulirang', 'Jalan Kenanga', '081234567899', '2004-04-29', '2024-05-22', 'Kalimantan Timur', 'Kab. Kutai Timur', 'Covid-19', 'Perempuan', '2024-05-17', 'Selesai', 'risa'),
(20, '6571000000000000', 'Aprisa Idma Mutiara', 'Sangkulirang', 'Jalan Merdeka', '081234567899', '2004-04-29', '2024-05-21', 'Kalimantan Timur', 'Kota Balikpapan', 'Polio', 'Perempuan', '2024-05-17', 'Selesai', 'risa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `regis_form`
--
ALTER TABLE `regis_form`
  ADD PRIMARY KEY (`id_regis`);

--
-- Indexes for table `vaccine_form`
--
ALTER TABLE `vaccine_form`
  ADD PRIMARY KEY (`id_form`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `regis_form`
--
ALTER TABLE `regis_form`
  MODIFY `id_regis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `vaccine_form`
--
ALTER TABLE `vaccine_form`
  MODIFY `id_form` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
