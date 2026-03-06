function validateForm(form) {

  var title = form.title.value.trim();
  var description = form.description.value.trim();
  var destination = form.destination.value;
  var nights = form.nights.value;
  var price = form.price.value;
  var departure = form.departure.value;

  if (!title) {
    alert("Enter title");
    return false;
  }

  if (!description) {
    alert("Enter description");
    return false;
  }

  if (!destination) {
    alert("Choose destination");
    return false;
  }

  nights = Number(nights);
  if (!nights || nights < 1) {
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

  return true;
}
