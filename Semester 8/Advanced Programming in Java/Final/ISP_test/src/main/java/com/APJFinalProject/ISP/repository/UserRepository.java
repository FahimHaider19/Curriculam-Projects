package com.APJFinalProject.ISP.repository;

import com.APJFinalProject.ISP.entity.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface UserRepository extends JpaRepository<User, Integer> {
    User findByEmail(String email);

    List<User> findAll();

    User findUserByUserId(int userId);

    User save(User user);
}