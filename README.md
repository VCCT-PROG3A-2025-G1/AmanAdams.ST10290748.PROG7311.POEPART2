🌱 AgriEnergy Connect

AgriEnergy Connect is an innovative online platform designed to bridge the gap between South Africa’s agricultural sector and renewable energy technology providers. Developed as a Minimum Viable Concept (MVC) using C# and .NET, the platform promotes sustainable agricultural practices by offering tools for both green energy adoption and agricultural product marketing.

🚀 Introduction

With the growing demand for environmentally conscious farming methods in South Africa, AgriEnergy Connect was developed to connect farmers with providers of renewable energy solutions. The platform empowers farmers to adopt sustainable practices while expanding their reach to customers through a digital product marketplace.

Key Features:

🌿 A Green Energy Marketplace tailored for agricultural needs

🧺 A Product Sales Platform where farmers can list and sell their produce



⚙️ Core Functionality

🔗 Database Integration

A relational database is used to store and manage information about farmers and their products.

(Sample data is populated to simulate real-world scenarios for demonstration purposes)

![Database](https://github.com/user-attachments/assets/9cabc26c-d85e-4ac5-a6f6-5a6147a902f1)


👥 User Roles & Authentication

The system supports two user roles, each with specific permissions:

Farmer	

- Add new products
  
- View their own product listings as well as other farmers products

  
Employee

- Create new farmer profiles
  
- View and filter all farmers' products based on criteria like date and type
  
- Secure login and authentication are implemented to control access and protect user data.


🧰 Functional Features

For Farmers:

-View other farmers products

-Add products with metadata such as:

 ->Name

 ->Category

 ->Production Date


For Employees:

-Create and manage farmer profiles

-Search and filter products across all farmers using:

 ->Date range
 
 ->Product category



🛠️ Setup Instructions

📋 Prerequisites

Visual Studio (latest recommended)

.NET Framework

Microsoft.EntityFrameworkCore NuGet package


📥 Cloning the Repository

https://github.com/VCCT-PROG3A-2025-G1/AmanAdams.ST10290748.PROG7311.POEPART2.git


🔧 Installing Dependencies

1- Open the project in Visual Studio.

2- Ensure all dependencies are installed (e.g., .NET, EF Core).

3- Update the appsettings.json file with your database connection string.

4- Run migrations to create the database


▶️ Building and Running the Prototype

1- Open the solution in Visual Studio.

2- Build the project (Build > Build Solution).

3- Run the application locally or deploy it to your hosting environment.


🚀 Get Started

To begin using AgriEnergy Connect, follow the Setup Instructions and Build and Run sections above.


🤝 Contributing

We welcome community contributions to improve and expand AgriEnergy Connect.

