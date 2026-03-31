function validationForm(){
    var form = document.forms['signupForm'];
    var dname = form.name.value.trim();
    var location = form.location.value.trim();
    var category = form.category.value;
    var description=form.description.value.trim();
    var standardprice=form.standardprice.value.trim();
    var discountprice=form.discountprice.value.trim();
    var Duration=form.Duration.value.trim();
    var travelseason=form.travelseason.value;
    
    
    var name1 = /^[A-Za-z]{3,}$/;
    if(dname === ""){
        alert("Enter Destination name");
        document.getElementById("name").focus();
         return false;
    }
     
    else if(!name1.test(dname)){
        alert("minimum 3 characters");
        return false;
    }

    if(location===""){
        alert(" enter Location ");
         document.getElementById("location").focus();
        return false;
    }

    if(category === ""){
    alert("Must choose a valid option");
    document.getElementById("category").focus();
    return false;
    }
    var des=/^.{20,}$/;
    if(description === "") {
        alert("enter description");
        document.getElementById("description").focus();
        return false;
    }
    else if(!des.test(description)){
        alert("minimum 20 characters")
        return false
    }

    if(standardprice === ""){
    
    alert("Price is required");
    document.getElementById("price").focus();
    return false;
    }
    else if(standardprice <= 0){
        alert("enter positive number")
        return false
    }


    if(discountprice===""){
    
    alert("Price is required");
    document.getElementById("discountprice").focus();
    return false;
    }
    else if(discountprice >= standardprice){
        alert("must be less than standard price")
        return false
    }


   
    if(Duration===""|| Duration.value<1||Duration.value>30 ){
    alert("Duration is required");
    document.getElementById("nights").focus();
    
    return false;
    }
   


    if(travelseason===""){
    alert("season required");
    document.getElementById("season").focus();
    return false;
    }

    alert("Form Saved Successfully!");
    return true;
    
function formreset(){
    document.getElementById("signupForm").reset();
}
} 
