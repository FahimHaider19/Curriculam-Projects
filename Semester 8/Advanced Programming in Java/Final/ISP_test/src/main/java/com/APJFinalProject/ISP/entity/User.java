package com.APJFinalProject.ISP.entity;

import lombok.Data;

import javax.persistence.*;
import java.util.List;

@Entity()
@Data
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer userId;
    private String firstName;
    private String lastName;
    private String email;
    private String password;
    private String role;
    private boolean enabled;
    private String connectionStatus="Inactive";
    @OneToMany(mappedBy = "user")
    private List<Payment> payments;
    @OneToOne(mappedBy = "user")
    private IpAddress ipAddress;
    @ManyToOne()
    @JoinColumn(name = "users")
    private InternetPackage internetPackage;
    @OneToMany(mappedBy = "user")
    private List<Ticket> tickets;

}