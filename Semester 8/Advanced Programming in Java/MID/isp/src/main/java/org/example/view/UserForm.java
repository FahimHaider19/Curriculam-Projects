package org.example.view;

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
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

public class UserForm {
    private User u;
    public JPanel panel1;
    private JButton homeButton;
    private JButton paymentsButton;
    private JButton ticketsButton;
    private JButton logoutButton;
    private JPanel contentPanel;
    private JTextField textFieldID;
    private JButton buttonEditUser;
    private JTextField textFieldFirstName;
    private JTextField textFieldLastName;
    private JTextField textFieldEmail;
    private JTextField textFieldPhone;
    private JTextField textFieldNid;
    private JTextField textFieldAddress;
    private JTextField textFieldPackage;
    private JPasswordField confirmPasswordField;
    private JPasswordField passwordField;
    private JPanel panelCustomerHome;
    private JPanel panelCustomerPayments;
    private JButton makePaymentButton;
    private JTextField textFieldCardNumber;
    private JPasswordField pinField;
    private JTable tablePayment;
    private JPanel panel;
    private JTable tableCustomerPayments;
    private JTextField textFiledConnectionStatus;
    private JPanel panelCustomerTickets;
    private JButton submitNewTicketButton;
    private JTextField textFieldSubject;
    private JTextField textFieldDescription;
    private JTable tableCustomerTickets;

    private JFrame parentFrame;
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
        List<Payment> o = dao.getAllPayments(u.getId());

        DefaultTableModel model = new DefaultTableModel();
        tableCustomerPayments.setAutoCreateRowSorter(true);
        tableCustomerPayments.setFillsViewportHeight(true);
        tableCustomerPayments.setPreferredScrollableViewportSize(new Dimension(550, 200));
        model.addColumn("Payment ID");
        model.addColumn("User ID");
        model.addColumn("Payment Date");
        model.addColumn("Amount");
        tableCustomerPayments.setModel(model);
        //tablePayment = new JTable(model);
        //tablePayment.setVisible(true);
        for(Payment l : o){
            Object row[] = {l.getPaymentId(), l.getUserId(), l.getDate(), l.getAmount()};
            model.addRow(row);
        }
    }
    void TableTicketUpdate(){
        List<Ticket> tickets = dao.getAllTickets(u.getId());

        DefaultTableModel modelTable = new DefaultTableModel();
        tableCustomerTickets.setAutoCreateRowSorter(true);
        tableCustomerTickets.setFillsViewportHeight(true);
        tableCustomerTickets.setPreferredScrollableViewportSize(new Dimension(550, 200));
        modelTable.addColumn("Ticket ID");
        modelTable.addColumn("User ID");
        modelTable.addColumn("Subject");
        modelTable.addColumn("Description");
        modelTable.addColumn("EMP ID");
        modelTable.addColumn("Status");

        tableCustomerTickets.setModel(modelTable);
        //tablePayment = new JTable(modelTable);
        //tablePayment.setVisible(true);
        for(Ticket ticket : tickets){
            Object row[] = {ticket.getTicketId(), ticket.getUserId(), ticket.getSubject(), ticket.getDescription(), ticket.getEmpId(), ticket.getStatus()};
            modelTable.addRow(row);
        }
    }

    public <DDefaultTableModel> UserForm(User u, JFrame parent) {
        parentFrame = parent;
        this.u = u;

        updateUserInfo();

        ApplicationContext applicationContext1 = new ClassPathXmlApplicationContext("application-context.xml");
        dao = applicationContext1.getBean("userDao", Dao.class);

        TablePaymentUpdate();

        homeButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                panelCustomerHome.setVisible(true);
                panelCustomerPayments.setVisible(false);
                panelCustomerTickets.setVisible(false);
                updateUserInfo();
            }
        });

        paymentsButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                panelCustomerPayments.setVisible(true);
                panelCustomerHome.setVisible(false);
                panelCustomerTickets.setVisible(false);
                TablePaymentUpdate();
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

        makePaymentButton.addMouseListener(new MouseAdapter() {
            SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
            Date date = new Date();

            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                int count = dao.countQuery("select count(*) from creditcard where cardnumber='"+textFieldCardNumber.getText()+"' and pin='"+new String(pinField.getPassword())+"'");
                int amount = dao.countQuery("select price from package where packageid=(select packageid from user where id="+u.getId()+")");
                if(count>0)
                    count = dao.executeNonQuery("insert into payment (userid, date, amount) values("+u.getId()+", '"+formatter.format(date)+"', "+amount+")");
                if(count>1) JOptionPane.showMessageDialog(null,
                        "Payment Successful");
                TablePaymentUpdate();
            }
        });
        ticketsButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                panelCustomerTickets.setVisible(true);
                panelCustomerPayments.setVisible(false);
                panelCustomerHome.setVisible(false);
                TableTicketUpdate();
            }
        });
        submitNewTicketButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                super.mouseClicked(e);
                int count = dao.executeNonQuery("insert into ticket (userid, subject, description) values("+u.getId()+", '"+textFieldSubject.getText()+"', '"+textFieldDescription.getText()+"')");
                if(count>1) JOptionPane.showMessageDialog(null,
                        "Ticket submitted, Please wait for further assistance.");
                TableTicketUpdate();

            }

        });
        logoutButton.addMouseListener(new MouseAdapter() {
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
    }

    private void createUIComponents() {
        // TODO: place custom component creation code here
    }
}
