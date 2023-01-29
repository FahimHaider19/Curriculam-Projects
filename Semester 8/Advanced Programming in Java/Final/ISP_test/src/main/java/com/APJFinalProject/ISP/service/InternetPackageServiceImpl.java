package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.InternetPackage;
import com.APJFinalProject.ISP.repository.InternetPackageRepository;
import com.APJFinalProject.ISP.repository.PaymentRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class InternetPackageServiceImpl implements InternetPackageService {
    @Autowired
    InternetPackageRepository internetPackageRepository;

    @Override
    public InternetPackage save(InternetPackage internetPackage) {
        return internetPackageRepository.save(internetPackage);
    }
}
