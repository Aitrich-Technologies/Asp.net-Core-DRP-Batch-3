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
        <td><button onclick ="deleterow(this)" class="del">X</button></td>
    `;

    document.getElementById("body").appendChild(tr);

    //  tr.querySelector(".del").onclick =function (){
    //     tr.remove();
    //  };

}
    function splitprice(){
        let price = document.getElementById("dest").value;
         
        let data = price.split("_");



        document.getElementById("price").value=data[1];

        calculateTotal();

    } 

       function calculateTotal(){
        let price = document.getElementById("price").value;
        let nights = document.getElementById("nights").value;

        let total = price*nights;

        document.getElementById("total").innerText = total;
       }

       function deleterow(btn){
        let row = btn.parentNode.parentNode;
        row.parentNode.removeChild(row);
       }

       
