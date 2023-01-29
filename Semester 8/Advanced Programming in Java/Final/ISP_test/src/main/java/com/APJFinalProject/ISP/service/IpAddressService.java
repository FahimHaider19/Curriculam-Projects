package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.IpAddress;
import com.APJFinalProject.ISP.entity.Payment;

import java.util.List;

public interface IpAddressService {
    public IpAddress save(IpAddress ipAddress);
    public List<IpAddress> findAll();
}