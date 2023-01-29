package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.Ticket;

import java.util.List;

public interface TicketService {
    public List<Ticket> findAll();
    public void save(Ticket ticket);
}
