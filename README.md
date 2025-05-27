# ToDoApi

Simple ASP.NET Core API to manage tasks (ToDo).

## Features

- List all tasks (GET /api/task)  
- Add a new task (POST /api/task)  
- Mark a task as done (PUT /api/task/{id}/done)  
- Delete a task (DELETE /api/task/{id})  

## Technologies used

- .NET 8  
- ASP.NET Core Web API  

## How to run the project

1. Clone the repository:  
   ```bash
   git clone https://github.com/yourusername/ToDoApi.git
Navigate to the project folder:

bash

cd ToDoApi
Run the project:

bash

dotnet run
Access the API using Postman or browser at:

bash

https://localhost:7275/api/task
How to test
In Postman, use the endpoints:

GET to list all tasks

POST to add a new task (send JSON in the body, example: { "title": "Your task" })

PUT to mark a task as done (URL: /api/task/{id}/done)

DELETE to remove a task (URL: /api/task/{id})

Made by Fellipe Garcia

