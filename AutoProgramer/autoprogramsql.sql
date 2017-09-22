-- --------------------------------------------------------
-- 主机:                           127.0.0.1
-- 服务器版本:                        5.6.26 - MySQL Community Server (GPL)
-- 服务器操作系统:                      Win32
-- HeidiSQL 版本:                  9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- 导出 autoprogramerdb 的数据库结构
CREATE DATABASE IF NOT EXISTS `autoprogramerdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `autoprogramerdb`;


-- 导出  表 autoprogramerdb.fileimage 结构
CREATE TABLE IF NOT EXISTS `fileimage` (
  `hexname` varchar(200) NOT NULL,
  `image` mediumblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 数据导出被取消选择。


-- 导出  表 autoprogramerdb.isa3project 结构
CREATE TABLE IF NOT EXISTS `isa3project` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CreateTime` datetime NOT NULL,
  `Project` varchar(200) NOT NULL,
  `HexName` varchar(200) NOT NULL,
  `HexImage` mediumblob NOT NULL,
  `HexSize` bigint(20) NOT NULL,
  `HexCRC32` varchar(10) NOT NULL,
  `Barcode` varchar(100) DEFAULT NULL,
  `BarcodeEnable` tinyint(4) NOT NULL DEFAULT '0',
  `Manufacture` varchar(100) NOT NULL,
  `Fireware` varchar(100) NOT NULL,
  `ModelName` varchar(100) NOT NULL,
  `PCBNum` varchar(100) NOT NULL,
  `PartNum` varchar(100) NOT NULL,
  `CreaterName` varchar(200) DEFAULT NULL,
  `ProjectGroup` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Project`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 数据导出被取消选择。


-- 导出  表 autoprogramerdb.machine 结构
CREATE TABLE IF NOT EXISTS `machine` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CreatTime` datetime NOT NULL,
  `PCMachineName` varchar(50) NOT NULL,
  `Comment` varchar(100) NOT NULL,
  PRIMARY KEY (`PCMachineName`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 数据导出被取消选择。


-- 导出  表 autoprogramerdb.users 结构
CREATE TABLE IF NOT EXISTS `users` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CreatTime` datetime NOT NULL,
  `UserName` varchar(30) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `UserGroup` varchar(20) NOT NULL,
  `ProjectGroup` varchar(50) DEFAULT NULL,
  `Project` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`UserName`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 数据导出被取消选择。
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
