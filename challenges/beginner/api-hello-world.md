# Backend Challenge - Hello World API

## Introduction

The "Hello World API" challenge is designed to introduce beginners to backend development by creating a simple REST API that responds with a "Hello, World!" message when accessed via a specific endpoint.

## Objectives

- Set up a basic web server.
- Create a single endpoint that returns a "Hello, World!" message.
- Understand the basics of HTTP methods and status codes.

## Instructions

### Step-by-Step Guide

1. **Objective**: Your task is to develop a REST API that, when accessed via a specific endpoint, returns the message "Hello, World!".

2. **Environment Setup**: Choose your preferred programming language (e.g., JavaScript, Python, Java, C#) and set up the necessary environment.

3. **Implementation Details**: 
   - Use your chosen language's framework or libraries to create a web server.
   - Define a route or endpoint (`/`) that handles GET requests.
   - When the endpoint is accessed, the server should respond with the text "Hello, World!".

4. **Testing**: Test your API using a HTTP client (e.g., Postman, curl).
   - Send a GET request to `http://localhost:{port}/` (replace `{port}` with your server's port).
   - Verify that the response body contains "Hello, World!" and the HTTP status code is 200 (OK).

### Requirements

- Basic knowledge of your chosen programming language.
- Understanding of REST API principles (e.g., HTTP methods, status codes).

## Possible Improvements

After completing the basic "Hello World" API challenge, consider these improvements to enhance your API:

- **Personalized Greeting**: Add an endpoint that accepts a `name` parameter in the URL (`/hello/{name}`) and responds with a personalized greeting (e.g., "Hello, {name}!").
- **Error Handling**: Implement error handling to return appropriate HTTP status codes (e.g., 404 Not Found for invalid routes).
- **Logging**: Integrate logging to track API requests and responses for troubleshooting and monitoring purposes.
- **Unit Testing**: Write unit tests to validate the functionality of your API endpoints.
- **Documentation**: Provide clear documentation for your API endpoints using tools like Swagger or OpenAPI.

## Conclusion

By completing this challenge and exploring possible improvements, you will gain valuable experience in backend development practices and be better prepared for more complex API projects.

Happy coding!

## ✅ What I Did

- Implemented the project in **C#** using **ASP.NET Core Web API**.
- Used **Controllers** and **Swagger/OpenAPI** for clean endpoint structure and documentation.
- Set up the following endpoints:
  - `GET /` – Returns `"Hello, World!"`
  - `GET /hello/{name}` – Returns `"Hello, {name}!"` with error handling for empty or invalid names.
- Integrated **logging** to record all incoming requests and the response status.
- Automatically generates and serves interactive API documentation using **Swagger UI** in development mode.

---

## ▶️ How to Run

### Prerequisites

- [.NET SDK 8+](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022+ or Visual Studio Code

### Steps

1. **Clone the repository and switch to the correct branch**:
   ```bash
   git clone https://github.com/Khamull/backend-challenges.git
   cd backend-challenges
   git checkout hello-world
2. Restore dependencies and run the project:

dotnet restore
dotnet run
Access the API:

Visit http://localhost:5000/swagger for the Swagger UI.

Send requests to:

GET / → Returns "Hello, World!"

GET /hello/{name} → Returns "Hello, {name}!"
