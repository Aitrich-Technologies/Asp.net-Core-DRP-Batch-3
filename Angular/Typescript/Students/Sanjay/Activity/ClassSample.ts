class Student{
    name:string ;
    
    constructor(name:string){
        this.name = name;
    }
    Display(){
        console.log(this.name);
    }

}

let s1 = new Student('sanjay');
s1.Display();
const s2 =new Student('Arya');
s2.Display();
