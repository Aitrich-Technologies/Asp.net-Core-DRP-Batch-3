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
        <td><button class="del">X</button></td>
    `;

    document.getElementById("body").appendChild(tr);
}
