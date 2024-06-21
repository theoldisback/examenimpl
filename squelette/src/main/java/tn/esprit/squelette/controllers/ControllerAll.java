package tn.esprit.squelette.controllers;


import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;
import tn.esprit.squelette.entities.Goal;
import tn.esprit.squelette.entities.User;
import tn.esprit.squelette.services.IServiceAll;

import java.util.List;


@RestController
@RequiredArgsConstructor
public class ControllerAll {
    private  final IServiceAll serviceAll ;


    @PostMapping("/createUser")
    public User createUser(@RequestBody User u ){
        return serviceAll.createUser(u);
    }
    @PostMapping("/addGoal/{username}")
    public Goal addGoal(@RequestBody Goal goal , @PathVariable String username){
        return serviceAll.addGoal(goal , username);
    }

    @GetMapping("/calculateProgress")
    public double calculateProgress(@RequestParam Long goalId){
        return serviceAll.calculateProgress(goalId);
    }

}
