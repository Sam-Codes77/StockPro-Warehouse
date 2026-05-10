-- 1. USERS TABLE
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL -- Admin, Manager, Logistics
);
-- 2. CATEGORY TABLE
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName VARCHAR(100) NOT NULL
);

-- 3. SUPPLIER TABLE
CREATE TABLE Supplier (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName VARCHAR(100) NOT NULL,
    ContactNumber VARCHAR(15),
    Email VARCHAR(100)
);

-- 4. PRODUCT TABLE
CREATE TABLE Product (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(100) NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID),
    SupplierID INT FOREIGN KEY REFERENCES Supplier(SupplierID),
    Price DECIMAL(18, 2),
    Quantity INT,
    LowStockThreshold INT
);

-- 5. ORDERS TABLE
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18, 2),
    PaymentStatus VARCHAR(20), 
    UserID INT FOREIGN KEY REFERENCES Users(UserID)
);

-- 6. ORDER_DETAILS TABLE
CREATE TABLE Order_Details (
    DetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
    ProductID INT FOREIGN KEY REFERENCES Product(ProductID),
    Quantity INT,
    UnitPrice DECIMAL(18, 2)
);

-- 7. REVIEWS TABLE
CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY IDENTITY(1,1),
    SupplierID INT FOREIGN KEY REFERENCES Supplier(SupplierID),
    Rating INT CHECK (Rating >= 1 AND Rating <= 5),
    Comments TEXT,
    ReviewDate DATETIME DEFAULT GETDATE()
);
