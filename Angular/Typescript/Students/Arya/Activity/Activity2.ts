class Person {
    name: string;
    age: number;

    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }
}

class Student extends Person {
    constructor(name: string, age: number) {
        super(name, age);
    }
}

let student1 = new Student("Arya", 22);

console.log("Name:", student1.name);
console.log("Age:", student1.age);

// multilevel inheritance

class person{
    name:string;
    constructor (name:string){
        this.name = name;
    }
}
class employee extends person{
    salary:number;
    constructor (name:string,salary:number){
        super(name);
        this.salary = salary;
    }
}
class manager extends employee{
    department:string;
    constructor(name:string,salary:number,department:string){
        super(name,salary);
        this.department=department;
    }
}
let manager1 = new manager("arya",5000,"hr")
console.log("Name:", manager1.name);
console.log("Salary:", manager1.salary);
console.log("Department:", manager1.department);

class Product {
    name: string;
    price: number;

    constructor(name: string, price: number) {
        this.name = name;
        this.price =
         price;
    }
}

class ElectronicProduct extends Product {
    warranty: number;

    constructor(name: string, price: number, warranty: number) {
        super(name, price);
        this.warranty = warranty;
    }
}

let product1 = new ElectronicProduct("Laptop", 50000, 2);

console.log("Product:", product1.name);
console.log("Price: ₹" + product1.price);
console.log("Warranty:", product1.warranty, "years");



