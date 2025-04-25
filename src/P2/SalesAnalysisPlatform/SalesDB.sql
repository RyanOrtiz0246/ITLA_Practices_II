CREATE TABLE Sales (
    Id NUMBER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    ProductName VARCHAR2(255) NOT NULL,
    Price NUMBER(10,2) NOT NULL,
    Quantity NUMBER NOT NULL,
    SaleDate DATE DEFAULT SYSDATE
);

CREATE TABLE Customers (
    Id NUMBER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    Name VARCHAR2(255) NOT NULL,
    Email VARCHAR2(100),
    Phone VARCHAR2(20),
    Address VARCHAR2(255)
);

INSERT INTO Customers (Name, Email, Phone, Address)
VALUES ('Ryan Ortiz Campos', 'ryan1423@gmail.com', '809-123-4567', 'Santo Domingo Este');

SELECT * FROM Customers;