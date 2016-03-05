USE [master]
GO
CREATE DATABASE [HsbCmsManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HsbCmsManagement_data', FILENAME = N'D:\ProjectTfs_Hoang\GenericFramwork\Databases\HsbCmsManagement.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB)
 LOG ON 
( NAME = N'HsbCmsManagement_log', FILENAME = N'D:\ProjectTfs_Hoang\GenericFramwork\Databases\HsbCmsManagement.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO