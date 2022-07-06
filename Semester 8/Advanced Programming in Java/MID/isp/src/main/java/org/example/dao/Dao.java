package org.example.dao;

import org.example.App.*;
import org.example.*;
import org.springframework.jdbc.core.JdbcTemplate;

import javax.sql.DataSource;
import java.sql.ResultSet;
import java.util.List;

public class Dao {

    private JdbcTemplate jdbcTemplate;

    public Dao(DataSource dataSource) {
        this.jdbcTemplate = new JdbcTemplate(dataSource);
    }

    public List<User> getAllUsers() {
        return this.jdbcTemplate.query(
                "select * from user",
                (resultSet, rowNum) -> {
                    User user = new User(
                            resultSet.getInt("id"),
                            resultSet.getString("fname"),
                            resultSet.getString("lname"),
                            resultSet.getString("email"),
                            resultSet.getString("password"),
                            resultSet.getString("phone"),
                            resultSet.getString("nid"),
                            resultSet.getString("address"),
                            resultSet.getString("status"),
                            resultSet.getString("usertype")
                    );
                    return user;
                });
    }

    public List<User> login(String email, String password) {
        return this.jdbcTemplate.query(
                "select * from user where email='"+email+"' and password='"+password+"'",
                (resultSet, rowNum) -> {
                    User user = new User(
                            resultSet.getInt("id"),
                            resultSet.getString("fname"),
                            resultSet.getString("lname"),
                            resultSet.getString("email"),
                            resultSet.getString("password"),
                            resultSet.getString("phone"),
                            resultSet.getString("nid"),
                            resultSet.getString("address"),
                            resultSet.getString("status"),
                            resultSet.getString("usertype")
                    );
                    return user;
                });
    }
    public int countQuery(String sql){
        return this.jdbcTemplate.queryForObject(sql, Integer.class);
    }
    public List<User> ladasd(String email, String password){
//        String sql = "Select count(*) from user where email=\""+email+"\" and password=\""+password+"\"";
//        return this.jdbcTemplate.queryForObject(sql, Integer.class);
        return this.jdbcTemplate.query(
                "select * from user",
                (resultSet, rowNum) -> {
                    User user = new User(
                            resultSet.getInt("id"),
                            resultSet.getString("fname"),
                            resultSet.getString("lname"),
                            resultSet.getString("email"),
                            resultSet.getString("password"),
                            resultSet.getString("phone"),
                            resultSet.getString("nid"),
                            resultSet.getString("address"),
                            resultSet.getString("status"),
                            resultSet.getString("userType")
                    );
                    return user;
                });
    }

    public List<Ticket> getAllTickets() {
        return this.jdbcTemplate.query(
                "select * from ticket",
                (resultSet, rowNum) -> {
                    Ticket ticket = new Ticket(
                            resultSet.getInt("ticketid"),
                            resultSet.getString("subject"),
                            resultSet.getInt("userid"),
                            resultSet.getString("description"),
                            resultSet.getString("status"),
                            resultSet.getInt("empid")
                    );
                    return ticket;
                });
    }

    public List<Ticket> getAllTickets(int id) {
        return this.jdbcTemplate.query(
                "select * from ticket where userid="+id,
                (resultSet, rowNum) -> {
                    Ticket ticket = new Ticket(
                            resultSet.getInt("ticketid"),
                            resultSet.getString("subject"),
                            resultSet.getInt("userid"),
                            resultSet.getString("description"),
                            resultSet.getString("status"),
                            resultSet.getInt("empid")
                    );
                    return ticket;
                });
    }

    public List<Payment> getAllPayments() {
        return this.jdbcTemplate.query(
                "select * from payment",
                (resultSet, rowNum) -> {
                    Payment payment = new Payment(
                            resultSet.getInt("paymentid"),
                            resultSet.getInt("userid"),
                            resultSet.getString("date"),
                            resultSet.getInt("amount")
                    );
                    return payment;
                });
    }

    public List<Payment> getAllPayments(int id) {
        return this.jdbcTemplate.query(
                "select * from payment where userid="+id,
                (resultSet, rowNum) -> {
                    Payment payment = new Payment(
                            resultSet.getInt("paymentid"),
                            resultSet.getInt("userid"),
                            resultSet.getString("date"),
                            resultSet.getInt("amount")
                    );
                    return payment;
                });
    }

    public List<Ip> getAllIp(){
        return this.jdbcTemplate.query(
                "select * from ip",
                (resultSet, rowNum) -> {
                    Ip ip = new Ip(
                            resultSet.getString("ipaddress"),
                            resultSet.getInt("userid")
                    );
                    return ip;
                });
    }
    public int executeNonQuery(String sql){
        return this.jdbcTemplate.update(sql);
    }
}
