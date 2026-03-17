function addBooking() {

    let table = document.getElementById("body");
    let name = document.getElementById("name").value.trim();
    let destination = document.getElementById("destination").value;
    let price = document.getElementById("price").value.trim();


    if (name == "" || destination == "" || price == "") {
        alert("enter all fields");
        return false;
    }

    let tr = document.createElement("tr");

    let td1 = document.createElement("td");
    td1.innerText = name;

    let td2 = document.createElement("td");
    td2.innerHTML = destination;

    let td3 = document.createElement("td");
    td3.innerText = price;

    td4 = document.createElement("td");
    td4.innerHTML = "Pending";
    td4.className = "pending";

    let td5 = document.createElement("td");

    let btn1 = document.createElement("button");
    btn1.innerText = "Confirm";
    btn1.onclick = function() {
        changeStatus(this,"Confirmed");
    }

    btn1.className = "btn1";

    let btn2 = document.createElement("button");
    btn2.innerHTML = "Delete";
    btn2.onclick = function() {
        tr.remove();
    }
    btn2.className = "btn2";

    td5.appendChild(btn1);
    td5.appendChild(btn2);

    tr.appendChild(td1);
    tr.appendChild(td2);
    tr.appendChild(td3);
    tr.appendChild(td4);
    tr.appendChild(td5);

    table.appendChild(tr);


    document.getElementById("name").value = "";
    document.getElementById("destination").value = "";
    document.getElementById("price").value = "";
}

function changeStatus(btn,status) {
    let row = btn.parentNode.parentNode;
    row.children[3].innerHTML = status;
    row.children[3].style.color = "green";
}



function searchTable() {

    let input = document.getElementById("search").value.toLowerCase();
    let table = document.getElementById("body");
    let rows = table.getElementsByTagName("tr");

    for (let i = 0; i < rows.length; i++) {

        let text = rows[i].innerText.toLowerCase();

        if (text.includes(input)) {
            rows[i].style.display = "";
        } else {
            rows[i].style.display = "none";
        }
    }
}

