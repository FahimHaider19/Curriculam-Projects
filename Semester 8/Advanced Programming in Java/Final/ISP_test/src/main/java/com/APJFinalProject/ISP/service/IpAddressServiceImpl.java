package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.IpAddress;
import com.APJFinalProject.ISP.repository.IpAddressRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class IpAddressServiceImpl implements IpAddressService{
    @Autowired
    IpAddressRepository ipAddressRepository;

    @Override
    public IpAddress save(IpAddress ipAddress) {
        return ipAddressRepository.save(ipAddress);
    }

    @Override
    public List<IpAddress> findAll() {
        return ipAddressRepository.findAll();
    }
}
