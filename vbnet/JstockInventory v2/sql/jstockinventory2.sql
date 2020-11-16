-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 12, 2017 at 05:59 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.5.37

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `jstockinventory2`
--

-- --------------------------------------------------------

--
-- Table structure for table `cfg_app`
--

CREATE TABLE `cfg_app` (
  `id` int(11) NOT NULL,
  `panjang_minimal_kode_barang` tinytext NOT NULL,
  `panjang_minimal_nama_barang` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cfg_app`
--

INSERT INTO `cfg_app` (`id`, `panjang_minimal_kode_barang`, `panjang_minimal_nama_barang`) VALUES
(1, '3', '3');

-- --------------------------------------------------------

--
-- Table structure for table `cfg_fitur`
--

CREATE TABLE `cfg_fitur` (
  `id` int(11) NOT NULL,
  `cfg_active_currency` tinytext NOT NULL,
  `cfg_active_wallpaper` tinytext NOT NULL,
  `enable_alur_kas` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cfg_fitur`
--

INSERT INTO `cfg_fitur` (`id`, `cfg_active_currency`, `cfg_active_wallpaper`, `enable_alur_kas`) VALUES
(1, 'Rupiah', 'main2.jpg', 'ya');

-- --------------------------------------------------------

--
-- Table structure for table `master_currency`
--

CREATE TABLE `master_currency` (
  `id` int(11) NOT NULL,
  `currency` tinytext NOT NULL,
  `to_rp` tinytext NOT NULL,
  `abbrv` tinytext NOT NULL,
  `last_update` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_currency`
--

INSERT INTO `master_currency` (`id`, `currency`, `to_rp`, `abbrv`, `last_update`) VALUES
(1, 'Rupiah', '1', 'Rp', ''),
(2, 'Dollar', '13300', '$', '');

-- --------------------------------------------------------

--
-- Table structure for table `master_customer`
--

CREATE TABLE `master_customer` (
  `id` int(11) NOT NULL,
  `nama` tinytext NOT NULL,
  `telpon` tinytext NOT NULL,
  `alamat` tinytext NOT NULL,
  `hp` tinytext NOT NULL,
  `email` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_customer`
--

INSERT INTO `master_customer` (`id`, `nama`, `telpon`, `alamat`, `hp`, `email`) VALUES
(1, 'anton', 'telp', 'alamat', '082227927747', 'email'),
(4, 'adam', 'telp', 'alamat', 'hp', 'em');

-- --------------------------------------------------------

--
-- Table structure for table `master_gudang`
--

CREATE TABLE `master_gudang` (
  `id` int(11) NOT NULL,
  `nama_gudang` tinytext NOT NULL,
  `lokasi_gudang` tinytext NOT NULL,
  `jumlah_total` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_gudang`
--

INSERT INTO `master_gudang` (`id`, `nama_gudang`, `lokasi_gudang`, `jumlah_total`) VALUES
(1, 'gudang a', 'blok a', '0'),
(2, 'gudang b', 'blok b', '0'),
(4, 'gudang z', 'blok z', '0'),
(5, 'gudang c', 'blok c', '0');

-- --------------------------------------------------------

--
-- Table structure for table `master_kas`
--

CREATE TABLE `master_kas` (
  `id` int(11) NOT NULL,
  `jumlah_kas` tinytext NOT NULL,
  `update_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_kas`
--

INSERT INTO `master_kas` (`id`, `jumlah_kas`, `update_date`) VALUES
(2, '46000000', '2017-10-11');

-- --------------------------------------------------------

--
-- Table structure for table `master_kategori_produk`
--

CREATE TABLE `master_kategori_produk` (
  `id` int(11) NOT NULL,
  `nama_kategori` tinytext NOT NULL,
  `keterangan` text NOT NULL,
  `jumlah_total` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_kategori_produk`
--

INSERT INTO `master_kategori_produk` (`id`, `nama_kategori`, `keterangan`, `jumlah_total`) VALUES
(1, 'Aktuator', 'pengerak untuk robot', '1000'),
(2, 'Sensor', 'Sensor robotika', '3000'),
(3, 'Robot Kit', 'kit robot', '1100');

-- --------------------------------------------------------

--
-- Table structure for table `master_merek`
--

CREATE TABLE `master_merek` (
  `id` int(11) NOT NULL,
  `merek` tinytext NOT NULL,
  `ket` text NOT NULL,
  `jumlah_total` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_merek`
--

INSERT INTO `master_merek` (`id`, `merek`, `ket`, `jumlah_total`) VALUES
(1, 'MBTECH', 'sarung jok kulit', '1'),
(2, 'TowerPro', 'servo', '20'),
(3, 'Hitec', 'servo high torquee', '100'),
(4, 'Sparkfun', 'komponen', '5'),
(5, 'Maxon', 'Maxon Motor', '10000'),
(6, 'Futaba', 'Futaba Motor', '0'),
(9, 'Traxxas', '', '1'),
(10, 'Hobby King', 'hobby king servo manufacturer', '1'),
(14, 'Baldor', 'Baldor motor dc manufacturer', '1000');

-- --------------------------------------------------------

--
-- Table structure for table `master_perusahaan`
--

CREATE TABLE `master_perusahaan` (
  `id` int(11) NOT NULL,
  `nama_perusahaan` tinytext NOT NULL,
  `alamat` tinytext NOT NULL,
  `telpon` tinytext NOT NULL,
  `fax` tinytext NOT NULL,
  `email` tinytext NOT NULL,
  `website` tinytext NOT NULL,
  `motto` tinytext NOT NULL,
  `npwp` tinytext NOT NULL,
  `logo` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_perusahaan`
--

INSERT INTO `master_perusahaan` (`id`, `nama_perusahaan`, `alamat`, `telpon`, `fax`, `email`, `website`, `motto`, `npwp`, `logo`) VALUES
(1, 'jasaplus', 'Jl. Omega 1 245 Karawaci', '02155761763', 'fax', 'jasapluscom@yahoo.com', 'http://www.jasaplus.com', 'We Develop App and Web', 'npwp', 'logo_small.png');

-- --------------------------------------------------------

--
-- Table structure for table `master_supplier`
--

CREATE TABLE `master_supplier` (
  `id` int(11) NOT NULL,
  `nama_perusahaan` tinytext NOT NULL,
  `alamat` tinytext NOT NULL,
  `contact_person` tinytext NOT NULL,
  `email` tinytext NOT NULL,
  `telp` tinytext NOT NULL,
  `fax` tinytext NOT NULL,
  `hp` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_supplier`
--

INSERT INTO `master_supplier` (`id`, `nama_perusahaan`, `alamat`, `contact_person`, `email`, `telp`, `fax`, `hp`) VALUES
(2, 'pt abc', 'alamat', 'anton', 'jasapluscom@yahoo.com', 'telp', '', 'hp'),
(3, 'pt xyz', 'alamat', 'contact', 'email', 'telp', 'fax', 'hp');

-- --------------------------------------------------------

--
-- Table structure for table `master_user`
--

CREATE TABLE `master_user` (
  `id` int(11) NOT NULL,
  `user` tinytext NOT NULL,
  `password` tinytext NOT NULL,
  `level` tinytext NOT NULL,
  `nama_lengkap` tinytext NOT NULL,
  `hp` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `master_user`
--

INSERT INTO `master_user` (`id`, `user`, `password`, `level`, `nama_lengkap`, `hp`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 'admin', 'nama', 'hp'),
(7, 'operator', '4b583376b2767b923c3e1da60d10de59', 'operator', 'nama op', 'hp op');

-- --------------------------------------------------------

--
-- Table structure for table `op_histori_kas`
--

CREATE TABLE `op_histori_kas` (
  `id` int(11) NOT NULL,
  `jumlah_kas` tinytext NOT NULL,
  `full_date` date NOT NULL,
  `mark` tinytext NOT NULL,
  `id_pembelian_atau_penjualan` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `op_histori_kas`
--

INSERT INTO `op_histori_kas` (`id`, `jumlah_kas`, `full_date`, `mark`, `id_pembelian_atau_penjualan`) VALUES
(2, '10000000', '2017-10-11', 'pembelian', '2'),
(3, '11000000', '2017-10-11', 'penjualan', '2'),
(4, '12000000', '2017-10-11', 'penjualan', '3'),
(5, '11000000', '2017-10-11', 'pembelian', '3'),
(6, '2000000', '2017-10-11', 'pembelian', '4'),
(7, '56000000', '2017-10-11', 'penjualan', '4'),
(8, '57000000', '2017-10-11', 'penjualan', '5'),
(9, '49000000', '2017-10-11', 'pembelian', '5'),
(10, '46000000', '2017-10-11', 'pembelian', '6');

-- --------------------------------------------------------

--
-- Table structure for table `op_histori_kas_flow`
--

CREATE TABLE `op_histori_kas_flow` (
  `id` int(11) NOT NULL,
  `jumlah_kas_masuk_atau_keluar` tinytext NOT NULL,
  `full_date` date NOT NULL,
  `mark` tinytext NOT NULL,
  `id_op_histori_kas` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `op_histori_kas_flow`
--

INSERT INTO `op_histori_kas_flow` (`id`, `jumlah_kas_masuk_atau_keluar`, `full_date`, `mark`, `id_op_histori_kas`) VALUES
(2, '30000000', '2017-10-11', 'pengeluaran', '2'),
(3, '1000000', '2017-10-11', 'pengeluaran', '5'),
(4, '9000000', '2017-10-11', 'pengeluaran', '6'),
(5, '54000000', '2017-10-11', 'pemasukan', '7'),
(6, '1000000', '2017-10-11', 'pemasukan', '8'),
(7, '8000000', '2017-10-11', 'pengeluaran', '9'),
(8, '3000000', '2017-10-11', 'pengeluaran', '10');

-- --------------------------------------------------------

--
-- Table structure for table `op_stok`
--

CREATE TABLE `op_stok` (
  `id` int(11) NOT NULL,
  `id_kategori` tinytext NOT NULL,
  `id_merek` tinytext NOT NULL,
  `kode` tinytext NOT NULL,
  `gambar` text NOT NULL,
  `nama_produk` tinytext NOT NULL,
  `harga` tinytext NOT NULL,
  `stok` tinytext NOT NULL,
  `id_gudang` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `op_stok`
--

INSERT INTO `op_stok` (`id`, `id_kategori`, `id_merek`, `kode`, `gambar`, `nama_produk`, `harga`, `stok`, `id_gudang`) VALUES
(2, '1', '3', 'kode001', 'servo9g1.jpg', 'servo 9g', '100000', '210', '1'),
(3, '1', '2', 'kode002', 'mg995.jpg', 'servo mg995', '100000', '100', '5'),
(4, '3', '3', 'kode003', '6dofarm.jpg', '6 DOF robot arm', '500000', '190', '2'),
(5, '1', '14', 'kode004', 'GPP12501.jpg', 'GPP12501', '800000', '100', '4'),
(6, '1', '14', 'kode005', 'GPP12560.jpg', 'GPP12560', '900000', '50', '4'),
(7, '1', '13', 'kode006', 'HV737_01-1200x1200.jpg', 'HV747', '200000', '100', '1'),
(8, '1', '-1', 'kode007', 'HV737_01-1200x1200.jpg', 'HV737', '300000', '200', '1'),
(9, '1', '6', 'kode008', 'DS6630_02-1200x1200.jpg', 'DS6630', '400000', '150', '1'),
(10, '1', '10', 'kode009', 'robokits_serv.jpg', 'Robokits High Torque Metal Gear Standard Digital Servo', '100000', '200', '1');

-- --------------------------------------------------------

--
-- Table structure for table `op_stok_adjustment`
--

CREATE TABLE `op_stok_adjustment` (
  `id` int(11) NOT NULL,
  `no_adjustment` tinytext NOT NULL,
  `tanggal` tinytext NOT NULL,
  `kode` tinytext NOT NULL,
  `nama_barang` tinytext NOT NULL,
  `gudang` tinytext NOT NULL,
  `jenis_adjustment` tinytext NOT NULL,
  `qty_fisik` tinytext NOT NULL,
  `qty_adjustment` tinytext NOT NULL,
  `keterangan` text NOT NULL,
  `bulan` tinytext NOT NULL,
  `tahun` tinytext NOT NULL,
  `full_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `op_stok_adjustment`
--

INSERT INTO `op_stok_adjustment` (`id`, `no_adjustment`, `tanggal`, `kode`, `nama_barang`, `gudang`, `jenis_adjustment`, `qty_fisik`, `qty_adjustment`, `keterangan`, `bulan`, `tahun`, `full_date`) VALUES
(1, 'adjust002', '04', 'kode005', 'GPP12560', 'gudang z', 'Kesalahan Perhitungan', '210', '10', 'salah hitung', '10', '2017', '2017-10-04');

-- --------------------------------------------------------

--
-- Table structure for table `op_stok_keluar`
--

CREATE TABLE `op_stok_keluar` (
  `id` int(11) NOT NULL,
  `kode` tinytext NOT NULL,
  `nama_produk` tinytext NOT NULL,
  `harga` tinytext NOT NULL,
  `jumlah` tinytext NOT NULL,
  `waktu` tinytext NOT NULL,
  `tanggal` tinytext NOT NULL,
  `bulan` tinytext NOT NULL,
  `tahun` tinytext NOT NULL,
  `mark` tinytext NOT NULL,
  `full_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `op_stok_keluar`
--

INSERT INTO `op_stok_keluar` (`id`, `kode`, `nama_produk`, `harga`, `jumlah`, `waktu`, `tanggal`, `bulan`, `tahun`, `mark`, `full_date`) VALUES
(1, 'kode009', 'Robokits High Torque Metal Gear Standard Digital Servo', '100000', '10', '20:42:04', '11', '10', '2017', 'penjualan', '2017-10-11'),
(2, 'kode009', 'Robokits High Torque Metal Gear Standard Digital Servo', '100000', '10', '20:42:21', '11', '10', '2017', 'penjualan', '2017-10-11'),
(3, 'kode009', 'Robokits High Torque Metal Gear Standard Digital Servo', '100000', '10', '20:42:32', '11', '10', '2017', 'penjualan', '2017-10-11'),
(4, 'kode005', 'GPP12560', '900000', '60', '20:52:53', '11', '10', '2017', 'penjualan', '2017-10-11'),
(5, 'kode009', 'Robokits High Torque Metal Gear Standard Digital Servo', '100000', '10', '20:53:53', '11', '10', '2017', 'penjualan', '2017-10-11');

-- --------------------------------------------------------

--
-- Table structure for table `op_stok_masuk`
--

CREATE TABLE `op_stok_masuk` (
  `id` int(11) NOT NULL,
  `kode` tinytext NOT NULL,
  `nama_produk` tinytext NOT NULL,
  `harga` tinytext NOT NULL,
  `jumlah` tinytext NOT NULL,
  `waktu` tinytext NOT NULL,
  `tanggal` tinytext NOT NULL,
  `bulan` tinytext NOT NULL,
  `tahun` tinytext NOT NULL,
  `mark` tinytext NOT NULL,
  `full_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `op_stok_masuk`
--

INSERT INTO `op_stok_masuk` (`id`, `kode`, `nama_produk`, `harga`, `jumlah`, `waktu`, `tanggal`, `bulan`, `tahun`, `mark`, `full_date`) VALUES
(3, 'kode009', 'Robokits High Torque Metal Gear Standard Digital Servo', '100000', '10', '20:49:23', '11', '10', '2017', 'pembelian', '2017-10-11'),
(4, 'kode005', 'GPP12560', '900000', '10', '20:51:00', '11', '10', '2017', 'pembelian', '2017-10-11'),
(5, 'kode004', 'GPP12501', '800000', '10', '20:54:48', '11/10/2017', '10', '2017', 'pembelian', '2017-10-11'),
(6, 'kode009', 'Robokits High Torque Metal Gear Standard Digital Servo', '100000', '30', '20:56:06', '11', '10', '2017', 'pembelian', '2017-10-11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cfg_app`
--
ALTER TABLE `cfg_app`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cfg_fitur`
--
ALTER TABLE `cfg_fitur`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_currency`
--
ALTER TABLE `master_currency`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_customer`
--
ALTER TABLE `master_customer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_gudang`
--
ALTER TABLE `master_gudang`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_kas`
--
ALTER TABLE `master_kas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_kategori_produk`
--
ALTER TABLE `master_kategori_produk`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_merek`
--
ALTER TABLE `master_merek`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_perusahaan`
--
ALTER TABLE `master_perusahaan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_supplier`
--
ALTER TABLE `master_supplier`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `master_user`
--
ALTER TABLE `master_user`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `op_histori_kas`
--
ALTER TABLE `op_histori_kas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `op_histori_kas_flow`
--
ALTER TABLE `op_histori_kas_flow`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `op_stok`
--
ALTER TABLE `op_stok`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `op_stok_adjustment`
--
ALTER TABLE `op_stok_adjustment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `op_stok_keluar`
--
ALTER TABLE `op_stok_keluar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `op_stok_masuk`
--
ALTER TABLE `op_stok_masuk`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cfg_app`
--
ALTER TABLE `cfg_app`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `cfg_fitur`
--
ALTER TABLE `cfg_fitur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `master_currency`
--
ALTER TABLE `master_currency`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `master_customer`
--
ALTER TABLE `master_customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `master_gudang`
--
ALTER TABLE `master_gudang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `master_kas`
--
ALTER TABLE `master_kas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `master_kategori_produk`
--
ALTER TABLE `master_kategori_produk`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `master_merek`
--
ALTER TABLE `master_merek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `master_perusahaan`
--
ALTER TABLE `master_perusahaan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `master_supplier`
--
ALTER TABLE `master_supplier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `master_user`
--
ALTER TABLE `master_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `op_histori_kas`
--
ALTER TABLE `op_histori_kas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `op_histori_kas_flow`
--
ALTER TABLE `op_histori_kas_flow`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `op_stok`
--
ALTER TABLE `op_stok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `op_stok_adjustment`
--
ALTER TABLE `op_stok_adjustment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `op_stok_keluar`
--
ALTER TABLE `op_stok_keluar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `op_stok_masuk`
--
ALTER TABLE `op_stok_masuk`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
