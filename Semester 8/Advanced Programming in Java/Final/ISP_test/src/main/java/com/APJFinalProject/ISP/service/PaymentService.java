package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.Payment;

import java.util.List;

public interface PaymentService {
    public Payment save(Payment payment);

    public List<Payment> findAll();
}
