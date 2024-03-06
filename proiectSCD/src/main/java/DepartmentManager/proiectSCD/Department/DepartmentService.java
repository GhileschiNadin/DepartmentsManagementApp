package DepartmentManager.proiectSCD.Department;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class DepartmentService {

    @Autowired
    DepartmentRepository departmentRepository;

    public List<Department> getAllDepartments(){
        return departmentRepository.findAll();
    }

    public Optional<Department> getDepartmentById(int id) { return departmentRepository.findById(id); }

    public Department saveDepartment(Department department) { return departmentRepository.save(department); }

    public Department updateDepartment(int id, Department updatedDepartment) {
        if (departmentRepository.existsById(id)) {
            updatedDepartment.setId(id);
            return departmentRepository.save(updatedDepartment);
        } else {
            return null;
        }
    }

    public void deleteDepartment(int id) { departmentRepository.deleteById(id); }
}
