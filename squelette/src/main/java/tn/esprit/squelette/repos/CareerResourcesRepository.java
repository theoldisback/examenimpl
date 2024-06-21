package tn.esprit.squelette.repos;

import org.springframework.data.jpa.repository.JpaRepository;
import tn.esprit.squelette.entities.CareerResources;

public interface CareerResourcesRepository extends JpaRepository<CareerResources, Long> {
}