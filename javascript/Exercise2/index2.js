function validateForm(){

// var form =  document.forms['signupform'];
// var dname = form.name.value.trim();
// var location = form.location.value.trim();
// var category =form.category.value;
// var description = form.description.value.trim();
// var price = form.price.value;
// var discount = form.discount.value;
// var duration = form.duration.value;
// var season = form.season.value;

var dname = document.getElementById("dname")
var location = document.getElementById("location")
var category =document.getElementById("category");
var description = document.getElementById("description");
var price = document.getElementById("price");
var discount = document.getElementById("discount");
var duration = document.getElementById("duration");
var season = document.getElementById("season");




var name =/^[A-Za-z]{3,}$/;
if(dname.value.trim() === ""){
alert("Destination name must be at least 3 characters");
// dname.focus();
document.getElementById("dname").focus();
return false;
}


if(location.value.trim() == ""){
alert("Country / Location is required");
location.focus();
return false;
}


if(category.value == ""){
alert("Please select a category");
category.focus();
return false;
}


if(description.value.length < 20){
alert("Description must be at least 20 characters");
description.focus();
return false;
}


if(price.value <= 0){
alert("Standard price must be positive and not zero");
price.focus();
return false;
}


if(discount.value != "" && Number(discount) >= Number(price)){
alert("Discount price must be less than standard price");
discount.focus();
return false;
}


if(duration.value < 1 || duration > 30){
alert("Duration must be between 1 and 30 nights");
duration.focus();
return false;
}


if(season.value == ""){
alert("Please select travel season");
season.focus();
return false;
}

alert("Form submitted successfully!");
return true;

}
function resetForm(){
 document.getElementById("signupform").reset();
}


