package org.example.view;

import org.example.Ip;
import org.example.Payment;
import org.example.Ticket;
import org.example.User;
import org.example.dao.Dao;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.List;

public class EmployeeForm {
    public JPanel panel1;
    private JPanel contentPanel;
    private JPanel panelEmployeeHome;
    private JPanel panelEmployeePayments;
    private JTable tablePayments;
    private JPanel panelEmployeeTickets;
    private JButton markSolvedButton;
    private JTextField textFieldTicketId;
    private JTable tableTickets;
    private JPanel panelEmployeeUsers;
    private JTabbedPane tabbedPane;
    private JScrollPane JScrollPaneCustomer;
    private JTable tableCustomer;
    private JTextField textFieldUserId;
    private JTextField textFieldIpAddress;
    private JButton setIPButton;
    private JTable tableIp;
    private JButton buttonEmployeeHome;
    private JButton buttonEmployeeUsers;
    private JButton buttonEmployeePayments;
    private JButton buttonEmployeeTickets;
    private JButton buttonEmployeeLogout;
    private JTextField textFieldID;
    private JTextField textFieldFirstName;
    private JTextField textFieldLastName;
    private JTextField textFieldEmail;
    private JTextField textFieldPhone;
    private JTextField textFieldNid;
    private JTextField textFieldAddress;
    private JPasswordField passwordField;
    private JPasswordField confirmPasswordField;
    private JButton buttonEditUser;
    private JFrame parentFrame;
    private User u;
    private Dao dao;

    private boolean verifyUserForm(){
        String s = textFieldID.getText();
        System.out.println(s);
        if(textFieldID.getText().equals("") ||
                textFieldFirstName.getText().equals("") ||
                textFieldLastName.getText().equals("") ||
                textFieldEmail.getText().equals("") ||
                textFieldPhone.getText().equals("") ||
                textFieldNid.getText().equals("") ||
                textFieldAddress.getText().equals(""))
            return false;
        return true;
    }

    private void textfieldEditable(boolean b){
        textFieldID.setEditable(b);
        textFieldFirstName.setEditable(b);
        textFieldLastName.setEditable(b);
        textFieldEmail.setEditable(b);
        passwordField.setEditable(b);
        confirmPasswordField.setEditable(b);
        textFieldPhone.setEditable(b);
        textFieldNid.setEditable(b);
        textFieldAddress.setEditable(b);
        //textFieldStatus.setEditable(b);

        if(b==false) confirmPasswordField.setText("");
    }
    private void updateUserInfo(){
        textFieldID.setText(""+u.getId());
        textFieldFirstName.setText(u.getFirstName());
        textFieldLastName.setText(u.getLastName());
        textFieldEmail.setText(u.getEmail());
        passwordField.setText(u.getPassword());
        textFieldPhone.setText(u.getPhone());
        textFieldNid.setText(u.getNid());
        textFieldAddress.setText((u.getAddress()));
        //textFieldStatus.setText(u.getStatus());
    }

    void TablePaymentUpdate(){
        List<Payment> o = dao.getAllPayments();

        DefaultTableModel model = new DefaultTableModel();
        tablePayments.setAutoCreateRowSorter(true);
        tablePayments.setFillsViewportHeight(true);
        tablePayments.setPreferredScrollableViewportSize(new Dimension(550, 200));
        model.addColumn("Payment ID");
        model.addColumn("User ID");
        model.addColumn("Payment Date");
        model.addColumn("Amount");
        tablePayments.setModel(model);
        //tablePayment = new JTable(model);
        //tablePayment.setVisible(true);
        for(Payment l : o){
            Object row[] = {l.getPaymentId(), l.getUserId(), l.getDate(), l.getAmount()};
            model.addRow(row);
        }
    }

    void TableTicketUpdate(){
        List<Ticket> tickets = dao.getAllTickets();

        DefaultTableModel modelTable = new DefaultTableModel();
        tableTickets.setAutoCreateRowSorter(true);
        tableTickets.setFillsViewportHeight(true);
        tableTickets.setPreferredScrollableViewportSize(new Dimension(550, 200));
        modelTable.addColumn("Ticket ID");
        modelTable.addColumn("User ID");
        modelTable.addColumn("Subject");
        modelTable.addColumn("Description");
        modelTable.addColumn("EMP ID");
        modelTable.addColumn("Status");

        tableTickets.setModel(modelTable);
        //tablePayment = new JTable(modelTable);
        //tablePayment.setVisible(true);
        for(Ticket ticket : tickets){
            Object row[] = {ticket.getTicketId(), ticket.getUserId(), ticket.getSubject(), ticket.getDescription(), ticket.getEmpId(), ticket.getStatus()};
            modelTable.addRow(row);
        }
    }

    void TableUserUpdate(){
        List<User> u = dao.getAllUsers();
        DefaultTableModel modelTable = new DefaultTableModel();
        tableCustomer.setAutoCreateRowSorter(true);
        tableCustomer.setFillsViewportHeight(true);
        tableCustomer.setPreferredScrollableViewportSize(new Dimension(550, 200));
        modelTable.addColumn("User ID");
        modelTable.addColumn("First Name");
        modelTable.addColumn("Last Name");
        modelTable.addColumn("Email");
        modelTable.addColumn("Password");
        modelTable.addColumn("Phone");
        modelTable.addColumn("NID");
        modelTable.addColumn("Address");
        modelTable.addColumn("Status");
        tableCustomer.setModel(modelTable);
        for(User user : u){
            if(user.getUserType().equals("Customer")) {
                Object row[] = {user.getId(), user.getFirstName(), user.getLastName(), user.getEmail(), user.getPassword(), user.getPhone(), user.getNid(), user.getAddress(), user.getStatus()};
                modelTable.addRow(row);
            }
        }


        List<Ip> ip = dao.getAllIp();
        DefaultTableModel modelTable2 = new DefaultTableModel();
        tableIp.setAutoCreateRowSorter(true);
        tableIp.setFillsViewportHeight(true);
        tableIp.setPreferredScrollableViewportSize(new Dimension(550, 200));
        modelTable2.addColumn("IP Address");
        modelTable2.addColumn("User ID");
        tableIp.setModel(modelTable2);
        for(Ip i : ip){
            Object row[] = {i.getIp(), i.getUserId()};
            modelTable2.addRow(row);
        }
    }
    public EmployeeForm(User u, JFrame parent) {
        parentFrame = parent;
        this.u = u;
        updateUserInfo();
        ApplicationContext applicationContext1 = new ClassPathXmlApplicationContext("application-context.xml");
        dao = applicationContext1.getBean("userDao", Dao.class);
        TablePaymentUpdate();

        buttonEmployeeHome.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                panelEmployeeHome.setVisible(true);
                panelEmployeeUsers.setVisible(false);
                panelEmployeeTickets.setVisible(false);
                panelEmployeePayments.setVisible(false);
                updateUserInfo();
            }
        });
        buttonEmployeeUsers.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                panelEmployeeUsers.setVisible(true);
                panelEmployeeHome.setVisible(false);
                panelEmployeeTickets.setVisible(false);
                panelEmployeePayments.setVisible(false);
                TableUserUpdate();
            }
        });
        buttonEmployeePayments.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                panelEmployeePayments.setVisible(true);
                panelEmployeeUsers.setVisible(false);
                panelEmployeeTickets.setVisible(false);
                panelEmployeeUsers.setVisible(false);
                TablePaymentUpdate();
            }
        });
        buttonEmployeeTickets.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                panelEmployeeTickets.setVisible(true);
                panelEmployeeUsers.setVisible(false);
                panelEmployeePayments.setVisible(false);
                panelEmployeeUsers.setVisible(false);
                TableTicketUpdate();
            }
        });
        buttonEmployeeLogout.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                parentFrame.setTitle("Login");
                Login l = new Login(parentFrame);
                parentFrame.setContentPane(l.panel1);
                parentFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                parentFrame.pack();
                parentFrame.setVisible(true);
            }
        });
        buttonEditUser.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                if(buttonEditUser.getText().equals("Edit")){
                    buttonEditUser.setText("Save");
                    textfieldEditable(true);
                }
                else{
                    String p = new String(passwordField.getPassword());
                    String cp = new String(confirmPasswordField.getPassword());
                    if(!p.equals(cp)){
                        JOptionPane.showMessageDialog(null,
                                "Confirm password mismatch");
                    }
                    else if(verifyUserForm()) {
                        buttonEditUser.setText("Edit");
                        textfieldEditable(false);
                    }
                    else{
                        JOptionPane.showMessageDialog(null,
                                "Please insert required details");
                    }
                }
            }
        });
        markSolvedButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                int count = dao.executeNonQuery("update ticket set status='Solved' where ticketid="+textFieldTicketId.getText()+"");
                if(count>0) {
                    JOptionPane.showMessageDialog(null,"Ticket Updated");
                    updateUserInfo();
                }
                else
                    JOptionPane.showMessageDialog(null,"Action Failed");
            }
        });
        setIPButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                int count = dao.executeNonQuery("update ip set userid='"+textFieldUserId.getText()+"' where ipaddress='"+textFieldIpAddress.getText()+"'");
                if(count>0) {
                    JOptionPane.showMessageDialog(null,"IP Updated");
                    updateUserInfo();
                }
                else
                    JOptionPane.showMessageDialog(null,"Action Failed");
            }
        });
    }

    private void createUIComponents() {
        // TODO: place custom component creation code here
    }
}
