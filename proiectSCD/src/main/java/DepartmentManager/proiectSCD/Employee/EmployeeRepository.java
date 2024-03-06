package DepartmentManager.proiectSCD.Employee;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface EmployeeRepository extends JpaRepository<Employee,Integer> {


    @Query("SELECT e FROM Employee e WHERE e.departmentId = :departmentId")
    List<Employee> findAllEmployeesByDepartmentId(@Param("departmentId") int departmentId);

    @Query("SELECT e FROM Employee e WHERE e.departmentId = :departmentId AND e.id = e.managerId")
    List<Employee> findAllManagersByDepartmentId(@Param("departmentId") int departmentId);
}
