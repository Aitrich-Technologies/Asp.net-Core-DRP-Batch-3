// class Employee {
//     calculateSalary(): number {
//         return 0;
//     }
// }

// class FullTimeEmployee extends Employee {
//     constructor(private monthlySalary: number) {
//         super();
//     }

//     override calculateSalary(): number {
//         return this.monthlySalary;
//     }
// }

// class PartTimeEmployee extends Employee {
//     constructor(
//         private hourlyRate: number,
//         private hoursWorked: number
//     ) {
//         super();
//     }

//     override calculateSalary(): number {
//         return this.hourlyRate * this.hoursWorked;
//     }
// }

// const fullTime = new FullTimeEmployee(40000);
// const partTime = new PartTimeEmployee(200, 60);

// console.log(`Full-Time Salary: ${fullTime.calculateSalary()}`);
// console.log(`Part-Time Salary: ${partTime.calculateSalary()}`);




// class Shape {
//     calculateArea(): number {
//         return 0;
//     }
// }

// class Rectangle extends Shape {
//     constructor(
//         private width: number,
//         private height: number
//     ) {
//         super();
//     }

//     override calculateArea(): number {
//         return this.width * this.height;
//     }
// }

// class Circle extends Shape {
//     constructor(private radius: number) {
//         super();
//     }

//     override calculateArea(): number {
//         return Math.PI * this.radius * this.radius;
//     }
// }

// class Square extends Shape {
//     constructor(private side: number) {
//         super();
//     }

//     override calculateArea(): number {
//         return this.side * this.side;
//     }
// }

// const rectangle = new Rectangle(10, 5);
// const circle = new Circle(5);
// const square = new Square(5);

// console.log(`Rectangle Area: ${rectangle.calculateArea()}`);
// console.log(`Circle Area: ${circle.calculateArea().toFixed(2)}`);
// console.log(`Square Area: ${square.calculateArea()}`);




class Payment {
    processPayment(amount: number): void {
        console.log(`Paid ₹${amount}`);
    }
}

class CreditCardPayment extends Payment {
    override processPayment(amount: number): void {
        console.log(`Paid ₹${amount} using Credit Card`);
    }
}

class UPIPayment extends Payment {
    override processPayment(amount: number): void {
        console.log(`Paid ₹${amount} using UPI`);
    }
}

class CashPayment extends Payment {
    override processPayment(amount: number): void {
        console.log(`Paid ₹${amount} using Cash`);
    }
}

const payments: Payment[] = [
    new CreditCardPayment(),
    new UPIPayment(),
    new CashPayment()
];

for (const payment of payments) {
    payment.processPayment(500);
}