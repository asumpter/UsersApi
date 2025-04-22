# Users API

This project is an ASP.NET Core Web API for managing users. It provides endpoints to perform CRUD (Create, Read, Update, Delete) operations on user data.

## Project Structure

```
UsersApi
├── Controllers
│   └── UsersController.cs
├── Models
│   └── User.cs
├── Services
│   └── UserService.cs
├── Program.cs
├── Startup.cs
├── appsettings.json
└── README.md
```

## API Endpoints

### Users

- **GET /api/users**  
  Retrieves a list of all users.

- **GET /api/users/{id}**  
  Retrieves a user by their unique identifier.

- **POST /api/users**  
  Creates a new user.

- **PUT /api/users/{id}**  
  Updates an existing user by their unique identifier.

- **DELETE /api/users/{id}**  
  Deletes a user by their unique identifier.

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd UsersApi
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

5. Access the API at `http://localhost:5000/api/users`.

## Usage

You can use tools like Postman or curl to interact with the API endpoints. Make sure to set the appropriate HTTP method and headers (e.g., `Content-Type: application/json`) when making requests.