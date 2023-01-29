package com.APJFinalProject.ISP.entity;

import lombok.Data;
import org.hibernate.validator.constraints.UniqueElements;

import javax.persistence.*;
@Entity
@Data
public class Payment {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    int paymentID;
    int amount;
    @Column(unique=true)
    String paymentDate;
    @ManyToOne
    @JoinColumn(name = "userId")
    User user;
}
