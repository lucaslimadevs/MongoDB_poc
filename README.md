# ASP.NET Core API + MongoDB
Proof of Concept of a Web API, using MongoDB and Docker.

Simple API built using ASP.NET Core and MongoDB dockerized to demonstrate how to easily implement the MongoDB in .NET applications.

## Frameworks and Libraries
- [ASP.NET Core 6](https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-6.0);
- [MongoDB](https://www.mongodb.com/docs/atlas/) (for testing purposes);
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation).

## How to Test

Run the following commands, in sequence, inside the application directory:

```
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

```
dotnet restore
dotnet run
```
