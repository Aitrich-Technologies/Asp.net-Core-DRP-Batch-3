function addFunction() {

    let table = document.getElementById("body");
    let name = document.getElementById("name").value;
    let package = document.getElementById("package").value;

    let tr = document.createElement("tr");

    let td1 = document.createElement("td");
    td1.innerText = name;

    let td2 = document.createElement("td");
    td2.innerText = package;

    let td3 = document.createElement("td");
    td3.innerText = "Pending";
    td3.className = "td3";

    let td4 = document.createElement("td");

    let btn1 = document.createElement("button");
    btn1.innerHTML = "Approve";
    btn1.onclick = function() {
        changeStatus(this,"Approved"), td3.style.color = "green";
    };
    btn1.className = "btn1";

    let btn2 = document.createElement("button");
    btn2.innerHTML = "Reject";
    btn2.onclick = function() {
        changeStatus(this,"Rejected"),td3.style.color = "Red";
    };
    btn2.className = "btn2";

    td4.appendChild(btn1);
    td4.appendChild(btn2);


    tr.appendChild(td1);
    tr.appendChild(td2);
    tr.appendChild(td3);
    tr.appendChild(td4);


    table.appendChild(tr);

    document.getElementById("name").value = "";
    document.getElementById("package").value = "";
 
    
}

    function changeStatus(btn,status) {
        let row = btn.parentNode.parentNode;
        row.children[2].innerHTML = status;
    }