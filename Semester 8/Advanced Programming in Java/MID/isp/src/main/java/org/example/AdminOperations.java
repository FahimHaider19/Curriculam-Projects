package org.example;

public interface AdminOperations {
    boolean addEmployee();
    boolean removeEmployee();
    boolean updateStatus(Customer c, String status);
}