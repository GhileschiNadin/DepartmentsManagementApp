function getEmployees() {
    sendRequest("GET", "employee", null, getEmployeeSuccessHandler, errorHandler);
}

function getEmployeeSuccessHandler(respData) {
    var tableBody = document.getElementById("employeeTableBody");
    // Clear existing rows
    tableBody.innerHTML = "";

    for (var i = 0; i < respData.length; i++) {
        var row = tableBody.insertRow(i);
        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);
        var cell5 = row.insertCell(4);

        cell1.innerHTML = respData[i].id;
        cell2.innerHTML = respData[i].employeeName;
        cell3.innerHTML = respData[i].departmentId;
        cell4.innerHTML = respData[i].managerId;
        cell5.innerHTML = respData[i].email;

    }
}
function addEmployee() {
    const employee = {
        employeeName: document.getElementById("employeeName").value,
        departmentId: document.getElementById("departmentId").value,
        managerId: document.getElementById("managerId").value,
        email: document.getElementById("email").value
    };

    fetch('/employeePST', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(employee)
    })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Employee added successfully!');
            getEmployees();
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}

function deleteEmployee() {
    const id = document.getElementById("id").value;

    fetch(`/employee/${id}`, {
        method: 'DELETE'
    })
        .then(response => {
            console.log('Success:', response);
            alert('Employee deleted successfully!');
            getEmployees();
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}

// employee.js

function getEmployeesPerDepartment() {
    var departmentId = document.getElementById("depId").value;

    var xhr = new XMLHttpRequest();
    xhr.open("GET", "/employees/department/" + departmentId, true);
    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4 && xhr.status == 200) {
            var employees = JSON.parse(xhr.responseText);

            updateEmployeeTable(employees);
        }
    };
    xhr.send();
}

function getAllManagersPerDepartment() {
    // Get the departmentId from the input field
    var departmentId = document.getElementById("deptId").value;

    // Make an AJAX request to your Spring Boot server
    var xhr = new XMLHttpRequest();
    xhr.open("GET", "/managers/" + departmentId, true);
    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4 && xhr.status == 200) {
            // Parse the JSON response
            var managers = JSON.parse(xhr.responseText);

            updateManagerTable(managers);
        }
    };
    xhr.send();
}

function updateManagerTable(managers) {

    var tableBody = document.getElementById("managerTableBodyPerDepartment");

    tableBody.innerHTML = "";

    for (var i = 0; i < managers.length; i++) {
        var manager = managers[i];
        var row = tableBody.insertRow(i);
        // Insert cells with manager data
        var cell1 = row.insertCell(0);
        cell1.innerHTML = manager.id;
        var cell2 = row.insertCell(1);
        cell2.innerHTML = manager.employeeName;
        var cell3 = row.insertCell(2);
        cell3.innerHTML = manager.departmentId;
        var cell4 = row.insertCell(3);
        cell4.innerHTML = manager.managerId;
        var cell5 = row.insertCell(4);
        cell5.innerHTML = manager.email;
    }
}



function updateEmployeeTable(employees) {
    // Get the table body element
    var tableBody = document.getElementById("employeeTableBodyPerDepartment");

    // Clear the existing table rows
    tableBody.innerHTML = "";

    for (var i = 0; i < employees.length; i++) {
        var employee = employees[i];
        var row = tableBody.insertRow(i);
        var cell1 = row.insertCell(0);
        cell1.innerHTML = employee.id;
        var cell2 = row.insertCell(1);
        cell2.innerHTML = employee.employeeName;
        var cell3 = row.insertCell(2);
        cell3.innerHTML = employee.departmentId;
        var cell4 = row.insertCell(3);
        cell4.innerHTML = employee.managerId;
        var cell5 = row.insertCell(4);
        cell5.innerHTML = employee.email;
    }
}



function errorHandler(xhr, status, error) {
    console.error("Error status: " + status);
    console.error("Error details: " + error);
    alert("Error occurred while processing the request. Check the console for details.");
}