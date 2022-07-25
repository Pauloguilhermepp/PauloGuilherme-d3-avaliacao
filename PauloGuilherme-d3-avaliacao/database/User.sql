-- Create data base
CREATE DATABASE IF NOT EXISTS PauloGuilherme_d3_avalicao;


-- Define which data base will be used
USE PauloGuilherme_d3_avalicao;


-- Create User table
CREATE TABLE IF NOT EXISTS User(
	UserId		        VARCHAR(255) NOT NULL UNIQUE,
	UserName			VARCHAR(255) NOT NULL,
	UserEmail	        VARCHAR(255) NOT NULL UNIQUE,
	UserPassword	    VARCHAR(255) NOT NULL
);


-- Add a register on the table
INSERT INTO User(UserId, UserName, UserEmail, UserPassword)
VALUES          ("12345", "AdminName", "admin@email.com", "$2a$10$PcXSYFynxh1fXzyZXdhUB.OjtgvSL1V8EbUi/P2/9Ujl2QCBjFeEO"),
				("23512", "AdminName1", "admin1@email.com", "$2a$10$l9q5xUE0sUpArkXeSGKZN./2R7VyuCP3VsqiRUeZnrV48VWAFJ2/y"),
				("53123", "AdminName2", "admin2@email.com", "$2a$10$DgjTk.0y8IT2dwz6XDk0QutQMr9jjVdmqSOTvdc0z2OzZrozBkvbW");