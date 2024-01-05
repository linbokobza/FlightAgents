# Flight Booking web 🛫
Welcome to the Flight Booking web! This project simplifies the management of flight bookings. 

![image](https://github.com/linbokobza/FlightAgents/assets/69593176/4d43e53e-c74f-4803-9ef1-818c8cce13b7)

![image](https://github.com/linbokobza/FlightAgents/assets/69593176/498ac83b-4798-493a-83fc-334bffab64a5)

![image](https://github.com/linbokobza/FlightAgents/assets/69593176/be23e079-4f66-4615-a183-e61996542b39)

Follow the steps below to set up and run the app locally:
## Setup Instructions

### 1. Database Configuration

Open **Microsoft SQL Server** and execute the following SQL script to create the necessary tables:

```sql
USE tempdb;

CREATE TABLE tblFlightBooking (
    BookingId INT PRIMARY KEY,
    FlightId INT,
    NumOfTickets INT
);

CREATE TABLE tblFlight (
    FlightId INT PRIMARY KEY,
    FlightCompanyName NVARCHAR(20),
    SeatingCapacity INT,
    Departures NVARCHAR(20),
    Arrivals NVARCHAR(20),
    DeparturesDate DATE,
    DeparturesTime NVARCHAR(20),
    ArrivalDate DATE,
    ArrivalTime NVARCHAR(20),
    Price INT
);

CREATE TABLE tblUsers (
    IsAdmin NVARCHAR(2),
    FirstName NVARCHAR(20),
    LastName NVARCHAR(20),
    Email NVARCHAR(40) PRIMARY KEY,
    Password NVARCHAR(30)
);

CREATE TABLE tblCreditCard (
    FullName NVARCHAR(40),
    ID NVARCHAR(9),
    CardNumber NVARCHAR(16),
    CardExp NVARCHAR(7),
    CVV NVARCHAR(3),
    PRIMARY KEY (FullName, ID)
);

```
### 2. Add Sample Flights

To get started, insert some sample flights into the `tblFlight` table:

```sql
-- ✈️ Sample Flights
INSERT INTO tblFlight VALUES (15, 'Arkia', 255, 'Turkey', 'USA', '7/13/2023', '11:30', '7/13/2023', '18:50', 2150);
-- Add more flights as needed
```

### 3. Open the Project in Visual Studio

🚀 Launch Visual Studio and open the Flight Booking Application project.

### 4. Connect Database to the Project

🔗 Connect your project to the database by configuring the connection string in the `web.config` file.

### 5. Run the Project

🚀 Hit F5 or use the "Run" command to start the Flight Booking App. Enjoy managing your flights effortlessly!

# ✈️ Happy Flying! ✈️
