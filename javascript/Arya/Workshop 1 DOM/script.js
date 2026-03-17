function addData() {
    let dname = document.getElementById("dname").value;
    let country = document.getElementById("country").value;
    let price = document.getElementById("price").value;

    if (!dname || !country || !price) {
        alert("Enter all fields");
        return;
    }
const card = document.createElement("div");
    card.className = "card";
    const h3 = document.createElement("h3");
    h3.textContent = dname;
    const p = document.createElement("p");
    p.textContent = country;
    const p1 = document.createElement("p");
    p1.textContent = price;
    const btn = document.createElement("button");
    btn.className = "delete";
    btn.textContent = "Delete";

    btn.addEventListener("click", function () {
        card.remove();
    });

    card.append(h3, p, p1, btn);

    document.getElementById("cardHolder").appendChild(card);

    document.getElementById("dname").value = "";
    document.getElementById("country").value = "";
    document.getElementById("price").value = "";

}
function searchCard() {
    const searchValue = document.getElementById("search").value.toLowerCase();
    const Scard = document.querySelectorAll(".card");

    Scard.forEach(card => {
        const text = card.querySelector("h3").textContent.toLowerCase();

        if (text.includes(searchValue)) {
            card.style.display = "block";
        }
        else {
            card.style.display = "none"
        }
    });
}
    