package DepartmentManager.proiectSCD.Employee;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class EmployeeService {

    @Autowired
    EmployeeRepository employeeRepository;

    public List<Employee> getAllEmplyees() {
        return employeeRepository.findAll();
    }

    public Optional<Employee> getEmployeeById(int id) { return employeeRepository.findById(id); }

    public Employee saveEmployee(Employee employee) { return employeeRepository.save(employee); }


    public Employee updateEmployee(int id, Employee updatedEmployee) {
        if (employeeRepository.existsById(id)) {
            updatedEmployee.setId(id);
            return employeeRepository.save(updatedEmployee);
        } else {
            return null;
        }
    }

    public void deleteEmployee(int id) { employeeRepository.deleteById(id); }

    public List<Employee> getAllEmployeesPerDepartment(int departmentId) {
        return employeeRepository.findAllEmployeesByDepartmentId(departmentId);
    }

    public List<Employee> getAllManagersPerDepartment(int departmentId) {
        return employeeRepository.findAllManagersByDepartmentId(departmentId);
    }

}
