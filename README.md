# StockPro: Integrated Warehouse Logistics & Payment Management System

StockPro is a robust desktop application designed to solve the inefficiencies of manual, paper-based ledger systems in large-scale warehouses.


## Case Study:
Apex Central Warehouse currently faces "stock-outs," a lack of accountability, and lost revenue due to manual tracking errors. StockPro solves this with real-time tracking, automated low-stock alerts, and integrated financial processing.

# Key Functional Requirements:
## 1. User Roles & Authentication
Admin (Warehouse Director): Manages accounts, configures thresholds, and oversees financial history.
Inventory Manager:Adds products, adjusts stock, and evaluates suppliers.
Logistics/Sales Staff: Processes outbound orders and handles payments.

## 2. Core Features:
Low Stock Alerts:Automatically highlights items below a set threshold.
Payment Gateway: Secure client payment processing within the desktop app.
Supplier Review System: 1-to-5 star rating system for supply chain quality.

---

# Technical Architecture:
## Database Schema:
The system uses a 3rd Normal Form (3NF) database design consisting of 7 tables to ensure data integrity.
* `Users`, `Supplier`, `Category`, `Product`, `Orders`, `Order_Details`, and `Reviews`. 

### ER Diagram
![ER Diagram](ER_diagram.png)

## User Interface Preview
| Login Screen | Admin Dashboard |
| :--- | :--- |
![Login](login.png) ![Dashboard](Admin_dashboard.png)

| Product Management | Payment Gateway |
| :--- | :--- |
![Products](product_management.png) | ![Payments](payment_gateway.png)

| Category Management | Supplier Management |
| :--- | :--- |
![Categories](category_managemnet.png) | ![Suppliers](supplier_managemnet.png)

| Reviews | 
| :--- | :--- |
!![Reviews](reviews.png)


---

