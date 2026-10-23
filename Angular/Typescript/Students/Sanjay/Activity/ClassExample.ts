// class Person{
//     name:string;

//     constructor(name:string){
//         this.name = name;
//     }
// }
// class Student extends Person{

//     constructor(name:string){
//         super(name);
//     }
// }
// let S1 = new Student("Sanju");
// console.log(S1.name);

// class Person{
//     name:string;
//     constructor(name:string){
//         this.name = name;
//     }
// }
// class Employee extends Person{
//    salary: number;
//    constructor(name:string,salary:number) {
//     super(name);
//     this.salary = salary;
//    }
// }
// class manager extends Employee{
//     department:string;
//     constructor(name:string,salary:number,department:string){
//         super(name,salary);
//         this.department = department;
//     }
// }

// let M1 = new manager("Arun",100,"IT")
// console.log(M1.name);

class Product{
    name:string;
    price:number;
    constructor(name:string,price:number){
        this.name = name;
        this.price = price;
    }
}
class ElectronicProduct extends Product{
    warrenty:number;
    constructor(name:string,price:number,warrenty:number){
        super(name,price);
        this.warrenty = warrenty;
    }
}
let p1 = new ElectronicProduct("Phone",1000,1)
console.log(p1.name);