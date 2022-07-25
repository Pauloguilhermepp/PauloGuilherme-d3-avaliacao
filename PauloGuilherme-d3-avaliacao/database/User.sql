-- Create data base
CREATE DATABASE IF NOT EXISTS PauloGuilherme_d3_avalicao;


-- Define which data base will be used
USE PauloGuilherme_d3_avalicao;


-- Create User table
CREATE TABLE IF NOT EXISTS User(
	UserId		        VARCHAR(255) NOT NULL UNIQUE,
	UserName			VARCHAR(255) NOT NULL UNIQUE,
	UserEmail	        VARCHAR(255) NOT NULL,
	UserPassword	    VARCHAR(12) NOT NULL
);


-- Add a register on the table
INSERT INTO User(UserId, UserName, UserEmail, UserPassword)
VALUES          ("12345", "AdminName", "admin@email.com", "admin123"),
				("23512", "AdminName1", "admin1@email.com", "admin1123"),
				("53123", "AdminName2", "admin2@email.com", "admin2123");