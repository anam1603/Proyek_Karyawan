-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2019 at 03:35 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_karyawan`
--

-- --------------------------------------------------------

--
-- Table structure for table `absen`
--

CREATE TABLE `absen` (
  `id_absen` varchar(20) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `jam_masuk` time NOT NULL,
  `jam_kerja` time NOT NULL,
  `tgl_kerja` date NOT NULL,
  `jam_pulang` time NOT NULL,
  `telat_masuk` varchar(20) NOT NULL,
  `jam_lembur` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `absen`
--

INSERT INTO `absen` (`id_absen`, `nik`, `jam_masuk`, `jam_kerja`, `tgl_kerja`, `jam_pulang`, `telat_masuk`, `jam_lembur`) VALUES
('000191214-193948', '0001', '19:39:48', '07:00:00', '2019-12-14', '17:00:00', '12:39:48', '02:39:48');

-- --------------------------------------------------------

--
-- Table structure for table `gaji`
--

CREATE TABLE `gaji` (
  `id_gaji` int(11) NOT NULL,
  `nomor_slip` varchar(15) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `tgl_gaji` date NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(40) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL,
  `tunjangan` decimal(8,0) NOT NULL,
  `lembur` decimal(8,0) NOT NULL,
  `pot_bpjs_kes` decimal(8,0) NOT NULL,
  `pot_bpjs_ket` decimal(8,0) NOT NULL,
  `pot_lain` decimal(8,0) NOT NULL,
  `no_rekening` varchar(40) NOT NULL,
  `nama_rekening` varchar(40) NOT NULL,
  `nama_bank` varchar(20) NOT NULL,
  `total_gaji` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gaji`
--

INSERT INTO `gaji` (`id_gaji`, `nomor_slip`, `nik`, `tgl_gaji`, `id_jabatan`, `nama_jabatan`, `gaji_pokok`, `tunjangan`, `lembur`, `pot_bpjs_kes`, `pot_bpjs_ket`, `pot_lain`, `no_rekening`, `nama_rekening`, `nama_bank`, `total_gaji`) VALUES
(2, 'SL191204-104224', '0002', '2019-12-19', 20, 'Manager', '9000000', '900000', '80000', '100000', '20000', '700000', '828012', 'Khairul Anam', 'BCA', '9160000'),
(5, 'SL191204-104224', '0002', '2019-12-19', 20, 'Manager', '9000000', '900000', '80000', '100000', '20000', '700000', '828012', 'Khairul Anam', 'BCA', '9160000'),
(6, 'SL191204-110208', '', '2019-12-04', 0, '', '0', '0', '0', '0', '0', '0', '', '', '', '0'),
(7, 'SL191204-110224', '12', '2019-12-04', 5, 'Kepala Divisi', '6000000', '222', '22', '2', '2', '2', '2', '22', '2', '6000238'),
(8, 'SL191204-110443', '12122', '2019-12-04', 17, 'Kepala Bagian', '10000000', '1', '1', '1', '1', '1', '11', '1', '1', '9999999');

-- --------------------------------------------------------

--
-- Table structure for table `jabatan`
--

CREATE TABLE `jabatan` (
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(40) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jabatan`
--

INSERT INTO `jabatan` (`id_jabatan`, `nama_jabatan`, `gaji_pokok`) VALUES
(5, 'Kepala Divisi', '6000000'),
(17, 'Kepala Bagian', '10000000'),
(20, 'Manager', '9000000'),
(21, 'CEO', '90000000');

-- --------------------------------------------------------

--
-- Table structure for table `lembur`
--

CREATE TABLE `lembur` (
  `id_lembur` int(10) NOT NULL,
  `nik` int(20) NOT NULL,
  `nama_karyawan` varchar(45) NOT NULL,
  `id_jabatan` int(11) NOT NULL,
  `tgl_lembur` date NOT NULL,
  `jml_lembur` int(2) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `ttl_uang_lembur` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `t_karyawan`
--

CREATE TABLE `t_karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(15) NOT NULL,
  `status` varchar(15) NOT NULL,
  `kewarganegaraan` varchar(3) NOT NULL,
  `no_hp` varchar(13) NOT NULL,
  `email` varchar(25) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `pendidikan_terakhir` varchar(4) NOT NULL,
  `pt_terakhir` varchar(40) NOT NULL,
  `id_jabatan` varchar(20) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `bagian` varchar(20) NOT NULL,
  `status_karyawan` varchar(15) NOT NULL,
  `status_kerja` varchar(15) NOT NULL,
  `gaji` varchar(10) NOT NULL,
  `nama_gambar` varchar(200) NOT NULL,
  `lokasi_gambar` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_karyawan`
--

INSERT INTO `t_karyawan` (`nik`, `nama`, `tempat_lahir`, `tgl_lahir`, `agama`, `status`, `kewarganegaraan`, `no_hp`, `email`, `alamat`, `pendidikan_terakhir`, `pt_terakhir`, `id_jabatan`, `tgl_masuk`, `bagian`, `status_karyawan`, `status_kerja`, `gaji`, `nama_gambar`, `lokasi_gambar`) VALUES
('0001', 'Ahmad Zailani', 'Sampit', '1990-12-09', 'Islam', 'Belum Menikah', 'WNI', '085211989097', 'zailani90@gmail.com', 'Jl. Warugo No. 15', 'S1', 'Universitas Airlangga', '17', '2009-02-14', 'Administrasi', 'TETAP', '10000000', 'AKTIF', '6da53c664f824f89ffedd78aff4c21ac.jpg', 'C:Users\\ASUS\\Downloads\\Documents\\6da53c664f824f89ffedd78aff4c21ac.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `absen`
--
ALTER TABLE `absen`
  ADD PRIMARY KEY (`id_absen`);

--
-- Indexes for table `gaji`
--
ALTER TABLE `gaji`
  ADD PRIMARY KEY (`id_gaji`);

--
-- Indexes for table `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`id_jabatan`);

--
-- Indexes for table `lembur`
--
ALTER TABLE `lembur`
  ADD PRIMARY KEY (`id_lembur`);

--
-- Indexes for table `t_karyawan`
--
ALTER TABLE `t_karyawan`
  ADD PRIMARY KEY (`nik`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gaji`
--
ALTER TABLE `gaji`
  MODIFY `id_gaji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `jabatan`
--
ALTER TABLE `jabatan`
  MODIFY `id_jabatan` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `lembur`
--
ALTER TABLE `lembur`
  MODIFY `id_lembur` int(10) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
