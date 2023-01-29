package com.APJFinalProject.ISP.repository;

import com.APJFinalProject.ISP.entity.Ticket;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface TicketRepository extends JpaRepository<Ticket, Integer> {
    Ticket save(Ticket ticket);
    public List<Ticket> findAll();
}
