# Dot_Net_MinimalAPI_Demo

# Product API - Minimal CRUD Application

This is a **Minimal API** built with **.NET Core 6.0** for managing product data. The API supports CRUD (Create, Read, Update, Delete) operations and provides endpoints to interact with product details such as name, category, price, supplier, and more.

## Features

- Full CRUD operations for Products
- Minimal API design
- Swagger/OpenAPI documentation
- Repository pattern implementation
- Input validation
- Async/await operations

## Tech Stack

- .NET Core 6.0
- Swagger/OpenAPI

## Prerequisites

- .NET Core 6.0 SDK
- Visual Studio 2022 or VS Code

## Project Structure

```
Dot_Net_MinimalAPI_Demo/
├── Dot_Net_MinimalAPI_Demo/
|   ├── Endpoints/ 
|   |    └── ProductEndpoints.cs
|   ├── Helpers/ 
|   |    └── FormValidations.cs
|   |    └── Response.cs
|   |    └── SeedModelDatas.cs
|   ├── Interfaces/ 
|   |    └── IProductService.cs
|   ├── Models/
│   |    └── Product.cs
|   ├── Services/
│   |    └── ProductService.cs
|   ├── wwwroot/
│   |    └── swagger-custom.css
|   ├── appsettings-Develoment.json
|   ├── appsettings.json
|   ├── Program.cs
├── .gitignore
├── README.md
└── Dot_Net_MinimalAPI_Demo.sln
```

## Getting Started

1. Clone the repository:
```bash
git clone https://github.com/JenilSojitra/Dot_Net_MinimuAPI_Demo.git
cd Dot_Net_MinimalAPI_Demo
```

2. Build and run the project:
```bash
dotnet build
dotnet run --project Dot_Net_MinimalAPI_Demo
```

## API Endpoints

### Products

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET    | /api/products | Get all products |
| GET    | /api/products/{id} | Get product by ID |
| POST   | /api/products | Create new product |
| PUT    | /api/products | Update existing product |
| DELETE | /api/products/{id} | Delete product |

## Sample Request/Response

### Create Product

Request:
```json
POST /api/products
{
  "id": 0,
  "name": "Smartwatch",
  "description": "A stylish smartwatch with fitness tracking and notifications.",
  "category": "Electronics",
  "supplier": "TechTime Inc.",
  "barcode": "6543219876543",
  "material": "Stainless Steel, Silicone",
  "sizes": [],
  "purchasePrice": 120.00,
  "salesPrice": 199.99,
  "taxRate": 15.00,
  "currency": "USD"
}
```

Response:
```json
{
    "status": "success",
    "message": "Products added successfully...",
    "data": {
        "id": 1,
        "name": "Smartwatch",
        "description": "A stylish smartwatch with fitness tracking and notifications.",
        "category": "Electronics",
        "supplier": "TechTime Inc.",
        "barcode": "6543219876543",
        "material": "Stainless Steel, Silicone",
        "sizes": [],
        "purchasePrice": 120,
        "salesPrice": 199.99,
        "taxRate": 15,
        "currency": "USD"
    }
}
```

## Error Handling

The API uses standard returns error messages in the following format:

```json
{
  "status": "error",
  "message": "Please enter valid Product Name...",
  "data": null
}
```

## Testing

Run the unit tests:
```bash
dotnet test
```

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

