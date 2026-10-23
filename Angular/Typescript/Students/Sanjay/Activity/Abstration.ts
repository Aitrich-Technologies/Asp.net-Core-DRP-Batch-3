// abstract class Vehicle {
//     abstract startEngine(): void;

//     stopEngine(): void {
//         console.log("Engine stopped");
//     }
// }

// class Car extends Vehicle {
//     override startEngine(): void {
//         console.log("Car engine started");
//     }
// }

// class Bike extends Vehicle {
//     override startEngine(): void {
//         console.log("Bike engine started");
//     }
// }

// const car = new Car();
// const bike = new Bike();

// car.startEngine();
// bike.startEngine();
// car.stopEngine();



// abstract class Employee {
//     constructor(
//         public name: string,
//         public id: number
//     ) {}

//     abstract calculateSalary(): number;

//     showDetails(): void {
//         console.log(`Employee: ${this.name}`);
//         console.log(`ID: ${this.id}`);
//     }
// }

// class FullTimeEmployee extends Employee {
//     constructor(name: string, id: number, private monthlySalary: number) {
//         super(name, id);
//     }

//     override calculateSalary(): number {
//         return this.monthlySalary;
//     }
// }

// class PartTimeEmployee extends Employee {
//     constructor(
//         name: string,
//         id: number,
//         private hourlyRate: number,
//         private hoursWorked: number
//     ) {
//         super(name, id);
//     }

//     override calculateSalary(): number {
//         return this.hourlyRate * this.hoursWorked;
//     }
// }

// const emp1 = new FullTimeEmployee("Rahul", 101, 40000);
// emp1.showDetails();
// console.log(`Full-Time Salary: ${emp1.calculateSalary()}`);

// const emp2 = new PartTimeEmployee("Anu", 102, 200, 60);
// emp2.showDetails();
// console.log(`Part-Time Salary: ${emp2.calculateSalary()}`);




// abstract class BankAccount {
//     constructor(protected balance: number) {}

//     abstract calculateInterest(): number;

//     showBalance(): void {
//         console.log(`Balance: ${this.balance}`);
//     }
// }

// class SavingsAccount extends BankAccount {
//     override calculateInterest(): number {
//         return this.balance * 0.05;
//     }
// }

// class FixedDepositAccount extends BankAccount {
//     override calculateInterest(): number {
//         return this.balance * 0.08;
//     }
// }

// const savings = new SavingsAccount(10000);
// const fixedDeposit = new FixedDepositAccount(10000);

// console.log(`Savings Interest: ${savings.calculateInterest()}`);
// console.log(`Fixed Deposit Interest: ${fixedDeposit.calculateInterest()}`);


