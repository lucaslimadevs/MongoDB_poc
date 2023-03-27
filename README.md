# ASP.NET Core API + MongoDB
Proof of Concept of a Web API, using MongoDB and Docker.

Simple API built using ASP.NET Core and MongoDB dockerized to demonstrate how to easily implement the MongoDB in .NET applications.

## Frameworks and Libraries

| :placard: showcase.Dev |     |
| -------------  | --- |
| :label: Back-End | [ASP.NET Core 6](https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-6.0), [MongoDB](https://www.mongodb.com/docs/atlas/) (for testing purposes)
| :rocket: API     | https://localhost:7096 
| :whale: API (Image)    | http://localhost:5000 
| :package: MongoDB (Image)   | mongodb://catalogdb:27017 
| :bookmark_tabs: Swagger Documentation   |  https://localhost:7096/swagger/index.html 
|                                          |  http://localhost:5000/swagger/index.html


## How to Test

Install Docker Desktop.

Run the following commands, in sequence, inside the application directory:

#### To create docker images:
```
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

#### To run API locally:
```
dotnet restore
dotnet run
```
