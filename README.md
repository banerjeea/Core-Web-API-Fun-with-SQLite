


# Tabcorp
## Ingredients used:
.Net Core SDK 1.0.0 preview2

Microsoft.EntityFrameworkCore.Sqlite 1.0.0

Microsoft.EntityFrameworkCore.Tools 1.0.0-preview2-final

Microsoft.EntityFrameworkCore.Design 1.0.0-preview2-final

## Design:
This .Net Core Web API application follows a blend of MVC(without the view) and Repository pattern, where repository class encapsulates data related work from Model and Controller objects. POCO has been used to define accepted data model. Application also makes sure objects are invoked through dependency injection via constructor injection. 
For persistent memory storage, SQLite was selected given its ease of use and lightweight nature. Entity Framework has been used to take advantage of migration to create database schema also to enhance security as we don’t need to parameterize queries here. Database is included in src\tabcorp\bin\Debug\netcoreapp1.0 .

## Git Branching Strategy:
In a real world scenario, I would follow ‘Git Flow’ model and develop on feature branches with pull requests to develop branch; but given the nature of this exercise, I have continuously developed on a single branch. 

## Example Reqest to API
### POST Endpoint: http://localhost:2497/api/meetings
### Request Body:
{
"meeting": {
"id": "9005",
"name": "Canterbury",
"state": "NSW",
"Date": "2017-09-01",
"races": [{
"id": "90051001",
"racenumber": "1",
"racename": "Australian Turf Club",
"starttime": "2017-09-01 10:45:00",
"endtime": "2017-09-01 11:00:00"
},
{
"id": "90051002",
"racenumber": "2",
"racename": "Tab Rewards Maiden Hcp",
"starttime": "2017-09-01 11:15:00",
"endtime": "2017-09-01 11:35:00"
},
{
"id": "90051003",
"racenumber": "3",
"racename": "Tab Rewards Maiden Hcp",
"starttime": "2017-09-01 15:05:00",
"endtime": "2017-09-01 15:20:00"
}]
}
}

### Expected Response:
HttpStatusCode : 200

"Data successfully added"

### GET Endpoint: http://localhost:2497/api/health
### Expected Response when Up :
{
    "version": {
        "major": 1,
        "minor": 1,
        "build": -1,
        "revision": -1,
        "majorRevision": -1,
        "minorRevision": -1
    },
    "content": null,
    "statusCode": 200,
    "reasonPhrase": "OK",
    "headers": [],
    "requestMessage": null,
    "isSuccessStatusCode": true
}
