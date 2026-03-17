function addPackage(){

let name = document.getElementById("name").value;
let days = document.getElementById("days").value;
let price = document.getElementById("price").value;

if(name=="" || days=="" || price==""){
alert("Fill all fields");
return;
}

let table = document.getElementById("packageTable").getElementsByTagName("tbody")[0];

let row = table.insertRow();

row.insertCell(0).innerText = name;
row.insertCell(1).innerText = days;
row.insertCell(2).innerText = price;

function editPackage(row){

let name = row.cells[0].innerText;
let days = row.cells[1].innerText;
let price = row.cells[2].innerText;

document.getElementById("name").value = name;
document.getElementById("days").value = days;
document.getElementById("price").value = price;

row.remove();

}

let action = row.insertCell(3);

let editBtn = document.createElement("button");
editBtn.innerText = "Edit";
editBtn.className="edit";
editBtn.onclick = function(){
editPackage(row);
};

action.appendChild(editBtn);

let delBtn = document.createElement("button");
delBtn.innerText="Delete";
delBtn.className="delete";

delBtn.onclick=function(){

row.remove();
}

action.appendChild(delBtn);

showToast();

document.getElementById("name").value="";
document.getElementById("days").value="";
document.getElementById("price").value="";
}


function searchPackage(){

let input = document.getElementById("search").value.toLowerCase();

let rows = document.querySelectorAll("#packageTable tbody tr");

rows.forEach(row => {

let text = row.cells[0].innerText.toLowerCase();

row.style.display = text.includes(input) ? "" : "none";

});

}


function showToast(){

let toast = document.getElementById("toast");

toast.style.display="block";

setTimeout(()=>{
toast.style.display="none";
},2000);

}