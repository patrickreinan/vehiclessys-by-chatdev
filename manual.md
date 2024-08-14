# Vehicle API User Manual

## Introduction

The Vehicle API is a C# application that provides functionality to insert, update, retrieve, and delete vehicles. It is designed to be used as an API, allowing other applications to interact with the vehicle repository.

## Installation

To use the Vehicle API, you need to have the following dependencies installed:

- .NET Core SDK (version 3.1 or later)
- Visual Studio or any other C# IDE

To install the dependencies:

1. Download and install the .NET Core SDK from the official Microsoft website: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Install Visual Studio or any other C# IDE of your choice.

## Getting Started

To get started with the Vehicle API, follow these steps:

1. Clone or download the code from the repository.
2. Open the solution file (`VehicleApi.sln`) in Visual Studio.
3. Build the solution to restore the NuGet packages and compile the code.
4. Run the application.

## API Endpoints

The Vehicle API provides the following endpoints:

### Insert a Vehicle

- Method: `POST`
- URL: `/api/vehicles`
- Request Body: JSON object representing the vehicle to be inserted. The object should have the following properties:
  - `name` (string): The name of the vehicle.
  - `brand` (string): The brand of the vehicle.
  - `year` (integer): The year of the vehicle.
  - `id` (UUID): The unique identifier of the vehicle.

Example Request Body:

```json
{
  "name": "Car",
  "brand": "Toyota",
  "year": 2020,
  "id": "123e4567-e89b-12d3-a456-426614174000"
}
```

### Update a Vehicle

- Method: `PUT`
- URL: `/api/vehicles/{id}`
- Request Body: JSON object representing the updated vehicle. The object should have the following properties:
  - `name` (string): The updated name of the vehicle.
  - `brand` (string): The updated brand of the vehicle.
  - `year` (integer): The updated year of the vehicle.

Example Request Body:

```json
{
  "name": "Car",
  "brand": "Toyota",
  "year": 2021
}
```

### Get a Vehicle

- Method: `GET`
- URL: `/api/vehicles/{id}`

### Delete a Vehicle

- Method: `DELETE`
- URL: `/api/vehicles/{id}`

## Example Usage

Here is an example of how to use the Vehicle API using cURL:

1. Insert a vehicle:

```bash
curl -X POST -H "Content-Type: application/json" -d '{
  "name": "Car",
  "brand": "Toyota",
  "year": 2020,
  "id": "123e4567-e89b-12d3-a456-426614174000"
}' http://localhost:5000/api/vehicles
```

2. Update the vehicle:

```bash
curl -X PUT -H "Content-Type: application/json" -d '{
  "name": "Car",
  "brand": "Toyota",
  "year": 2021
}' http://localhost:5000/api/vehicles/123e4567-e89b-12d3-a456-426614174000
```

3. Get the vehicle:

```bash
curl http://localhost:5000/api/vehicles/123e4567-e89b-12d3-a456-426614174000
```

4. Delete the vehicle:

```bash
curl -X DELETE http://localhost:5000/api/vehicles/123e4567-e89b-12d3-a456-426614174000
```

## Conclusion

The Vehicle API provides a simple and efficient way to manage vehicles through a RESTful API. By following the user manual, you can easily integrate the API into your applications and perform CRUD operations on vehicles. If you have any further questions or need assistance, please refer to the documentation or contact our support team.