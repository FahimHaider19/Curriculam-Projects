package com.APJFinalProject.ISP.repository;

import com.APJFinalProject.ISP.entity.InternetPackage;
import org.springframework.data.jpa.repository.JpaRepository;

public interface InternetPackageRepository extends JpaRepository<InternetPackage, Integer> {
    public InternetPackage save(InternetPackage internetPackage);
}
