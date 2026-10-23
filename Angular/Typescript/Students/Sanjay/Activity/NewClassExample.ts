class Animal{
    
    eat(){
        console.log("Parent class");
    }
}

class Dog extends Animal{
    Bark(){
        console.log('A white dog');
    }
}

let A1 = new Dog();
A1.eat();
A1.Bark();