function validateForm(){

let name = document.getElementById("name").value.trim();
let location = document.getElementById("location").value.trim();
let category = document.getElementById("category").value;
let description = document.getElementById("description").value.trim();
let price = document.getElementById("price").value;
let discount = document.getElementById("discount").value;
let duration = document.getElementById("duration").value;
let season = document.getElementById("season").value;


if(name.length < 3){
alert("Destination name must be at least 3 characters");
return;
}


if(location == ""){
alert("Country / Location is required");
return;
}


if(category == ""){
alert("Please select a category");
return;
}


if(description.length < 20){
alert("Description must be at least 20 characters");
return;
}


if(price <= 0){
alert("Standard price must be positive and not zero");
return;
}


if(discount != "" && Number(discount) >= Number(price)){
alert("Discount price must be less than standard price");
return;
}


if(duration < 1 || duration > 30){
alert("Duration must be between 1 and 30 nights");
return;
}


if(season == ""){
alert("Please select travel season");
return;
}

alert("Form submitted successfully!");
return true;

}