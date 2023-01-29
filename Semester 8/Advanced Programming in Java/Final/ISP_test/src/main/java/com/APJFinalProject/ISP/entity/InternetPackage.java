package com.APJFinalProject.ISP.entity;

import lombok.Data;

import javax.persistence.*;
import java.util.List;

@Entity
@Data
public class InternetPackage {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    int internetPackageId;
    String PackageName;
    int price;
    @OneToMany(mappedBy = "internetPackage")
    List<User> users;
}
