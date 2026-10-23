// class BankAccount {
//     private _balance: number;

//     constructor(balance: number) {
//         this._balance = balance;
//     }

//     deposit(amount: number): void {
//         if (amount <= 0) {
//             console.log("Invalid deposit!");
//             return;
//         }

//         this._balance += amount;
//         console.log(`Deposit: ${amount}`);
//     }

//     withdraw(amount: number): void {
//         if (amount <= 0) {
//             console.log("Invalid withdrawal!");
//             return;
//         }

//         if (amount > this._balance) {
//             console.log("Insufficient balance!");
//             return;
//         }

//         this._balance -= amount;
//         console.log(`Withdraw: ${amount}`);
//     }

//     get balance(): number {
//         return this._balance;
//     }
// }

// const account = new BankAccount(1000);

// console.log(`Initial Balance: ${account.balance}`);
// account.deposit(500);
// account.withdraw(200);
// console.log(`Final Balance: ${account.balance}`);






// class Employee {
//     private _name: string;
//     private _salary: number;

//     constructor(name: string, salary: number) {
//         this._name = name;
//         this._salary = salary;
//     }

//     get name(): string {
//         return this._name;
//     }

//     get salary(): number {
//         return this._salary;
//     }

//     set salary(value: number) {
//         if (value <= 0) {
//             console.log("Invalid salary!");
//             return;
//         }

//         this._salary = value;
//     }
// }

// const employee = new Employee("Anu", 30000);

// console.log(`Employee: ${employee.name}`);
// console.log(`Salary: ${employee.salary}`);

// employee.salary = -5000;

// console.log(`Salary: ${employee.salary}`);




// class Mobile {
//     private _brand: string;
//     private _battery: number;

//     constructor(brand: string, battery: number) {
//         this._brand = brand;
//         this._battery = Math.max(0, Math.min(100, battery));
//     }

//     get brand(): string {
//         return this._brand;
//     }

//     get battery(): number {
//         return this._battery;
//     }

//     usePhone(): void {
//         this._battery = Math.max(0, this._battery - 10);
//     }

//     charge(): void {
//         this._battery = Math.min(100, this._battery + 20);
//     }
// }

// const mobile = new Mobile("Samsung", 80);

// console.log(`Brand: ${mobile.brand}`);
// console.log(`Battery: ${mobile.battery}`);

// mobile.usePhone();
// console.log(`After use: ${mobile.battery}`);

// mobile.charge();
// console.log(`After charging: ${mobile.battery}`);



// class Product {
//     private _productName: string;
//     private _quantity: number;

//     constructor(productName: string, quantity: number) {
//         this._productName = productName;
//         this._quantity = Math.max(0, quantity);
//     }

//     get productName(): string {
//         return this._productName;
//     }

//     get quantity(): number {
//         return this._quantity;
//     }

//     addStock(amount: number): void {
//         if (amount <= 0) {
//             console.log("Invalid stock amount!");
//             return;
//         }

//         this._quantity += amount;
//     }

//     sellStock(amount: number): void {
//         if (amount <= 0) {
//             console.log("Invalid selling amount!");
//             return;
//         }

//         if (amount > this._quantity) {
//             console.log("Insufficient stock!");
//             return;
//         }

//         this._quantity -= amount;
//     }
// }

// const product = new Product("Laptop", 10);

// console.log(`Product: ${product.productName}`);
// console.log(`Initial Stock: ${product.quantity}`);

// product.addStock(5);
// console.log(`After Adding Stock: ${product.quantity}`);

// product.sellStock(3);
// console.log(`After Selling: ${product.quantity}`);