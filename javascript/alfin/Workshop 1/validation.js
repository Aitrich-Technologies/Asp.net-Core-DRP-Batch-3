function validateForm() {

    var form = document.forms['signupForm'];

    var fname = form.fname.value.trim();
    var lname = form.lname.value.trim();
    var gender = form.gender.value;
    var dob = form.dob.value;
    var username = form.username.value.trim();
    var email = form.email.value.trim();
    var phoneno = form.phoneno.value.trim();
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
    
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (email === "") {
        alert("Enter email");
        return false;
    }
    else if (!emailRegex.test(email)){
        alert("Enter valid email");
        return false;
    }


    var phoneregex =  /^[0-9]{10}$/;
    if(phoneno===""){
     alert("enter phone number");
     return false;
    }
    else if (!phoneregex.test(phoneno)) {
        alert("phone number must 10 ");
        return false;
    }
     
    
    let passwordregex= /^.{8,}$/;
    if (password === "") {
        alert("Enter password");
        return false;
    }
    else if (!passwordregex.test(password)) {
        alert("Enter password must be 8 character long");
        return false;

    }

    alert("registraction successful");
    return true;
}

    

    // var phoneregex =  /^[0-9]{10}$/;
    // if(phoneno==="" && !phoneno=== phoneregex){
    //  alert("enter phone number");
    //  return false;
    // }
     
    
    // let passwordregex= /^.{8,}$/;
    // if (password === "" && !password === passwordregex) {
    //     alert("Enter password");
    //     return false;
    // }
    
//     alert("registraction successful");
//     return true;
// }

