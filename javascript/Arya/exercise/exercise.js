function  ValidationForm() {
    
    var form = document.forms['consultantform'];

    var fname = form.fname.value.trim();
    var lname = form.lname.value.trim();
    var gender = form.gender.value;
    var DOB= form.DOB.value;
    var email = form.email.value.trim();
    var phone = form.phone.value.trim();
    var username = form.username.value.trim();
    var password = form.password.value.trim();



    var name1 = document.getElementById("fname").focus();
    var name = /^[A-Za-z]{4,}$/;
    if (fname === "") {
        alert("Enter first name");
        name1;
        return false;
    }
    else if (!name.test(fname)) {
        alert("Want 4 or more character not numbers");
        name1;
        return false;
    }

    var name2 = document.getElementById("lname").focus();
    if (lname === "") {
        alert("Enter last name");
         name2;
        return false;
    }
    else if (!name.test(lname)) {
        alert("last name want 4 or more character no numbers");
        name;
        return false;
    }

    
    if (gender === "") {
        alert("Enter gender");
        return false;
    }


    let dob = document.getElementById("DOB").value;
    let birthDate = new Date(dob);
    let today = new Date();
    today.setHours(0,0,0,0);

    if (DOB === "") {
        alert("Enter dob");
        return false;
    }
    else if (birthDate >= today) {
        alert("Date of birth cannot be today or a future date");
        return false;
    }

    
    var email1 = document.getElementById("email").focus();
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (email === "") {
        alert("Enter email");
        email1;
        return false;
    }
    else if (!emailRegex.test(email)) {
        alert("Invalid email");
        email1;
        return false;
    }

    var phno1 = document.getElementById("phn").focus();
    var phoneRegex = /^[0-9]{10}$/;
    if (phone === "") {
        alert("Enter phone number");
        phno1;
        return false;
    }
    else if (!phoneRegex.test(phone)) {
        alert("Phone number must contain 10 numbers");
        phno1;
        return false;
    }

    var username1 = document.getElementById("username").focus();
    var userRegex = /^.{5,}$/;
    if (username === "") {
        alert("Enter username");
        username1;
        return false;
    }
    else if (!userRegex.test(username)) {
        alert("Username must contain atleast 5 character");
        username1;
        return false;
    }
    
    var password1 = document.getElementById("password").focus();
    let passwordRegex = /^.{6,}$/;
    if (password === "") {
        alert("Enter password");
        password1;
        return false;
    }
    else if (!passwordRegex.test(password)) {
        alert("Password must be atleast 8 character long");
        password1;
        return false;
    }

    alert("Registration Success!");
    return true;

}

function clearform() {
    document.getElementById("consultantform").reset();
}