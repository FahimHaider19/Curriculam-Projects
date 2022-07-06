-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: isp
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `creditcard`
--

DROP TABLE IF EXISTS `creditcard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `creditcard` (
  `cardnumber` varchar(20) NOT NULL,
  `pin` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`cardnumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creditcard`
--

LOCK TABLES `creditcard` WRITE;
/*!40000 ALTER TABLE `creditcard` DISABLE KEYS */;
INSERT INTO `creditcard` VALUES ('4065875204302003','123'),('4065875204426356','123'),('4065875204448277','123'),('4065875204458748','123'),('4065875204462377','123');
/*!40000 ALTER TABLE `creditcard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ip`
--

DROP TABLE IF EXISTS `ip`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ip` (
  `ipaddress` varchar(20) NOT NULL,
  `userid` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`ipaddress`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ip`
--

LOCK TABLES `ip` WRITE;
/*!40000 ALTER TABLE `ip` DISABLE KEYS */;
INSERT INTO `ip` VALUES ('109.31.244.73','11'),('124.164.60.165','3'),('15.182.158.33','5'),('152.98.225.82','7'),('17.86.161.125','1'),('198.29.10.114','6'),('227.195.139.112','4'),('233.183.68.112','8'),('242.149.239.29','9'),('91.43.219.56','2');
/*!40000 ALTER TABLE `ip` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `package`
--

DROP TABLE IF EXISTS `package`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `package` (
  `packageid` int NOT NULL AUTO_INCREMENT,
  `packagename` varchar(10) NOT NULL,
  `price` int NOT NULL,
  `speed` int NOT NULL,
  PRIMARY KEY (`packageid`)
) ENGINE=InnoDB AUTO_INCREMENT=7005 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `package`
--

LOCK TABLES `package` WRITE;
/*!40000 ALTER TABLE `package` DISABLE KEYS */;
INSERT INTO `package` VALUES (7001,'Gold',1000,40),(7002,'Platinum',1200,50),(7003,'Diamond',1500,60),(7004,'Sapphire',2000,80);
/*!40000 ALTER TABLE `package` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `paymentid` int NOT NULL AUTO_INCREMENT,
  `userid` int NOT NULL,
  `date` varchar(15) NOT NULL,
  `amount` int NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,2,'7/5/22',1500),(2,3,'1/6/22',1500),(3,2,'1/4/22',1500),(4,3,'05/07/2022',1500),(5,2,'05/07/2022',1500),(7,3,'06/07/2022',1000),(8,2,'06/07/2022',1000);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticket` (
  `ticketid` int NOT NULL AUTO_INCREMENT,
  `userid` int NOT NULL,
  `subject` varchar(25) NOT NULL,
  `description` varchar(2000) NOT NULL,
  `status` varchar(10) NOT NULL DEFAULT 'Pending',
  `empid` int DEFAULT NULL,
  PRIMARY KEY (`ticketid`)
) ENGINE=InnoDB AUTO_INCREMENT=6009 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES (6000,1,'Change IP','change my ip','Pending',NULL),(6001,2,'Speed Slow','speed is slow','Pending',NULL),(6003,3,'Change Package','change the package','Solved',NULL),(6004,4,'Router Problem','problem in router','Pending',NULL),(6005,1,'Change IP','please change my ip address','Solved',NULL),(6006,1,'internet issue','internet connection problem','Solved',NULL),(6007,1,'internet issue','internet connection problem','Solved',NULL),(6008,2,'internet issue','slow internet','Pending',NULL);
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fname` varchar(10) NOT NULL,
  `lname` varchar(10) NOT NULL,
  `email` varchar(25) NOT NULL,
  `password` varchar(50) NOT NULL,
  `usertype` varchar(10) NOT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `nid` varchar(15) DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  `packageid` int DEFAULT NULL,
  `connectionstatus` varchar(10) DEFAULT NULL,
  `status` varchar(10) NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Fahim','Haider','fhmhaider19@gmail.com','1234','Admin','01521572363','1234567890','22',NULL,NULL,'Active'),(2,'Sadman','Sakib','sadman9@gmail.com','1234','Customer','01232142523','9876543210','23',7001,'Active','Ban'),(3,'Asef','Iqbal','asef66@gmail.com','123456','Customer','01521796965',NULL,NULL,NULL,NULL,'Active'),(4,'Haider','Khan','haider909@gmail.com','9090','Customer','01912120989','3284891900','25',NULL,NULL,'Active'),(5,'Fahim','Alam','alam129@gmail.com','6969','Employee','01934990290','1009292849','26',NULL,NULL,'Active'),(6,'Shawon','Khan','swn69@gmail.com','9696','Employee','01778388378','3879382991','27',NULL,NULL,'Active'),(7,'Zishan','Ahmed','zishan85@gmail.com','0000','Customer','01982738928','6863723689','28',NULL,NULL,'Active'),(8,'Samin','Yasar','samin278@gmail.com','9028','Customer','01893298299','7393187987','29',NULL,NULL,'Active'),(9,'Nusrat','Maria','nusrat76@gmail.com','1868','Customer','01379789791','2981729769','30',NULL,NULL,'Active'),(10,'Oli','Mia','olimia87@gmail.com','1989','Customer','01972868781','2987656788','31',NULL,NULL,'Active'),(11,'Nisma','Hossain','nisma0@gmail.com','123456','Employee','01927823897',NULL,NULL,NULL,NULL,'Active'),(12,'sadman','sakib','sad@gmail.com','saqib5465','Customer','01716769494',NULL,NULL,NULL,NULL,'Active');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-06 23:54:54
