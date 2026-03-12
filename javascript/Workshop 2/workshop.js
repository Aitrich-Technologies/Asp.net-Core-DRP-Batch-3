// function validateForm() {
//   var title = document.getElementById("title").value.trim();
//   var description = document.getElementById("description").value.trim();
//   var destination = document.getElementById("destination").value;
//   var nights = document.getElementById("nights").value;
//   var price = document.getElementById("price").value;
//   var departure = document.getElementById("departure").value;
//   var Arrival=document.getElementById("Arrival").value;

 function validateForm(form) {

  var title = form.title.value.trim();
  var description = form.description.value.trim();
  var destination = form.destination.value;
  var nights = form.nights.value;
  var price = form.price.value;
  var departure = form.departure.value;
  var Arrival=form.Arrival.value;


  if (!title) {
    alert("Enter title");
    return false;
  }

  if (!description || description.length<15) {
    alert("Enter description");
    return false;
  }


  if (!destination) {
    alert("Choose destination");
    return false;
  }

  // nights = Number(nights);
  if (!nights) {
    alert("Invalid nights");
    return false;
  }

  price = Number(price);
  if (isNaN(price)) {
    alert("Invalid price");
    return false;
  }

  if (!departure) {
    alert("Select departure date");
    return false;
  }
  if (!Arrival){
   alert("Select Arrival date");
   return false;
  }

  var dep=new Date(departure);
  var arr=new Date(Arrival);

var diff= (arr-dep)/(1000*60*60*24);
if(diff!=nights){
 alert ( "arrival date must match number of nights");
 return false;
}


alert("Tour Created Succesfully!" );
  return true;
  
}





