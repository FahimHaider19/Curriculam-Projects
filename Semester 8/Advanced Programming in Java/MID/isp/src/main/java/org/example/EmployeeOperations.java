package org.example;

public interface EmployeeOperations {
    default boolean setIp(Customer c, String IP){
        //update database customer ip...check if another user has same ip
        if(true) return true;
        return false;
    }
    default boolean setPackage(Customer c, InternetPackage Package){
        //update database customer package...
        if(true) return true;
        return false;
    }
    default boolean updateTicket(int ticketId, String status){
        //update ticket status
        if(true) return true;
        return false;
    }
}