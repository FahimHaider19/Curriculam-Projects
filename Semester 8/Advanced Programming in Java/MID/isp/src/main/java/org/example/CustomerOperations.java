package org.example;

public interface CustomerOperations {
    boolean requestUpdatePackage(InternetPackage internetPackage);
    boolean makePayment(String cardNumber, String pin);
    boolean openTicket(String subject, String description);
    boolean closeTicket(int ticketId);
}