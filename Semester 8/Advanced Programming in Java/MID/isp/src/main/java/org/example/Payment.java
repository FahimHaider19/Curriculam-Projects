package org.example;

public class Payment {
    int paymentId;
    int userId;
    String date;
    int amount;
    String paidTill;

    public Payment() {
    }

    public Payment(int paymentId, int userId, String date, int amount) {
        this.paymentId = paymentId;
        this.userId = userId;
        this.date = date;
        this.amount = amount;
    }

    public Payment(int userId, int amount) {
        this.userId = userId;
        this.amount = amount;
    }

    public int getPaymentId() {
        return paymentId;
    }

    public void setPaymentId(int paymentId) {
        this.paymentId = paymentId;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }

    public String getPaidTill() {
        return paidTill;
    }

    public void setPaidTill(String paidTill) {
        this.paidTill = paidTill;
    }
}