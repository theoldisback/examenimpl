package tn.esprit.squelette.services;


import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;
import tn.esprit.squelette.entities.Goal;
import tn.esprit.squelette.entities.Status;
import tn.esprit.squelette.entities.User;
import tn.esprit.squelette.repos.CareerResourcesRepository;
import tn.esprit.squelette.repos.GoalRepository;
import tn.esprit.squelette.repos.UserRepository;

import java.time.LocalDate;


@RequiredArgsConstructor
@Service
@Slf4j
public class ServiceAll implements IServiceAll{

    private final UserRepository userRepository;
    private  final GoalRepository goalRepository;
    private final CareerResourcesRepository careerResourcesRepository;
    @Override
    public User createUser(User u) {
        return this.userRepository.save(u);
    }

    @Override
    public Goal addGoal(Goal goal, String username) {
        User user = this.userRepository.findByName(username);
        goal.setStatus(Status.ACTIVE);
        goal.setLastUpdated(LocalDate.now());
        this.goalRepository.save(goal);
        goal.getCareerResourcess().forEach(
                careerResources -> {
                    careerResources.setCompleted(false);
                    careerResources.setGoal(goal);
                    this.careerResourcesRepository.save(careerResources);
                }
        );
        user.getGoals().add(goal);
        this.userRepository.save(user);
        return goal ;
    }

    @Override
    public double calculateProgress(Long goalId) {
        Goal goal = this.goalRepository.findById(goalId).orElse(null);
        double totale = 0 ;
        if(goal != null){
            long total = goal.getCareerResourcess().size();
            long completed = goal.getCareerResourcess().stream().filter(careerResources -> careerResources.isCompleted()).count();
            return (completed * 100) / total;
        }
        return totale;
    }
}
