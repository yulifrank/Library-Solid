# Library Management System

A library management system built with C# and ASP.NET Core. The system allows for the management of books, loans, and members through an API interface.

## Key Features

- **Books**: Manage books - add, update, delete, and retrieve.
- **Loans**: Manage loans - add, update, delete, and retrieve.
- **Members**: Manage members - add, update, delete, and retrieve.
- **Authentication**: User authentication using JWT.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- AutoMapper
- JWT Authentication
- Swagger/OpenAPI

## Installation

1. Clone the repository to your local machine:

    ```sh
    git clone https://github.com/yulifrank/library-management-system.git
    ```

2. Navigate to the project directory:

    ```sh
    cd library-management-system
    ```

3. Install dependencies:

    ```sh
    dotnet restore
    ```

4. Update the `appsettings.json` file with your own values:

    ```json
    {
      "JWT": {
        "Key": "your_secret_key_here",
        "Issuer": "your_issuer",
        "Audience": "your_audience"
      },
      "ConnectionStrings": {
        "DefaultConnection": "your_connection_string_here"
      }
    }
    ```

## Usage

1. Run the application:

    ```sh
    dotnet run
    ```

2. The API will be available at: `https://localhost:5001`.

3. Use the Swagger UI to test the API at: `https://localhost:5001/swagger`.

## API Examples

### Books

- **Get all books**

    ```http
    GET /api/books
    ```

- **Get book by ID**

    ```http
    GET /api/books/{id}
    ```

- **Add a new book**

    ```http
    POST /api/books
    Content-Type: application/json

    {
      "name": "Book Name",
      "numberOfPages": 200
    }
    ```

- **Update a book**

    ```http
    PUT /api/books/{id}
    Content-Type: application/json

    {
      "bookId": 1,
      "name": "Updated Book Name",
      "numberOfPages": 250
    }
    ```

- **Delete a book**

    ```http
    DELETE /api/books/{id}
    ```

### Loans

- **Get all loans**

    ```http
    GET /api/loans
    ```

- **Get loan by ID**

    ```http
    GET /api/loans/{id}
    ```

- **Add a new loan**

    ```http
    POST /api/loans
    Content-Type: application/json

    {
      "date": "2023-05-01",
      "memberId": 1,
      "name": "Loan Name"
    }
    ```

- **Update a loan**

    ```http
    PUT /api/loans/{id}
    Content-Type: application/json

    {
      "id": 1,
      "date": "2023-05-01",
      "memberId": 1,
      "name": "Updated Loan Name"
    }
    ```

- **Delete a loan**

    ```http
    DELETE /api/loans/{id}
    ```

### Members

- **Get all members**

    ```http
    GET /api/members
    ```

- **Get member by ID**

    ```http
    GET /api/members/{id}
    ```

- **Add a new member**

    ```http
    POST /api/members
    Content-Type: application/json

    {
      "age": 30,
      "name": "Member Name"
    }
    ```

- **Update a member**

    ```http
    PUT /api/members/{id}
    Content-Type: application/json

    {
      "id": 1,
      "age": 31,
      "name": "Updated Member Name"
    }
    ```

- **Delete a member**

    ```http
    DELETE /api/members/{id}
    ```

### Authentication

- **Login**

    ```http
    POST /api/auth
    Content-Type: application/json

    {
      "userName": "user",
      "password": "password"
    }
    ```

## Authors

Yael Frank

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
