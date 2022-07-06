package org.example.view;
import org.example.dao.Dao;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import javax.swing.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class Registration {
    private JTextField textFieldFirstName;
    private JTextField textFieldLastName;
    private JTextField textFieldPhone;
    private JTextField textFieldEmail;
    private JTextField textFieldPassword;
    private JButton confirmRegistrationButton;
    private JButton loginButton;
    private JLabel passwordLabel;
    private JLabel emailLabel;
    private JLabel phoneNumberLabel;
    private JLabel lastNameLabel;
    private JLabel firstNameLabel;
    public JPanel panel1;

    private JFrame parentFrame;

    public Registration(JFrame parent) {
        parentFrame = parent;
        loginButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                parentFrame.setTitle("Registration");
                Login l = new Login(parentFrame);
                parentFrame.setContentPane(l.panel1);
                parentFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                parentFrame.pack();
                parentFrame.setVisible(true);
            }
        });
        confirmRegistrationButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                boolean flag = true;
                ApplicationContext applicationContext1 = new ClassPathXmlApplicationContext("application-context.xml");
                Dao dao = applicationContext1.getBean("userDao", Dao.class);
                int count = dao.countQuery("select count(*) from user where email='"+textFieldEmail.getText()+"'");
                if(count > 0)
                    JOptionPane.showMessageDialog(null, "Duplicate Email Exists");

                else if (textFieldPassword.getText().length() < 6)
                    JOptionPane.showMessageDialog(null, "Password length must be atleast 6");

                else if(textFieldFirstName.getText().equals("") ||
                        textFieldLastName.getText().equals("") ||
                        textFieldEmail.getText().equals("") ||
                        textFieldPhone.getText().equals(""))
                    JOptionPane.showMessageDialog(null, "Fields cannot be empty");
                else {
                    count = dao.executeNonQuery("insert into user (fname, lname, email, password, usertype, phone, status) values('" + textFieldFirstName.getText() + "', '" + textFieldLastName.getText() + "', '" + textFieldEmail.getText() + "', '" + textFieldPassword.getText() + "', 'Customer','" + textFieldPhone.getText() + "', 'Active')");
                    if(count > 0)    JOptionPane.showMessageDialog(null, "Registration successful");
                }
            }
        });
    }
}
