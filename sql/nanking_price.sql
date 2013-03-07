/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50610
Source Host           : localhost:3306
Source Database       : nanking_price

Target Server Type    : MYSQL
Target Server Version : 50610
File Encoding         : 65001

Date: 2013-03-07 20:54:59
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `district`
-- ----------------------------
DROP TABLE IF EXISTS `district`;
CREATE TABLE `district` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of district
-- ----------------------------
INSERT INTO `district` VALUES ('1', '南京市');
INSERT INTO `district` VALUES ('2', '玄武区');
INSERT INTO `district` VALUES ('3', '白下区');
INSERT INTO `district` VALUES ('4', '秦淮区');
INSERT INTO `district` VALUES ('5', '建邺区');
INSERT INTO `district` VALUES ('6', '鼓楼区');
INSERT INTO `district` VALUES ('7', '下关区');
INSERT INTO `district` VALUES ('8', '栖霞区');
INSERT INTO `district` VALUES ('9', '雨花台区');
INSERT INTO `district` VALUES ('10', '江宁区');
INSERT INTO `district` VALUES ('11', '浦口区');
INSERT INTO `district` VALUES ('12', '六合区');
INSERT INTO `district` VALUES ('13', '溧水县');
INSERT INTO `district` VALUES ('14', '高淳县');
INSERT INTO `district` VALUES ('15', null);

-- ----------------------------
-- Table structure for `get_log`
-- ----------------------------
DROP TABLE IF EXISTS `get_log`;
CREATE TABLE `get_log` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '采集序列，自增',
  `gain_url` varchar(300) DEFAULT NULL COMMENT '采集地址',
  `gain_id` varchar(20) DEFAULT NULL COMMENT '采集页面id',
  `type_id` int(11) DEFAULT NULL COMMENT '采集价格类型',
  `type_name` varchar(50) DEFAULT NULL COMMENT '采集价格类型名称',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of get_log
-- ----------------------------

-- ----------------------------
-- Table structure for `good_price`
-- ----------------------------
DROP TABLE IF EXISTS `good_price`;
CREATE TABLE `good_price` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '商品价格主键，自增',
  `type_id` int(11) DEFAULT NULL COMMENT '采集价格类型id',
  `type_name` varchar(50) DEFAULT NULL COMMENT '采集价格类型名称',
  `name` varchar(50) DEFAULT NULL COMMENT '商品名',
  `standard` varchar(10) DEFAULT NULL COMMENT '规格',
  `unit` varchar(10) DEFAULT NULL COMMENT '单位',
  `district_id` int(11) DEFAULT NULL COMMENT '所属区',
  `district_name` varchar(20) DEFAULT NULL COMMENT '行政区名',
  `market_id` int(11) DEFAULT NULL COMMENT '采集市场id',
  `market_name` varchar(50) DEFAULT NULL COMMENT '市场名称',
  `publish_time` date DEFAULT NULL COMMENT '发布时间',
  `get_time` datetime DEFAULT NULL COMMENT '采集时间',
  `get_url` varchar(300) DEFAULT NULL COMMENT '采集地址',
  `reserve1` varchar(500) DEFAULT NULL COMMENT '保留字段1',
  `reserve2` varchar(500) DEFAULT NULL COMMENT '保留字段2',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of good_price
-- ----------------------------

-- ----------------------------
-- Table structure for `market`
-- ----------------------------
DROP TABLE IF EXISTS `market`;
CREATE TABLE `market` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of market
-- ----------------------------

-- ----------------------------
-- Table structure for `sys_log`
-- ----------------------------
DROP TABLE IF EXISTS `sys_log`;
CREATE TABLE `sys_log` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '系统日志序列号，自增',
  `time` datetime DEFAULT NULL COMMENT '操作时间',
  `content` varchar(500) DEFAULT NULL COMMENT '操作内容',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sys_log
-- ----------------------------

-- ----------------------------
-- Table structure for `type`
-- ----------------------------
DROP TABLE IF EXISTS `type`;
CREATE TABLE `type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of type
-- ----------------------------
