class BankAccount{
    private balance: number = 1000;
    getBalance(): number{
        return this.balance;
    }
    deposit(amount:number):void{
        if (amount > 0){
            this.balance += amount;
        }
    }
    withdraw(amount:number):void{
          if (amount > 0 && amount <= this.balance) {
            this.balance -= amount;
    }
}
}
let b = new BankAccount();

console.log("Initial:", b.getBalance());
b.deposit(500);
b.withdraw(200);
console.log("Final:", b.getBalance());

class Employee{
    private salary: number = 30000;
get getSalary(): number{
    return this.salary;
}
set setSalary(value: number){
    if (value > 0){
        this.salary = value;
    }
    else{
        console.log("Invalid salary");
    }
}
}

let e = new Employee();

console.log(e.getSalary);
e.setSalary = -5000;
console.log(e.getSalary);


class Mobile {
    private battery: number = 80;

    usePhone(): void {
        this.battery -= 10;
    }

    charge(): void {
        this.battery = Math.min(100, this.battery + 20);
    }

    getBattery(): number {
        return this.battery;
    }
}

let m = new Mobile();

console.log("Battery:", m.getBattery());
m.usePhone();
console.log("After use:", m.getBattery());
m.charge();
console.log("After charge:", m.getBattery());


class Products {
    private quantity: number = 10;

    addStock(amount: number): void {
        if (amount > 0) {
            this.quantity += amount;
        }
    }

    sellStock(amount: number): void {
        if (amount > 0 && amount <= this.quantity) {
            this.quantity -= amount;
        }
    }

    getQuantity(): number {
        return this.quantity;
    }
}

let p = new Products();

console.log("Initial:", p.getQuantity());
p.addStock(5);
console.log("After adding:", p.getQuantity());
p.sellStock(3);
console.log("After selling:", p.getQuantity());

// POLYMORPHISAM

class Employees {
    calculateSalary(): number {
        return 0;
    }
}

class FullTimeEmployee extends Employees {
    calculateSalary(): number {
        return 40000;
    }
}

class PartTimeEmployee extends Employees {
    calculateSalary(): number {
        const hourlyRate = 200;
        const hoursWorked = 60;
        return hourlyRate * hoursWorked;
    }
}

const employees: Employees[] = [
    new FullTimeEmployee(),
    new PartTimeEmployee()
];

console.log("Full-Time Salary:", employees[0].calculateSalary());
console.log("Part-Time Salary:", employees[1].calculateSalary());


class Shape {
    area(): number {
        return 0;
    }
}

class Rectangle extends Shape {
    area(): number {
        return 10 * 5;
    }
}

class Circle extends Shape {
    area(): number {
        return 3.14 * 5 * 5;
    }
}

class Square extends Shape {
    area(): number {
        return 5 * 5;
    }
}

let r = new Rectangle();
let c = new Circle();
let s = new Square();
console.log(r.area());
console.log(c.area());
console.log(s.area());


class Payment {
    pay(): void {
        console.log("Payment");
    }
}

class UPI extends Payment {
    pay(): void {
        console.log("Paid using UPI");
    }
}

class Card extends Payment {
    pay(): void {
        console.log("Paid using Card");
    }
}

class Cash extends Payment {
    pay(): void {
        console.log("Paid using Cash");
    }
}

let payments: Payment[] = [new UPI(), new Card(), new Cash()];

for (let p of payments) {
    p.pay();
}


class Notifications {
    send(): void {
        console.log("Notification");
    }
}

class Email extends Notifications {
    send(): void {
        console.log("Email: Hello User!");
    }
}

class SMS extends Notifications {
    send(): void {
        console.log("SMS: Hello User!");
    }
}

class Push extends Notifications {
    send(): void {
        console.log("Push: Hello User!");
    }
}

let list: Notifications[] = [new Email(), new SMS(), new Push()];

for (let n of list) {
    n.send();
}

// Abstraction

abstract class Vehicle {
    abstract startEngine(): void;

    stopEngine(): void {
        console.log("Engine stopped");
    }
}

class Car extends Vehicle {
    startEngine(): void {
        console.log("Car engine started");
    }
}

class Bike extends Vehicle {
    startEngine(): void {
        console.log("Bike engine started");
    }
}

const car = new Car();
const bike = new Bike();

car.startEngine();
bike.startEngine();
car.stopEngine();


abstract class employes {
    name: string;
    id: number;

    constructor(name: string, id: number) {
        this.name = name;
        this.id = id;
    }

    abstract calculateSalary(): number;

    showDetails(): void {
        console.log("Employee:", this.name);
        console.log("ID:", this.id);
    }
}

class FullTimeemployee extends employes {
    calculateSalary(): number {
        return 40000;
    }
}

class PartTimeemployee extends employes {
    private hourlyRate: number;
    private hoursWorked: number;

    constructor(
        name: string,
        id: number,
        hourlyRate: number,
        hoursWorked: number
    ) {
        super(name, id);
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    calculateSalary(): number {
        return this.hourlyRate * this.hoursWorked;
    }
}

const fullTime = new FullTimeemployee("Ruhe", 101);

fullTime.showDetails();
console.log("Full-Time Salary:", fullTime.calculateSalary());

const partTime = new PartTimeemployee("Anu", 102, 200, 60);

partTime.showDetails();
console.log("Part-Time Salary:", partTime.calculateSalary());



abstract class Bankaccount {
    balance: number;

    constructor(balance: number) {
        this.balance = balance;
    }

    abstract interest(): number;

    showBalance(): void {
        console.log("Balance:", this.balance);
    }
}

class Savings extends Bankaccount {
    interest(): number {
        return this.balance * 0.05;
    }
}

class FixedDeposit extends Bankaccount {
    interest(): number {
        return this.balance * 0.08;
    }
}

let h = new Savings(10000);
let f = new FixedDeposit(10000);

console.log("Savings Interest:", h.interest());
console.log("Fixed Deposit Interest:", f.interest());

// interface


interface IStudent {
    name: string;
    age: number;
    displayDetails(): void;
}

class SchoolStudent implements IStudent {
    name: string;
    age: number;

    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }

    displayDetails(): void {
        console.log("Name:", this.name);
        console.log("Age:", this.age);
        console.log("Student details displayed");
    }
}

const student5 = new SchoolStudent("Rahul", 20);
student5.displayDetails();