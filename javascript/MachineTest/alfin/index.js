 function addTask() {
        let name = document.getElementById("task");
        let task = name.value.trim();

        if (task === "") {
            alert("Please enter a task");
            return;
        }

        let li = document.createElement("li");
        li.textContent = task;

        
        let updateBtn = document.createElement("button");
         updateBtn.textContent = "Update";
         updateBtn.className = "update-btn";
         updateBtn.onclick = function () {
            
            let newTask = prompt("Edit task:", li.firstChild.textContent);
            if (newTask !== null) {
                li.firstChild.textContent = newTask;
            }
         };

    
        let deleteBtn = document.createElement("button");
        deleteBtn.textContent = "Delete";
        deleteBtn.className = "delete-btn";
        deleteBtn.onclick = function () {
            li.remove();
        };

        li.appendChild(updateBtn);
        li.appendChild(deleteBtn);

        document.getElementById("taskList").appendChild(li);

        name.value = "";
    }
