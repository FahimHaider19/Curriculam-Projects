package com.APJFinalProject.ISP.entity;

import lombok.Data;

import javax.persistence.*;

@Entity
@Data
public class IpAddress {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    String ip;
    @OneToOne
    @JoinColumn(name = "userId")
    User user;
}
