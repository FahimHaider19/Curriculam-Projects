package org.example;

public class Ticket {
    int ticketId;
    String subject;
    int userId;
    String description;
    String status;
    int empId;

    public Ticket() {
    }

    public Ticket(int ticketId, String subject, int userId, String description, String status, int empId) {
        this.ticketId = ticketId;
        this.subject = subject;
        this.userId = userId;
        this.description = description;
        this.status = status;
        this.empId = empId;
    }

    public Ticket(String subject, int userId, String description) {
        this.subject = subject;
        this.userId = userId;
        this.description = description;
    }

    public int getTicketId() {
        return ticketId;
    }

    public void setTicketId(int ticketId) {
        this.ticketId = ticketId;
    }

    public String getSubject() {
        return subject;
    }

    public void setSubject(String subject) {
        this.subject = subject;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public int getEmpId() {
        return empId;
    }

    public void setEmpId(int empId) {
        this.empId = empId;
    }
}