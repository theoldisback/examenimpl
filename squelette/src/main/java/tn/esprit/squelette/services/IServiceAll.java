package tn.esprit.squelette.services;

import tn.esprit.squelette.entities.Goal;
import tn.esprit.squelette.entities.User;

public interface IServiceAll {

    User createUser(User u);

    Goal addGoal(Goal goal, String username);

    double calculateProgress(Long goalId);
}
