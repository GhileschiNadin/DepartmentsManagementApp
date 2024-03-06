package DepartmentManager.proiectSCD.Department;

import jakarta.persistence.*;
import lombok.Data;

import java.util.List;

@Entity
@Data
public class Department {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
     int id;

     String departmentName;
     String description;

    @ManyToOne
    @JoinColumn(name = "parentId")
     Department parentId;

}
