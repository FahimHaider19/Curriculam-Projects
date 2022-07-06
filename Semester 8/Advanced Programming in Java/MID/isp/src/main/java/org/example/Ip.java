package org.example;

public class Ip {
    String ip;
    int userId;

    public Ip() {
    }

    public Ip(String ip, int userId) {
        this.ip = ip;
        this.userId = userId;
    }

    public String getIp() {

        return ip;
    }

    public void setIp(String ip) {

        this.ip = ip;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }
}
