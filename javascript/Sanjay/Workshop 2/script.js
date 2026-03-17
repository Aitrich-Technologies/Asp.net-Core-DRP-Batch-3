function addBooking() {
    
    let dest = document.getElementById("dest");
    let nights = document.getElementById("nights").value;
    let total = document.getElementById("total").innerText;

    if (!dest.value || !nights) {
        alert("Enter all fields");
        return;
    }

    let tr = document.createElement("tr");
    tr.innerHTML = `
        <td>${dest.options[dest.selectedIndex].text}</td>
        <td>${nights}</td>
        <td>${total}</td>
        <td><button onclick="deleteRow(this)" class="del">X</button></td>
    `;

    document.getElementById("body").appendChild(tr);
}


function price() {

    let price  = document.getElementById("dest").value;
    let data = price.split("_");

    document.getElementById("price").value = data[1];

     calculateTotal();
}


function calculateTotal() {

    let price = document.getElementById("price").value;
    let nights = document.getElementById("nights").value;

    let total = price * nights;

    document.getElementById("total").innerText = total;
}




function deleteRow(btn){
    let row = btn.parentNode.parentNode;
    row.parentNode.removeChild(row);
}
