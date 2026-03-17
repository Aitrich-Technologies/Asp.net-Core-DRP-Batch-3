function addBooking(){
    let name= document.getElementById("name").value;
    let destination= document.getElementById("Destination").value;
    let price= document.getElementById("price").value;

if(name==="" || destination===""|| price==="") {
    alert("please fill all fields")
    return;
} 
let table = document.getElementById("Booking table");
    // let name = document.getElementById("name").value;
    // let destination = document.getElementById("destination").value;
    // let price = document.getElementById("price").value;

    let tr = document.createElement("tr");

    let td1 = document.createElement("td");
    td1.innerText = name;

    let td2 = document.createElement("td");
    td2.innerHTML = destination;

    let td3 = document.createElement("td");
    td3.innerText = price;

    td4 = document.createElement("td");
    td4.innerHTML = "Pending";

    let td5 = document.createElement("td");

    let btn  = document.createElement("button");
    btn.innerText = "Confirm";
    btn.onclick = function() {
        changeStatus(this,"Confirmed");
    }
    btn.className = "btn";

    let btn1 = document.createElement("button");
    btn1.innerHTML = "Delete";
    btn1.onclick = function() {
        tr.remove();
    }
    btn1.className = "btn1";

    td5.appendChild(btn);
    td5.appendChild(btn1);

    tr.appendChild(td1);
    tr.appendChild(td2);
    tr.appendChild(td3);
    tr.appendChild(td4);
    tr.appendChild(td5);

    table.appendChild(tr);
}

function changeStatus(btn,status) {
    let row = btn.parentNode.parentNode;
    row.children[3].innerHTML = status;
}

function searchDestination(){
    let input = document.getElementById("search").value.toLowerCase();
    let table = document.getElementById("Booking table");
    let rows = table.getElementsByTagName("tr");

    for (let i = 0; i < rows.length; i++) {

        let text = rows[i].innerText.toLowerCase();

        if (text.includes(input)) {
            rows[i].style.display = "";
        } else {
            rows[i].style.display = "none";}
}
}
