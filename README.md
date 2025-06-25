
This is a full-stack demo application built as part of a Zonda home assessment. 
It includes a React frontend and a .NET Web API backend.

## Features

- Select customers from a left sidebar dropdown
- View detailed customer information
- View, add, edit, and delete products per customer
- Layout using Material UI
- The uses of mock data, so no database setup is required.
- CORS is enabled to allow the frontend to connect to the API.
- Basic error handling such as duplicate product name validation.

### Backend (API)

1. Go to the `backend/ZondaTechAssesment/` folder.
2. Run the project in your IDE (Visual Studio / VS Code) or with:

dotnet run
The API should be running at http://localhost:5255.

## Frontend (React)
Go to frontend/zonda-ui/

Install dependencies:

npm install
Start the development server:

npm run dev
The app will be available at http://localhost:5173.

## Tech Stack
Frontend: React, Material UI, JavaScript
Backend: .NET 9 Web API, C#, Mock Services, Logging

## Use of AI Tools
During the development of this project, I leveraged AI tools to speed up certain tasks such as boilerplate generation, layout structuring, and code review suggestions. All implementation decisions, logic structure, and integration efforts were done by me, ensuring a full understanding and control over the final result.