/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 50725
 Source Host           : localhost:3306
 Source Schema         : asset

 Target Server Type    : MySQL
 Target Server Version : 50725
 File Encoding         : 65001

 Date: 01/05/2020 22:37:22
*/

USE asset;

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for brand
-- ----------------------------
DROP TABLE IF EXISTS `brand`;
CREATE TABLE `brand` (
  `brand_id` int(11) NOT NULL AUTO_INCREMENT,
  `brand_code` varchar(20) DEFAULT NULL,
  `brand_name` varchar(20) DEFAULT NULL,
  `brand_state` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`brand_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of brand
-- ----------------------------
BEGIN;
INSERT INTO `brand` VALUES (1, '20181024', '耐克', 1, 1);
INSERT INTO `brand` VALUES (2, '20181024', '安踏', 1, NULL);
INSERT INTO `brand` VALUES (3, 'b201883534', '李宁', 1, NULL);
INSERT INTO `brand` VALUES (5, 'b1540618157115', '测试品牌', 2, NULL);
INSERT INTO `brand` VALUES (10, 'b1553389579727', '华为', 1, 5);
INSERT INTO `brand` VALUES (11, 'b1569982196219', '智取其', 1, 5);
INSERT INTO `brand` VALUES (12, 'b1570464297348', '联想', 1, 5);
COMMIT;

-- ----------------------------
-- Table structure for department
-- ----------------------------
DROP TABLE IF EXISTS `department`;
CREATE TABLE `department` (
  `department_id` int(11) NOT NULL AUTO_INCREMENT,
  `department_code` varchar(20) NOT NULL,
  `department_state` int(11) DEFAULT NULL,
  `department_name` varchar(20) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`department_id`,`department_code`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of department
-- ----------------------------
BEGIN;
INSERT INTO `department` VALUES (1, '10010', 1, '软件开发部', 1);
INSERT INTO `department` VALUES (2, '10011', 1, '产品销售部', NULL);
INSERT INTO `department` VALUES (3, '10012', 1, '软件测试部', NULL);
INSERT INTO `department` VALUES (4, '10013', 2, '资产管理部', NULL);
INSERT INTO `department` VALUES (6, '2333', 2, '测试部门', NULL);
INSERT INTO `department` VALUES (11, '432432521521545375', 1, '端茶倒水部', 5);
INSERT INTO `department` VALUES (12, 'd321475214643', 1, '后勤部', 5);
COMMIT;

-- ----------------------------
-- Table structure for locale
-- ----------------------------
DROP TABLE IF EXISTS `locale`;
CREATE TABLE `locale` (
  `locale_id` int(11) NOT NULL AUTO_INCREMENT,
  `locale_name` varchar(40) DEFAULT NULL,
  `locale_type` int(11) DEFAULT NULL,
  `locale_state` int(11) DEFAULT NULL,
  `locale_explain` varchar(80) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`locale_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of locale
-- ----------------------------
BEGIN;
INSERT INTO `locale` VALUES (1, '计算机外围设备', 1, 1, '一号仓库', 1);
INSERT INTO `locale` VALUES (2, '服务器采购商存储', 1, 1, '二号仓库', NULL);
INSERT INTO `locale` VALUES (3, '笔记本电脑一台', 2, 1, '三号仓库', NULL);
INSERT INTO `locale` VALUES (4, '测试地点', 1, 2, '测试测试', NULL);
INSERT INTO `locale` VALUES (8, '你家', 1, 1, '发多少', 5);
INSERT INTO `locale` VALUES (9, '山卡拉', 2, 1, '很好', 5);
COMMIT;

-- ----------------------------
-- Table structure for property
-- ----------------------------
DROP TABLE IF EXISTS `property`;
CREATE TABLE `property` (
  `property_id` int(11) NOT NULL AUTO_INCREMENT,
  `property_code` varchar(40) NOT NULL,
  `property_name` varchar(40) DEFAULT NULL,
  `property_date` varchar(40) DEFAULT NULL,
  `create_date` varchar(40) DEFAULT NULL,
  `locale_id` int(11) DEFAULT NULL,
  `supplier_id` int(11) DEFAULT NULL,
  `department_id` int(11) DEFAULT NULL,
  `property_state` int(11) DEFAULT NULL,
  `property_descr` varchar(100) DEFAULT '',
  `scrap_way` int(11) DEFAULT NULL,
  `pc_id` int(11) DEFAULT NULL,
  `brand_id` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`property_id`,`property_code`),
  KEY `locale_id` (`locale_id`),
  KEY `supplier_id` (`supplier_id`),
  KEY `department_id` (`department_id`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of property
-- ----------------------------
BEGIN;
INSERT INTO `property` VALUES (1, '20181023154636', '电脑显示屏', '2014-10-29', '2014-10-28', 1, 1, NULL, 4, '333', 2, 1, 2, NULL);
INSERT INTO `property` VALUES (7, '20181023155333', '哒哒233', '2014-10-26', '2018-10-25', 1, 5, 3, 2, '23333借用说明', NULL, 2, 3, 1);
INSERT INTO `property` VALUES (10, '20181027133130', '测试', '2018-10-30', '2018-10-26', 3, 5, 2, 2, '23333333333333333333333', NULL, 1, 1, NULL);
INSERT INTO `property` VALUES (23, '20181030182901', '333', NULL, '2018-10-29', 1, 1, NULL, 4, NULL, 3, 1, 1, NULL);
INSERT INTO `property` VALUES (24, '20181030182916', 'dsgggg', '2018-10-30', '2018-10-15', 1, 2, 2, 3, '32333333333', NULL, 2, 2, NULL);
INSERT INTO `property` VALUES (25, '20181030182925', '333', NULL, '2018-10-17', 2, 2, NULL, 1, NULL, NULL, 2, 1, NULL);
INSERT INTO `property` VALUES (26, '20181030184755', '343', NULL, '2018-10-30', 2, 2, NULL, 1, NULL, NULL, 2, 3, NULL);
INSERT INTO `property` VALUES (27, '20181030193003', '233', NULL, '2018-10-17', 1, 1, NULL, 1, NULL, NULL, 1, 3, NULL);
INSERT INTO `property` VALUES (28, '20181030193017', '666', NULL, '2018-10-18', 1, 2, NULL, 1, NULL, NULL, 1, 1, NULL);
INSERT INTO `property` VALUES (29, '20181030193107', '777', NULL, '2018-10-18', 2, 5, NULL, 1, NULL, NULL, 2, 2, NULL);
INSERT INTO `property` VALUES (30, '20181030193125', '888', NULL, '2018-10-10', 1, 1, NULL, 1, NULL, NULL, 1, 1, NULL);
INSERT INTO `property` VALUES (31, '20181030193143', '333', NULL, '2018-10-16', 1, 1, NULL, 1, NULL, NULL, 2, 2, NULL);
INSERT INTO `property` VALUES (32, '20181030193631', '5555555', NULL, '2018-10-10', 1, 1, NULL, 1, NULL, NULL, 1, 2, NULL);
INSERT INTO `property` VALUES (37, '20190324090647', '华为手机', '2019-10-2', '2019-03-26', 8, 10, 11, 2, 'fdsafasdf', NULL, 10, 10, 5);
INSERT INTO `property` VALUES (38, '20191008000743', '一台电脑', '2019-10-8', '2019-10-08', 9, 11, NULL, 3, '好的呀', NULL, 10, 12, 5);
INSERT INTO `property` VALUES (39, '20200429115659', '红米5plus', '2020-4-29', '2020-04-29', 8, 10, 11, 2, '借我用一天可以吗？？？', NULL, 11, 10, 5);
COMMIT;

-- ----------------------------
-- Table structure for property_class
-- ----------------------------
DROP TABLE IF EXISTS `property_class`;
CREATE TABLE `property_class` (
  `pc_id` int(11) NOT NULL AUTO_INCREMENT,
  `pc_code` varchar(20) DEFAULT NULL,
  `pc_name` varchar(20) DEFAULT NULL,
  `pc_state` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`pc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of property_class
-- ----------------------------
BEGIN;
INSERT INTO `property_class` VALUES (1, '20181024', '哒哒类别', 1, 1);
INSERT INTO `property_class` VALUES (2, '20181024', '小小个类别', 1, NULL);
INSERT INTO `property_class` VALUES (3, '20181025', '垃圾类别', 1, NULL);
INSERT INTO `property_class` VALUES (4, 'ac1540617753988', '测试类别', 2, NULL);
INSERT INTO `property_class` VALUES (10, 'ac1553389586265', '电脑类', 2, 5);
INSERT INTO `property_class` VALUES (11, 'ac1588132318788', '电视机', 1, 5);
COMMIT;

-- ----------------------------
-- Table structure for supplier
-- ----------------------------
DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
  `supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `supplier_apellation` varchar(80) DEFAULT NULL,
  `supplier_type` int(11) DEFAULT NULL,
  `supplier_state` int(11) DEFAULT NULL,
  `supplier_name` varchar(40) DEFAULT NULL,
  `supplier_phone` varchar(40) DEFAULT NULL,
  `supplier_address` varchar(40) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of supplier
-- ----------------------------
BEGIN;
INSERT INTO `supplier` VALUES (1, '服务器采购商', 1, 1, '王先生', '13542569845', '北京市海淀区', 1);
INSERT INTO `supplier` VALUES (2, '笔记本电脑采购商', 2, 1, '胡佳', '17878365395', '广西北海', NULL);
INSERT INTO `supplier` VALUES (5, '哒哒零件', 3, 1, '哒哒', '15234325435', '广西职业技术学院', NULL);
INSERT INTO `supplier` VALUES (6, '测试供应商', 3, 2, '测试联系人', '452354364364', '测试地址', NULL);
INSERT INTO `supplier` VALUES (10, '阿里巴巴', 1, 1, '哒哒', '13412354', '杭州', 5);
INSERT INTO `supplier` VALUES (11, '马化腾', 2, 2, '马化腾', '9527', '深圳腾讯公司', 5);
COMMIT;

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_alias` varchar(40) DEFAULT NULL,
  `user_name` varchar(40) DEFAULT NULL,
  `user_password` varchar(40) DEFAULT NULL,
  `user_code` varchar(40) DEFAULT NULL,
  `user_phone` varchar(40) DEFAULT NULL,
  `user_sex` varchar(20) DEFAULT NULL,
  `department_name` varchar(40) DEFAULT NULL,
  `user_job` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  KEY `department_id` (`department_name`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
BEGIN;
INSERT INTO `user` VALUES (5, '窃格瓦拉', 'user01', 'user01', '3333', '66666', '男', '端茶倒水部', '资产管理员');
INSERT INTO `user` VALUES (6, '', 'user02', 'user02', '', '', '', '', NULL);
COMMIT;

SET FOREIGN_KEY_CHECKS = 1;
