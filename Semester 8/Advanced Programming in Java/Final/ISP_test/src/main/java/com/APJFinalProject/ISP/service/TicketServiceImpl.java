package com.APJFinalProject.ISP.service;

import com.APJFinalProject.ISP.entity.Ticket;
import com.APJFinalProject.ISP.repository.TicketRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TicketServiceImpl implements TicketService{
    @Autowired
    private TicketRepository ticketRepository;

    @Override
    public List<Ticket> findAll() {
        return ticketRepository.findAll();
    }

    @Override
    public void save(Ticket ticket) {
        ticketRepository.save(ticket);
    }
}
