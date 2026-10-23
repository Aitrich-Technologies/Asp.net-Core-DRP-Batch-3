// interface Student {
//     name: string;
//     age: number;
//     displayDetails(): void;
// }

// class SchoolStudent implements Student {
//     constructor(
//         public name: string,
//         public age: number
//     ) {}

//     displayDetails(): void {
//         console.log(`Name: ${this.name}`);
//         console.log(`Age: ${this.age}`);
//         console.log("Student details displayed");
//     }
// }

// const student = new SchoolStudent("Rahul", 20);
// student.displayDetails();


// interface Employee {
//     name: string;
//     salary: number;
//     calculateBonus(): number;
// }

// class Manager implements Employee {
//     constructor(
//         public name: string,
//         public salary: number
//     ) {}

//     calculateBonus(): number {
//         return this.salary * 0.10;
//     }
// }

// const manager = new Manager("Anu", 50000);

// console.log(`Name: ${manager.name}`);
// console.log(`Salary: ${manager.salary}`);
// console.log(`Bonus: ${manager.calculateBonus()}`);




// interface BankAccount {
//     accountHolder: string;
//     deposit(amount: number): void;
//     withdraw(amount: number): void;
//     getBalance(): number;
// }

// class SavingsAccount implements BankAccount {
//     private balance: number;

//     constructor(
//         public accountHolder: string,
//         initialBalance: number
//     ) {
//         this.balance = Math.max(0, initialBalance);
//     }

//     deposit(amount: number): void {
//         if (amount <= 0) {
//             console.log("Invalid deposit!");
//             return;
//         }

//         this.balance += amount;
//     }

//     withdraw(amount: number): void {
//         if (amount <= 0) {
//             console.log("Invalid withdrawal!");
//             return;
//         }

//         if (amount > this.balance) {
//             console.log("Insufficient balance!");
//             return;
//         }

//         this.balance -= amount;
//     }

//     getBalance(): number {
//         return this.balance;
//     }
// }

// const account = new SavingsAccount("Rahul", 1000);

// console.log(`Account Holder: ${account.accountHolder}`);
// console.log(`Balance: ${account.getBalance()}`);

// account.deposit(500);
// account.withdraw(200);

// console.log(`Final Balance: ${account.getBalance()}`);