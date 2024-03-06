package DepartmentManager.proiectSCD.Employee;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
public class EmployeeController {

    @Autowired
    EmployeeService employeeService;

    @GetMapping("/employee")
    public List<Employee> getAllEmployees() {
        return employeeService.getAllEmplyees();
    }

    @GetMapping("/employee/{id}")
    public Optional<Employee> getEmployeeById(@PathVariable int id) { return employeeService.getEmployeeById(id); }

    @PostMapping("/employeePST")
    public Employee createEmployee(@RequestBody Employee employee) {
        return employeeService.saveEmployee(employee);
    }

    @PutMapping("/employee/{id}")
    public Employee updateEmployee(@PathVariable int id, @RequestBody Employee updatedEmployee) {
        return employeeService.updateEmployee(id, updatedEmployee);
    }

    @DeleteMapping("/employee/{id}")
    public void deleteEmployee(@PathVariable int id) { employeeService.deleteEmployee(id); }

    @GetMapping("/employees/department/{departmentId}")
    public List<Employee> getAllEmployeesPerDepartment(@PathVariable int departmentId) {
        return employeeService.getAllEmployeesPerDepartment(departmentId);
    }

    @GetMapping("managers/{departmentId}")
    public List<Employee> getAllManagersPerDepartment(@PathVariable int departmentId) {
        return employeeService.getAllManagersPerDepartment(departmentId);
    }

}
