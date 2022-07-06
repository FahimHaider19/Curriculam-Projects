package org.example.view;
import org.example.User;
import org.example.dao.Dao;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import javax.swing.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.List;

public class Login {
    private JTextField email_textTextField;
    private JTextField pass_textTextField;
    private JButton registrationButton;
    private JButton loginButton;
    private JLabel email;
    private JLabel password;
    public JPanel panel1;

    private JFrame parentFrame;

    public Login(JFrame parent) {
        parentFrame = parent;
        loginButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                if(email_textTextField.getText().equals("") || pass_textTextField.getText().equals(""))
                    JOptionPane.showMessageDialog(null,
                            "Please insert both email and password");
                else{
                    ApplicationContext applicationContext1 = new ClassPathXmlApplicationContext("application-context.xml");
                    Dao dao = applicationContext1.getBean("userDao", Dao.class);
                    List<User> u = dao.login(email_textTextField.getText(), pass_textTextField.getText());
                    if(u.size()> 0) {
                        JOptionPane.showMessageDialog(null, "Login Successful");
                        UserForm uf;
                        AdminForm af;
                        EmployeeForm ef;
                        parentFrame.setTitle("Customer Panel");
                        //System.out.println(u.get(0).getClass().getName());

                        if(u.get(0).getUserType().equals("Customer")) {
                            uf = new UserForm(u.get(0), parentFrame);
                            parentFrame.setContentPane(uf.panel1);
                        }
                        else if(u.get(0).getUserType().equals("Admin")) {
                            af = new AdminForm(u.get(0), parentFrame);
                            parentFrame.setContentPane(af.panel1);
                        } else if (u.get(0).getUserType().equals("Employee")) {
                            ef = new EmployeeForm(u.get(0), parentFrame);
                            parentFrame.setContentPane(ef.panel1);
                        }
                        parentFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                        parentFrame.pack();
                        parentFrame.setVisible(true);
                    }
                    else
                        JOptionPane.showMessageDialog(null, "Invalid id-pass");
                }
            }
        });
        registrationButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                parentFrame.setTitle("Registration");
                Registration r = new Registration(parentFrame);
                parentFrame.setContentPane(r.panel1);
                parentFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                parentFrame.pack();
                parentFrame.setVisible(true);
            }
        });
    }

    private void createUIComponents() {
        // TODO: place custom component creation code here
    }
}
