package tn.esprit.squelette.repos;

import org.springframework.data.jpa.repository.JpaRepository;
import tn.esprit.squelette.entities.User;

public interface UserRepository extends JpaRepository<User, Long> {
    User findByName(String name);


}