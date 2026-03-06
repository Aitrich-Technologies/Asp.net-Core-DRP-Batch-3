function validateForm() {

    var form = document.forms['signupForm'];

    var fname = form.fname.value.trim();
    var lname = form.lname.value.trim();
    var gender = form.gender.value;
    var dob = form.dob.value;
    var username = form.username.value.trim();
    var email = form.email.value.trim();
    var password = form.password.value;

    // Basic checks
    if (fname === "") {
        alert("Enter first name");
        return false;
    }

    if (lname === "") {
        alert("Enter last name");
        return false;
    }

    if (gender === "") {
        alert("Select gender");
        return false;
    }

    if (dob === "") {
        alert("Enter date of birth");
        return false;
    }

    if (username === "") {
        alert("Enter username");
        return false;
    }

    if (email === "") {
        alert("Enter email");
        return false;
    }

    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailRegex.test(email)) {
        alert("Invalid email");
        return false;
    }

    if (password === "") {
        alert("Enter password");
        return false;
    }

    return true;
}
