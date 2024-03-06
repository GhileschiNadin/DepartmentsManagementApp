function getAllDepartments() {
    var xhr = new XMLHttpRequest();
    xhr.open("GET", "/department", true);
    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4 && xhr.status == 200) {
            // Parse the JSON response
            var departments = JSON.parse(xhr.responseText);
            updateDepartmentTable(departments);
        }
    };
    xhr.send();
}

function updateDepartmentTable(departments) {
    var tableBody = document.getElementById("departmentTableBody");

    tableBody.innerHTML = "";

    for (var i = 0; i < departments.length; i++) {
        var department = departments[i];
        var row = tableBody.insertRow(i);
        var cell1 = row.insertCell(0);
        cell1.innerHTML = department.id;
        var cell2 = row.insertCell(1);
        cell2.innerHTML = department.departmentName;
        var cell3 = row.insertCell(2);
        cell3.innerHTML = department.description;
        var cell4 = row.insertCell(3);
        cell4.innerHTML = department.parentId ? department.parentId.id : "N/A";

    }
}

function addNewDepartment() {
    var departmentName = document.getElementById("departmentName").value;
    var description = document.getElementById("description").value;
    var parentId = document.getElementById("parentId").value;
    var department = {
        departmentName: departmentName,
        description: description,
        parentId: null
    };
    if (parentId != "") {
        fetch("/department/" + parentId)
            .then(response => response.json())
            .then(data => {
                department.parentId = data;
                fetch("/departmentPST", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(department)
                })
                    .then(response => response.json())
                    .then(data => console.log(data))
                    .catch(error => console.error(error));
            })
            .catch(error => console.error(error));
    } else {
        fetch("/departmentPST", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(department)
        })
            .then(response => response.json())
            .then(data => console.log(data))
            .catch(error => console.error(error));
    }
}

function updateDepartmentName() {
    var departmentId = document.getElementById("departId").value;
    var departmentName = document.getElementById("departName").value;
    var department = {
        departmentName: departmentName,
        description: null
    };
    fetch("/department/" + departmentId)
        .then(response => response.json())
        .then(data => {
            department.description = data.description;
            department.parentId = data.parentId;
            fetch("/department/" + departmentId, {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(department)
            })
                .then(response => response.json())
                .then(data => console.log(data))
                .catch(error => console.error(error));
        })
        .catch(error => console.error(error));
}




