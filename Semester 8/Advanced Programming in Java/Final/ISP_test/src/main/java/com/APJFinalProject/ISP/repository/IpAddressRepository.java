package com.APJFinalProject.ISP.repository;

import com.APJFinalProject.ISP.entity.IpAddress;
import com.APJFinalProject.ISP.entity.User;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface IpAddressRepository  extends JpaRepository<IpAddress, Integer> {
    public List<IpAddress> findAll();
}
