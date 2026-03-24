function addTask() {

    let input = document.getElementById("taskinput");
    let taskValue = input.value.trim();

    if (taskValue === "") {
        alert("Enter a task!");
        return;
    }

    let table = document.getElementById("tasktable");

    let row = document.createElement("tr");

    let taskCell = document.createElement("td");
    taskCell.innerText = taskValue;

    let actionCell = document.createElement("td");

    let updateBtn = document.createElement("button");
    updateBtn.innerText = "Update";

    let deleteBtn = document.createElement("button");
    deleteBtn.innerText = "Delete";

    
    updateBtn.onclick = function () {
        let newTask =prompt("Edit task:", taskCell.innerText);
        if (newTask !== null && newTask.trim() !== "") {
            taskCell.innerText = newTask;
        }
    };

    

    deleteBtn.onclick = function () {
        row.remove();
    };

    actionCell.appendChild(updateBtn);
    actionCell.appendChild(deleteBtn);

    row.appendChild(taskCell);
    row.appendChild(actionCell);

    table.appendChild(row);

    input.value = "";
}