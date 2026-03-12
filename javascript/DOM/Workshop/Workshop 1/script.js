function addData() {
    let dname = document.getElementById("dname").value;
    let country = document.getElementById("country").value;

    if (!dname || !country) {
        alert("Enter all fields");
        return;
    }
    document.getElementById("cardHolder").appendChild(card);

    document.getElementById("dname").value = "";
    document.getElementById("country").value = "";
}
