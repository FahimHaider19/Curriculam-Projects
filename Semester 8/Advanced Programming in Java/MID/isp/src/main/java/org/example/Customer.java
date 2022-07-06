package org.example;

import org.example.dao.Dao;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Customer extends User implements CustomerOperations{
    String internetPackage;
    String connectionStatus;
    Dao dao;
    public Customer() {
        ApplicationContext applicationContext1 = new ClassPathXmlApplicationContext("application-context.xml");
        dao = applicationContext1.getBean("userDao", Dao.class);
    }

    public Customer(String internetPackage, String connectionStatus) {
        this.internetPackage = internetPackage;
        this.connectionStatus = connectionStatus;
        ApplicationContext applicationContext1 = new ClassPathXmlApplicationContext("application-context.xml");
        dao = applicationContext1.getBean("userDao", Dao.class);
    }

    public String getInternetPackage() {
        return internetPackage;
    }

    public void setInternetPackage(String internetPackage) {
        this.internetPackage = internetPackage;
    }

    public String getConnectionStatus() {
        return connectionStatus;
    }

    public void setConnectionStatus(String connectionStatus) {
        this.connectionStatus = connectionStatus;
    }

    @Override
    public boolean requestUpdatePackage(InternetPackage internetPackage) {
        Ticket t = new Ticket("Update Internet Package",
                this.id,
                "Change internet package to"+internetPackage.getPackageName());
        //push ticket into database
        if(true) return true;
        return false;
    }

    @Override
    public boolean makePayment(String cardNumber, String pin) {
        SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
        Date date = new Date();
        int count = dao.countQuery("\"select count(*) from creditcard where cardnumber=\""+cardNumber+"\" and pin =\""+pin+"\"");
        if(count>0)
            if(dao.executeNonQuery("INSERT INTO payment (userid, date, amount) VALUES ("+this.getId()+", '"+formatter.format(date)+"', "+1500+")") > 0) return true;
        return false;
    }

    @Override
    public boolean openTicket(String subject, String description) {
        Ticket t = new Ticket(subject, this.id, description);
        //push ticket into database
        if(true) return true;
        return false;
    }

    @Override
    public boolean closeTicket(int ticketId) {
        //update ticket status to close
        if(true) return true;
        return false;
    }
}
