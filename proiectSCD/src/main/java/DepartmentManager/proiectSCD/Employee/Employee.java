package DepartmentManager.proiectSCD.Employee;
import DepartmentManager.proiectSCD.Department.Department;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import jakarta.persistence.*;
import lombok.Data;

@Entity
@Data
public class Employee {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    int id;

    String employeeName;

    @Column(name = "department_id")
    int departmentId;

    @Column(name = "manager_id")
    int managerId;

    String email;

}
