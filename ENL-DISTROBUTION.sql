CREATE TABLE PLocation (
    PLocationID INT PRIMARY KEY IDENTITY(1,1),
    PShelf INT NOT NULL,
    PRow INT NOT NULL
);
CREATE TABLE Products (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Amount INT NOT NULL,
    ProductName NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    PLocationID INT NOT NULL,
    FOREIGN KEY (PLocationID) REFERENCES PLocation(PLocationID)
);

CREATE TABLE Employees (
    WorkerID INT PRIMARY KEY IDENTITY(1,1),
    Amount INT NOT NULL,
	WStatus INT NOT NULL,
    Tlf NVARCHAR(20) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Jobtitel NVARCHAR(255) NOT NULL
);

CREATE TABLE Orders (
    OrdersID INT PRIMARY KEY IDENTITY(1,1),
    OrderAmount INT NOT NULL,
	NProduct NVARCHAR(255) NOT NULL,
    WName NVARCHAR(100) NOT NULL,
	WStatus INT NOT NULL,
    ProductID INT NOT NULL,
    WorkerID INT NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ID),
    FOREIGN KEY (WorkerID) REFERENCES Employees(WorkerID)
);
INSERT INTO Users (UserName, PasswordHash)
VALUES ('john doe', 'Password1234');