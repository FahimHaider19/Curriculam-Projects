package com.APJFinalProject.ISP.repository;

import com.APJFinalProject.ISP.entity.Payment;
import com.APJFinalProject.ISP.service.PaymentService;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

import java.util.List;


public interface PaymentRepository  extends JpaRepository<Payment, Integer> {
    Payment save(Payment payment);
    List<Payment> findAll();
}
