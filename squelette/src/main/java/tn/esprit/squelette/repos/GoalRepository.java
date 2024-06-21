package tn.esprit.squelette.repos;

import org.springframework.data.jpa.repository.JpaRepository;
import tn.esprit.squelette.entities.Goal;

public interface GoalRepository extends JpaRepository<Goal, Long> {
}