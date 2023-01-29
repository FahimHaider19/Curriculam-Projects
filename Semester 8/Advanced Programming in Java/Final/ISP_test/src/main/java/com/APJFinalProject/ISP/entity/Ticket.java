package com.APJFinalProject.ISP.entity;

import lombok.Data;

import javax.persistence.*;

@Entity
@Data
public class Ticket {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int ticketId;

    private String subject;
    private String description;
    private String status="Pending";
    @ManyToOne
    @JoinColumn(name = "userId")
    User user;
}
