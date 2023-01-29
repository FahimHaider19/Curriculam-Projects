package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.User;

import java.util.List;
import java.util.Optional;

public interface UserService {
    User registerUser(User user);
    User findUserByEmail(String email);
    List<User> findAll();

    User findById(int userId);

    public User save(User user);

}