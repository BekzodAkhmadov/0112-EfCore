# Entity Framework Core and Data

We've worked with all sorts of in-memory data storage, manipulation and retrieval up this point. Let's start working start with a database and write some content to disk. In .NET, we use Entity Framework Core to interact with relational database. While this isn't only way to that you can interact with a database, its the preferred way by many because of the ease of use of Entity Framework Core as an object-relational mapper to convert our objcet interactions into actions to take against database records.   

## The Setup

Let's create a console application as test-bed for interaction with database. Additionally,to ensure that these samples work on every platform and require no additional setup, we will use SQLite (a file-based database) to persist our data.

We can add EntityFramework Core to our project with these commands:

```powershell
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Sqlite


## Requirements

- .NET 8.0 SDK
- SQLite

## Setup Instructions

1. Clone the repository.
2. Install dependencies:

   ```bash
   dotnet restore
