# Resume
The goal of this project was to develop a simple application to control the user access to a system to solve the activity of the third discipline of the CTEDS course. More details about it can be found here.

# About the implementation
As the DBMS was not specified, it was used MySQL to store users' data. As the timezone was also not specified, the UTC time was used to store the time that the users accessed the system and the date was saved in the mm/dd/yyyy model. The secondary goals, hashing passwords and saving the moment the user leaves the system, were also implemented.

# How to use
The process to run this system is very simple. First, it is necessary to run the SQL file found in PauloGuilherme-d3-avalicao/database/User.sql. Now it is necessary to adjust the connection string in the PauloGuilherme-d3-avalicao/Repositories/UserAccess.cs file to work properly on your machine. After it,just run the C# application in PauloGuilherme-d3-avalicao/. The information about users' access will be available in PauloGuilherme-d3-avalicao/UserAccessLogs/UserAccess.csv.