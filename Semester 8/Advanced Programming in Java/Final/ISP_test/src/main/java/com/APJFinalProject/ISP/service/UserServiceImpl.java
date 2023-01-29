package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.User;
import com.APJFinalProject.ISP.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class UserServiceImpl implements UserService {

    @Autowired
    private UserRepository userRepository;

//    @Autowired
//    private PasswordEncoder passwordEncoder;

    @Override
    public User registerUser(User user) {
        userRepository.save(user);
        return user;
    }

    @Override
    public User findUserByEmail(String email) {
        return userRepository.findByEmail(email);
    }

    @Override
    public List<User> findAll() {
        return userRepository.findAll();
    }

    @Override
    public User findById(int userId) {
        return userRepository.findUserByUserId(userId);
    }

    @Override
    public User save(User user) {
        userRepository.save(user);
        return user;
    }


//    @Override
//    public void save() {
//        userRepository.save(user);
//    }
}