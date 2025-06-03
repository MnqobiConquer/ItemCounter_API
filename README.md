# ItemCounter_API
📌 Count Items API
📝 Description
This ASP.NET Core Web API takes a list of items as input and returns a count of how many times each item appears.

🚀 Technologies Used
ASP.NET Core Web API

Swagger UI for API testing

Postman for additional request validation

📦 Installation & Setup
1️⃣ Clone the Repository
bash
git clone https://github.com/your-username/CountItemsAPI.git
cd CountItemsAPI
2️⃣ Build and Run
Open the project in Visual Studio and run the following command in the terminal:

bash
dotnet run
Alternatively, you can build and run the project manually:

bash
dotnet build
dotnet run
3️⃣ Access Swagger UI
Once the application is running, open Swagger UI in your browser:

https://localhost:7274/swagger/index.html
Swagger provides an interactive interface to test API endpoints.

📌 API Usage
🔍 Endpoint: Count Items
Method: POST

URL: /api/count

Request Body:

json
{
  "items": ["BMW", "Mercedes Benz", "Audi", 27, 67, 1, 0.55, 105, "BMW", "Mercedes Benz", "Audi", 27, 0.55, 105, "BMW", 27, 67, 1, 0.55, 105]
}
Response Example:

json
{
  "BMW": 3,
  "Mercedes Benz": 2,
  "Audi": 2,
  "27": 3,
  "67": 2,
  "1": 2,
  "0.55": 3,
  "105": 3
}
🛠 Testing with Postman
Open Postman.

Set request method to POST.

Use URL: https://localhost:7274/api/count

Go to Body ➝ Select raw ➝ Set type as JSON.

Paste the request payload.

Click Send to receive item counts.
