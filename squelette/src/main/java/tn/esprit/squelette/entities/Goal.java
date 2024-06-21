package tn.esprit.squelette.entities;

import com.fasterxml.jackson.annotation.JsonIgnore;
import jakarta.persistence.*;
import lombok.*;
import lombok.experimental.FieldDefaults;

import java.time.LocalDate;
import java.util.Set;


@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@FieldDefaults(level= AccessLevel.PRIVATE)
@Entity
public class Goal {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Setter(AccessLevel.NONE)
    Long goalId;
    String name ;
    String description;
    @Enumerated(EnumType.STRING)
    Status status ;
    LocalDate lastUpdated ;
    LocalDate dueDate ;

    @OneToMany(cascade = CascadeType.ALL, mappedBy="goal")
    private Set<CareerResources> careerResourcess;

}
