-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 17, 2025 at 03:03 PM
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
-- Database: `chelseachill`
--

-- --------------------------------------------------------

--
-- Table structure for table `addinventory`
--

CREATE TABLE `addinventory` (
  `ProductID` int(100) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `Unit` varchar(50) NOT NULL,
  `Quantity` varchar(50) NOT NULL,
  `ExpirationDate` varchar(50) NOT NULL,
  `DateAdded` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `addinventory`
--

INSERT INTO `addinventory` (`ProductID`, `ProductName`, `Description`, `Category`, `Unit`, `Quantity`, `ExpirationDate`, `DateAdded`) VALUES
(1, 'Bun', 'Use for Burger', 'Food/Ingredients', 'pieces', '100', 'December 20, 2024', 'Thursday, 10 October 2024'),
(2, 'Patty', 'Use for Burger', 'Food/Ingredients', 'pieces', '41', 'November 16, 2024', 'Friday, 11 October 2024'),
(3, 'Cheese', 'Use for Burger', 'Food/Ingredients', 'pieces', '79', 'January 12, 2025', 'Friday, 11 October 2024'),
(4, 'Lettuce', 'Use for Burger', 'Food/Ingredients', 'pieces', '68', 'February 14, 2025', 'Sunday, 13 October 2024'),
(5, 'Dough', 'Use for Pizza', 'Food/Ingredients', 'grams', '120', 'December 21, 2024', 'Tuesday, 15 October 2024'),
(6, 'Meat', 'Use for Pizza', 'Food/Ingredients', 'grams', '295', 'October 30, 2024', 'Monday, 14 October 2024'),
(7, 'Pineapple', 'Use for Pizza Toppings', 'Food/Ingredients', 'grams', '90', 'December 30, 2024', 'Tuesday, 15 October 2024'),
(8, 'Tea', 'Use for Coffee', 'Drinks', 'grams', '160', 'November 13, 2024', 'Wednesday, 16 October 2024'),
(9, 'Milk', 'Use for Coffee', 'Drinks', 'grams', '210', 'November 13, 2025', 'Wednesday, 16 October 2024'),
(10, 'Sugar', 'Use for Coffee Sweeter', 'Food/Ingredients', 'grams', '100', 'January 12, 2024', 'Thursday, 17 October 2024'),
(11, 'Tapioca Pearls', 'Coffee Flavorings', 'Food/Ingredients', 'grams', '132', 'January 12, 2025', 'Thursday, 17 October 2024'),
(12, 'Chocolate Powder', 'Coffee Flavoring', 'Food/Ingredients', 'grams', '100', 'December 20, 2025', 'Tuesday, 15 October 2024'),
(13, 'Matcha Powder', 'Coffee Flavoring', 'Food/Ingredients', 'grams', '120', 'December 20, 2025', 'Tuesday, 15 October 2024'),
(14, 'Tempura', 'Appetizer', 'Food/Ingredients', 'kilograms', '100', 'November 13, 2025', 'Wednesday, 16 October 2024'),
(20, 'Taco burger', 'Use for burger', 'Food/Ingredients', 'pieces', '90', '2024-10-26 00:00:00', '2024-10-19 18:31:05.594918');

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `ID` int(100) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `Amount` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`ID`, `ProductName`, `Date`, `Amount`) VALUES
(1, 'Fries', '2024-10-20', 30),
(2, 'Kikiam', '2024-10-20', 25),
(3, 'Green Apple', '2024-10-20', 45),
(4, 'Blueberry', '2024-10-20', 45),
(5, 'Dirty Matcha', '2024-10-20', 85),
(6, 'Spanish Latte', '2024-10-20', 75),
(7, 'Coffee Latte', '2024-10-20', 75),
(8, 'Milktea - Chocolate', '2024-10-20', 60),
(9, 'Blue Lemonade', '2024-10-21', 45),
(10, 'Noodles', '2024-10-21', 35);

-- --------------------------------------------------------

--
-- Table structure for table `tblarcheiveproduct`
--

CREATE TABLE `tblarcheiveproduct` (
  `ProductID` int(20) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `ProductImage` longblob NOT NULL,
  `Ingredient1` varchar(255) NOT NULL,
  `Amount1` int(255) NOT NULL,
  `Ingredient2` varchar(255) NOT NULL,
  `Amount2` int(255) NOT NULL,
  `Ingredient3` varchar(255) NOT NULL,
  `Amount3` int(255) NOT NULL,
  `Ingredient4` varchar(255) NOT NULL,
  `Amount4` int(255) NOT NULL,
  `Ingredient5` varchar(255) NOT NULL,
  `Amount5` int(255) NOT NULL,
  `Ingredient6` varchar(255) NOT NULL,
  `Amount6` int(255) NOT NULL,
  `Ingredient7` varchar(255) NOT NULL,
  `Amount7` int(255) NOT NULL,
  `Ingredient8` varchar(255) NOT NULL,
  `Amount8` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblarcheiveproduct`
--

INSERT INTO `tblarcheiveproduct` (`ProductID`, `ProductName`, `Category`, `Price`, `ProductImage`, `Ingredient1`, `Amount1`, `Ingredient2`, `Amount2`, `Ingredient3`, `Amount3`, `Ingredient4`, `Amount4`, `Ingredient5`, `Amount5`, `Ingredient6`, `Amount6`, `Ingredient7`, `Amount7`, `Ingredient8`, `Amount8`) VALUES
(100001, 'Regular Burger', 'Main Dish', 35.00, 0x433a5c55736572735c557365725c446f776e6c6f6164735c4368656c736561204368696c6c2030325c4368656c736561204368696c6c2030325c4368656c736561204368696c6c2046494e414c5c5265736f75726365735c74685f5f315f2d72656d6f766562672d707265766965772e706e67, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(100002, 'Cheese Burger', 'Main Dish', 40.00, 0x433a5c55736572735c4c656e6f766f5c4f6e6544726976655c50696374757265735c4d656e75735c6368656573656275726765722e6a706567, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(100005, 'Soda', 'Beverages', 10.00, 0x433a5c55736572735c557365725c446f776e6c6f6164735c4368656c736561204368696c6c2030325c4368656c736561204368696c6c2030325c4368656c736561204368696c6c2046494e414c5c5265736f75726365735c3733363436302e706e67, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202410006, 'Ice Coffee', 'Beverages', 60.50, 0x433a5c55736572735c436174686572696e655c50696374757265735c4b696d69206e6f206e6177615c3734333438342e706e67, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440060, 'Noodles Soup', 'Noodles', 25.00, 0x433a5c55736572735c4c656e6f766f5c4f6e6544726976655c50696374757265735c4d656e75735c6e6f6f646c657320736f75702e6a7067, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440063, 'Japanese Siomai', 'Appetizer', 30.00, 0x433a5c55736572735c4c656e6f766f5c4f6e6544726976655c50696374757265735c4d656e75735c6a6170616e6573652073696f6d61692e6a7067, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440067, 'Cheese Burger', 'Main Dish', 40.00, 0x433a5c55736572735c4c656e6f766f5c4f6e6544726976655c50696374757265735c4d656e75735c6368656573656275726765722e6a706567, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblemployee`
--

CREATE TABLE `tblemployee` (
  `Name` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Contact` varchar(20) NOT NULL,
  `Position` varchar(30) NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Cnfrmpass` varchar(50) NOT NULL,
  `ID` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblemployee`
--

INSERT INTO `tblemployee` (`Name`, `Address`, `Contact`, `Position`, `Username`, `Password`, `Cnfrmpass`, `ID`) VALUES
('Francis Brian', 'Boulevard, Davao City', '2147483647', 'Manager', 'admin', 'admin', 'admin', 973043),
('Catherine Enero', 'Toril, Davao City', '09886373637', 'Assistant Manager', 'root', 'root', 'root', 973054),
('Alex Cruz', 'Talomo, Davao, City', '09773637363', 'Staff', 'user', 'user', 'user', 973058);

-- --------------------------------------------------------

--
-- Table structure for table `tblexpenses`
--

CREATE TABLE `tblexpenses` (
  `ExpenseID` int(20) NOT NULL,
  `ExpenseDate` varchar(50) NOT NULL,
  `TypeofTransaction` varchar(255) NOT NULL,
  `Amount` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblexpenses`
--

INSERT INTO `tblexpenses` (`ExpenseID`, `ExpenseDate`, `TypeofTransaction`, `Amount`) VALUES
(1, '2024-10-16 00:00:00', 'Water Expense', 401),
(2, '2024-10-14 00:00:00', 'Electricity Expense', 1200),
(3, '2024-10-15 00:00:00', 'Transportation', 351),
(5, '2024-10-19 00:00:00', 'water expences', 400);

-- --------------------------------------------------------

--
-- Table structure for table `tblpayments`
--

CREATE TABLE `tblpayments` (
  `ID` int(20) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `Amount` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblpayments`
--

INSERT INTO `tblpayments` (`ID`, `ProductName`, `Date`, `Amount`) VALUES
(1, '', '2024-10-14 22:20:50', '50.00'),
(2, '', '2024-10-14 22:21:11', '40.00'),
(3, '', '2024-10-14 23:44:29', '145.00'),
(4, '', '2024-10-15 11:24:25', '80.00'),
(5, '', '2024-10-15 11:28:39', '150.00'),
(6, '', '2024-10-15 11:32:44', '140.00'),
(7, '', '2024-10-15 11:34:33', '130.00'),
(8, '', '2024-10-15 11:38:54', '145.00'),
(9, '', '2024-10-15 11:41:55', '200.00'),
(10, '', '2024-10-15 11:47:09', '95.00'),
(11, '', '2024-10-15 11:48:43', '55.00'),
(12, '', '2024-10-15 12:12:16', '145.00'),
(13, '', '2024-10-15 12:13:07', '35.00'),
(14, '', '2024-10-15 13:19:11', '100.00'),
(15, '', '2024-10-15 13:25:34', '195.00'),
(16, '', '2024-10-15 13:26:08', '240.00'),
(17, '', '2024-10-15 13:59:55', '180.00'),
(18, '', '2024-10-15 14:55:18', '145.00'),
(19, '', '2024-10-17 04:39:10', '50.00'),
(20, '', '2024-10-17 04:59:38', '50.00'),
(21, '', '2024-10-17 09:07:25', '100.00'),
(22, '', '2024-10-17 09:09:14', '100.00'),
(23, '', '2024-10-17 09:21:50', '100.00'),
(24, '', '2024-10-17 09:23:05', '100.00'),
(25, '', '2024-10-17 09:25:35', '100.00'),
(26, '', '2024-10-17 09:34:52', '50.00'),
(27, '', '2024-10-17 09:36:04', '50.00'),
(28, '', '2024-10-17 09:37:08', '50.00'),
(29, '', '2024-10-17 09:38:19', '50.00'),
(30, '', '2024-10-17 09:42:08', '50.00'),
(31, '', '2024-10-18 05:18:23', '47.00'),
(32, '', '2024-10-18 05:20:21', '47.00'),
(33, '', '2024-10-18 07:43:25', '50.00'),
(34, '', '2024-10-19 18:37:26', '75.00'),
(35, '', '2024-10-19 18:39:54', '50.00'),
(36, 'Fries', '2024-10-20 15:59:00', '30.00'),
(37, 'Fries', '2024-10-20 15:59:09', '30.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblproducts`
--

CREATE TABLE `tblproducts` (
  `ProductID` int(225) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `Price` varchar(40) NOT NULL,
  `ProductImage` varchar(255) NOT NULL,
  `Ingredient1` varchar(255) NOT NULL,
  `Amount1` int(255) NOT NULL,
  `Ingredient2` varchar(255) NOT NULL,
  `Amount2` int(255) NOT NULL,
  `Ingredient3` varchar(255) NOT NULL,
  `Amount3` int(255) NOT NULL,
  `Ingredient4` varchar(255) NOT NULL,
  `Amount4` int(255) NOT NULL,
  `Ingredient5` varchar(255) NOT NULL,
  `Amount5` int(255) NOT NULL,
  `Ingredient6` varchar(255) NOT NULL,
  `Amount6` int(255) NOT NULL,
  `Ingredient7` varchar(255) NOT NULL,
  `Amount7` int(255) NOT NULL,
  `Ingredient8` varchar(255) NOT NULL,
  `Amount8` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblproducts`
--

INSERT INTO `tblproducts` (`ProductID`, `ProductName`, `Category`, `Price`, `ProductImage`, `Ingredient1`, `Amount1`, `Ingredient2`, `Amount2`, `Ingredient3`, `Amount3`, `Ingredient4`, `Amount4`, `Ingredient5`, `Amount5`, `Ingredient6`, `Amount6`, `Ingredient7`, `Amount7`, `Ingredient8`, `Amount8`) VALUES
(100003, 'Double Cheese Burger', 'Main Dish', '55.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\DoubleCheeseBurger.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(100004, 'Bacon Cheese Burger', 'Main Dish', '50.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\bacon cheeseburger.jpeg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440007, 'Regular Burger', 'Main Dish', '35.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\regular burger.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440008, 'Regular Sandwich', 'Main Dish', '50.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\regular sandwich.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440009, 'Sandwich with Lettuce', 'Main Dish', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\sandwich lettuce.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440010, 'Vegetarian', 'Main Dish', '120.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\pizza vegetarian.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440011, 'Bacon Delight', 'Main Dish', '130.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\bacon delight.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440012, 'Peperoni', 'Main Dish', '120.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\pizza pepperoni.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440013, 'Hawaiian', 'Main Dish', '120.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\pizza hawaiian.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440014, 'Beef Mushroom', 'Main Dish', '130.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\pizza beef mushroom.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440015, 'Ham & Cheese', 'Main Dish', '120.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\pizza ham and cheese.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440016, 'Green Apple', 'Beverages', '45.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\green applt.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440017, 'Blue Lemonade', 'Beverages', '45.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\blue lemonade.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440018, 'Strawberry', 'Beverages', '45.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\strawberry.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440019, 'Blueberry', 'Beverages', '45.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\blueberry.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440020, 'Lychee', 'Beverages', '45.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\lychee.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440021, 'IC - Chocolate', 'Beverages', '40.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\IC chocolate.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440022, 'IC - Ube', 'Beverages', '40.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\ube.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440023, 'IC - Buko Pandan', 'Beverages', '40.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\buko pandan.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440024, 'IC - Classic', 'Beverages', '40.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\classic.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440025, 'IC - Mango', 'Beverages', '40.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\mango.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440026, 'IC - Melon', 'Beverages', '40.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\melon.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440027, 'Milk Scramble', 'Beverages', '40.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\milk scramble.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440028, 'Sweet Americano', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\iced americano.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440029, 'Capuccino', 'Beverages', '80.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\capuccino.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440030, 'Spanish Latte', 'Beverages', '75.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\spanish latte.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440031, 'White Mocha', 'Beverages', '85.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\mocha.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440032, 'Salted Caramel Macchiato', 'Beverages', '85.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\caramel.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440033, 'Coffee Latte', 'Beverages', '75.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\latte.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440034, 'Matcha Latte', 'Beverages', '80.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\matcha.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440035, 'Matcha Float', 'Beverages', '85.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\matcha float.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440036, 'Dirty Matcha', 'Beverages', '85.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\dirty matcha.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440037, 'Matcha Berry', 'Beverages', '85.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\matcha berry.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440038, 'Blueberry Milk', 'Beverages', '80.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\blueberry milk.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440039, 'Strawberry Milk', 'Beverages', '80.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\strawberry milk.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440040, 'Choco Berry', 'Beverages', '85.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\choco berry.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440041, 'Milktea - Red velvet', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\red velvet.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440042, 'Milktea - Okinawa', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\okinawa.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440043, 'Milktea - Matcha', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\matcha.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440044, 'Milktea - Wintermelon', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\wintermelon.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440045, 'Milktea - Cookies & Cream', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\cookies and cream.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440046, 'Milktea - Dark Chocolate', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\dark choco.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440047, 'Milktea - Caramel Sugar', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\caramel sugar.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440048, 'Milktea - Taro', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\taro.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440049, 'Milktea - Hokaido', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\hokaido.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440050, 'Milktea - Dalgona', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\dalgona.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440051, 'Milktea - Chocolate', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\chocolate.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440052, 'Milktea - Hazelnut', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\hazelnut.jpeg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440053, 'Milktea - Mango Cheese', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\mango cheese.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440054, 'Milktea - Black Forest', 'Beverages', '60.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\black forest.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440055, 'Siomai', 'Appetizers', '25.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\siomai.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440056, 'Japanese Siomai', 'Appetizers', '30.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\japanese siomai.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440057, 'Kikiam', 'Appetizers', '25.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\kikiam.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440058, 'Tempura', 'Appetizers', '25.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\tempura.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440059, 'Fries', 'Appetizers', '30.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\fries.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440061, 'Siomai', 'Appetizers', '25.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\siomai.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440062, 'Siomai', 'Appetizer', '25.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\siomai.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440064, 'Kikiam', 'Appetizer', '25.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\kikiam.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440065, 'Tempura', 'Appetizer', '25.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\tempura.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440066, 'Fries', 'Appetizer', '30.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\fries.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440068, 'Noodles', 'Noodles', '35.00', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\noodles soup.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440088, 'chips', 'Appetizer', '10', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\ube.jpg', '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0),
(202440089, 'taco burger', 'Main Dish', '50', 'C:\\Users\\Lenovo\\OneDrive\\Pictures\\Menus\\DoubleCheeseBurger.jpg', 'Cheese', 1, 'Lettuce', 1, 'Patty', 1, '', 0, '', 0, '', 0, '', 0, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblsupplier`
--

CREATE TABLE `tblsupplier` (
  `ID` int(15) NOT NULL,
  `Name` varchar(70) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Contact` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblsupplier`
--

INSERT INTO `tblsupplier` (`ID`, `Name`, `Address`, `Contact`) VALUES
(8, 'Alice Guo ', 'Baliok, Davao City', '09737438361'),
(13, 'Alex Gonzaga', 'Matina, Davao City', '09637338883'),
(14, 'Kathryn Bernardo', 'Sandawa, Davao City', '09827882728');

-- --------------------------------------------------------

--
-- Table structure for table `tblunarchive`
--

CREATE TABLE `tblunarchive` (
  `ProductID` int(15) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `Unit` varchar(50) NOT NULL,
  `Quantity` varchar(15) NOT NULL,
  `ExpirationDate` varchar(100) NOT NULL,
  `DateAdded` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblunarchive`
--

INSERT INTO `tblunarchive` (`ProductID`, `ProductName`, `Description`, `Category`, `Unit`, `Quantity`, `ExpirationDate`, `DateAdded`) VALUES
(15, 'Kikiam', 'Appetizer', 'Food/Ingredients', 'kilograms', '40', 'December 8, 2024', 'Thursday, 17 October 2024'),
(16, 'Classic Fries', 'Appetizer', 'Food/Ingredients', 'kilograms', '80', 'January 31, 2026', 'Wednesday, 16 October 2024');

-- --------------------------------------------------------

--
-- Table structure for table `tblunarchiveexpenses`
--

CREATE TABLE `tblunarchiveexpenses` (
  `ExpenseID` int(20) NOT NULL,
  `ExpenseDate` varchar(255) NOT NULL,
  `TypeofTransaction` varchar(255) NOT NULL,
  `Amount` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblunarchiveexpenses`
--

INSERT INTO `tblunarchiveexpenses` (`ExpenseID`, `ExpenseDate`, `TypeofTransaction`, `Amount`) VALUES
(4, '2024-10-16 00:00:00', 'Water Expense', '401');

-- --------------------------------------------------------

--
-- Table structure for table `tblunarchivesupplier`
--

CREATE TABLE `tblunarchivesupplier` (
  `ID` int(20) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Contact` varchar(50) NOT NULL,
  `Remarks` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblunarchivesupplier`
--

INSERT INTO `tblunarchivesupplier` (`ID`, `Name`, `Address`, `Contact`, `Remarks`) VALUES
(10, 'Liza Soberano', 'Toril, Davao City', '097483673537', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addinventory`
--
ALTER TABLE `addinventory`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblarcheiveproduct`
--
ALTER TABLE `tblarcheiveproduct`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `tblemployee`
--
ALTER TABLE `tblemployee`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblexpenses`
--
ALTER TABLE `tblexpenses`
  ADD PRIMARY KEY (`ExpenseID`);

--
-- Indexes for table `tblpayments`
--
ALTER TABLE `tblpayments`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblproducts`
--
ALTER TABLE `tblproducts`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblunarchive`
--
ALTER TABLE `tblunarchive`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `tblunarchiveexpenses`
--
ALTER TABLE `tblunarchiveexpenses`
  ADD PRIMARY KEY (`ExpenseID`);

--
-- Indexes for table `tblunarchivesupplier`
--
ALTER TABLE `tblunarchivesupplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addinventory`
--
ALTER TABLE `addinventory`
  MODIFY `ProductID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3442;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tblarcheiveproduct`
--
ALTER TABLE `tblarcheiveproduct`
  MODIFY `ProductID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=202440068;

--
-- AUTO_INCREMENT for table `tblemployee`
--
ALTER TABLE `tblemployee`
  MODIFY `ID` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=973065;

--
-- AUTO_INCREMENT for table `tblexpenses`
--
ALTER TABLE `tblexpenses`
  MODIFY `ExpenseID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblpayments`
--
ALTER TABLE `tblpayments`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `tblproducts`
--
ALTER TABLE `tblproducts`
  MODIFY `ProductID` int(225) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=202440090;

--
-- AUTO_INCREMENT for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  MODIFY `ID` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tblunarchive`
--
ALTER TABLE `tblunarchive`
  MODIFY `ProductID` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3442;

--
-- AUTO_INCREMENT for table `tblunarchiveexpenses`
--
ALTER TABLE `tblunarchiveexpenses`
  MODIFY `ExpenseID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tblunarchivesupplier`
--
ALTER TABLE `tblunarchivesupplier`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
