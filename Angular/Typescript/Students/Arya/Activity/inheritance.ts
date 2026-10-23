class Animal{
   eat(){
    console.log ("animal is eating")
   }
}
class cat extends Animal{
    meow(){
        console.log("cat meow")
    }
}

let cat1 = new cat();
cat1.eat();
cat1.meow();


