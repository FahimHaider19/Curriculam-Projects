package org.example;

import org.example.dao.Dao;
import org.example.view.Login;
import org.example.view.UserForm;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import javax.swing.*;
import java.util.List;

public class App {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            //User u = new Customer();
            @Override
            public void run() {
                JFrame frame = new JFrame();
                frame.setTitle("Login");
                Login l = new Login(frame);
                frame.setContentPane(l.panel1);
                frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                frame.pack();
                frame.setVisible(true);
            }
        });
    }

}
