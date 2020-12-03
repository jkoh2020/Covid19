The Covid 19 Tracker allows users to enter, view, update, and delete Covid data. The program currently focuses on the Indianapolis metropolitan area featuring Marion county and it’s immediate surrounding counties. The program also features a few data points on Indiana as a whole, and the immediate surrounding states. 

The goal of this program is to aid users who need relevant Covid data in a quick and convenient package. 

GENERAL INSTRUCTIONS:

Clone the program and run the API. The API will then be accessible in your browser. Once the API is running you can access it in Postman or any other software you wish. Create a login and get a token and proceed to interact with the API.

TABLES:

The Covid 19 Tracker separates data into (4) tables. 

County Table: Contains the name of the county and the population of the county.
County Data Table: Contains Covid data points for counties.
State Table: Contains the name of the state and the population of the state.
State Data Tables: Contains Covid data points for counties. 

MODELS: 

County Edit:
    User can edit the County’s population figure.
Get Counties:
    User can get a list of Counties with data.
Get Counties Data:
    Get a particular County’s total list of data entries.
Get States:
    User can get a list of States with data.
Get States Data:
    Get a particular State’s total list of data entries.
Post County:
    Post a County and population.
Post County Data:
    Post data for a County. 
Post State:
    Post a State and population.
Post State Data:
    Post data for a State.
State Edit:
    Edit data for a State.

UNDERSTANDING THE DATA:

COUNTY DATA:

A County data table is comprised of the following properties:

DataId
    Primary Key for the County Data table
Date    
    Date that the data was entered into the system
CountyId         
    Id linking the data to the County
CountyName
    The name of the County
TodayTests
    How many Covid tests were done in the County today
TodayConfirmedCases
    How many Covid tests were positive in the County today
TodayDeaths
    How many Covid related deaths were in the County today
UserId
    The User who entered the Covid data
CreatedDate
    The time the user entered in the Covid data

COUNTY TABLE:

CountyId
    Primary Key for the County table
CountyName
    The name of the County
Population
    The population of the County
UserId
    The user who entered in the County
CreatedDate
    The data and time the user entered in the County
ModifiedDate
    The data and time the user edited the County

STATE DATA TABLE:

DataId
    Primary Key for the State Data table.
Date
    Date of the State Data
StateId
    Id of the State
StateName
    Name of the State
TodayTests
    The State’s number of Covid tests today
TodayConfirmedCases
    The State’s number of positive Covid tests today
TodayDeaths
    The State’s number of Covid deaths today
UserId
    The user who entered in the State Data
CreatedDate
    The time and date the user entered in the State Data

STATE TABLE: 

StateId
    Primary Key for the State Table
UserId
    The user who entered in the State
StateName
    The name of the State
Population
    The population of the State
CreatedDate
    The date and time the State was entered into the system
ModifiedDate
    The date and time the State was modified in the system

Updated Readme December 3rd 2020
