package com.APJFinalProject.ISP.controller;

import com.APJFinalProject.ISP.entity.InternetPackage;
import com.APJFinalProject.ISP.entity.Payment;
import com.APJFinalProject.ISP.entity.Ticket;
import com.APJFinalProject.ISP.entity.User;
import com.APJFinalProject.ISP.model.UserModel;
import com.APJFinalProject.ISP.repository.PaymentRepository;
import com.APJFinalProject.ISP.repository.UserRepository;
import com.APJFinalProject.ISP.service.PaymentService;
import com.APJFinalProject.ISP.service.TicketService;
import com.APJFinalProject.ISP.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.context.SecurityContext;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.authentication.logout.SecurityContextLogoutHandler;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.context.request.RequestContextHolder;
import org.springframework.web.context.request.ServletRequestAttributes;

import javax.servlet.http.HttpServletRequest;
import javax.swing.*;
import javax.validation.Valid;
import java.sql.Array;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

@Controller
public class UserController {

    @Autowired
    private UserService userService;
    @Autowired
    private TicketService ticketService;

    @Autowired
    private PaymentService paymentService;

    @Autowired
    private PaymentService ipAddressService;
//    @Autowired
//    private PaymentRepository paymentRepository;

    @Autowired
    private PasswordEncoder passwordEncoder;

    @GetMapping("/change-password")
    public String updatePassword(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        model.addAttribute("loggedInUser", user );
        return "ChangePassword";
    }

    @PostMapping("/change-password")
    public @ResponseBody String changePassword(@ModelAttribute("user") User user, BindingResult result){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User u = userService.findUserByEmail(securityContext.getAuthentication().getName());
        u.setPassword(passwordEncoder.encode(user.getPassword()));
        userService.save(u);
        return "ChangePassword";
    }

    @GetMapping("/home")
    public String home(Model model){
        //System.out.printf(userService.findUserByEmail("fhmhaider19@gmail.com").getFirstName());
        //return "HOME";
        model.addAttribute("users", userService.findAll());
        SecurityContext securityContext = SecurityContextHolder.getContext();
        System.out.println(securityContext.getAuthentication().getName());
        return "Users";
    }

    @GetMapping("/home2")
    public String home2(Model model){
        //System.out.printf(userService.findUserByEmail("fhmhaider19@gmail.com").getFirstName());
        //return "HOME";
        model.addAttribute("users", userService.findAll());
        SecurityContext securityContext = SecurityContextHolder.getContext();
        System.out.println(securityContext.getAuthentication().getName());
        return "Users";
    }

    @GetMapping("/login")
    public String login(Model model){
        if(SecurityContextHolder.getContext().getAuthentication().getName().equals("anonymousUser"))
            return "Login";
        else {
            User loggedInUser = userService.findUserByEmail(SecurityContextHolder.getContext().getAuthentication().getName());
            model.addAttribute("loggedInUser", loggedInUser);
            model.addAttribute("user", loggedInUser);
            return "Profile";
        }
    }


    @GetMapping("/logout")
    public void logout(){
        HttpServletRequest request =
                ((ServletRequestAttributes) RequestContextHolder.getRequestAttributes())
                        .getRequest();
        new SecurityContextLogoutHandler().logout(request, null, null);
    }

    @GetMapping("/register")
    public String register(Model model){

        if(SecurityContextHolder.getContext().getAuthentication().getName().equals("anonymousUser"))
            return "Registration";
        else {
            User loggedInUser = userService.findUserByEmail(SecurityContextHolder.getContext().getAuthentication().getName());
            model.addAttribute("loggedInUser", loggedInUser);
            model.addAttribute("user", loggedInUser);
            return "Profile";
        }
    }

    @PostMapping("/register")
    public @ResponseBody String register(@ModelAttribute("user") User user, BindingResult result){
        boolean flag = true;
        for(User u : userService.findAll())
            if(u.getEmail().equals(user.getEmail())){
                flag = false;
                break;
            }
        if(flag){
//            user = new User();
//            user.setEmail(user.getEmail());
//            user.setFirstName(user.getFirstName());
//            user.setLastName(user.getLastName());
            user.setRole("user");
            user.setPassword(passwordEncoder.encode(user.getPassword()));
//            user.setPassword();
            userService.registerUser(user);
            return "Home";
        }
        else return "Error";
    }


    @PostMapping("/profile")
    public @ResponseBody String updateProfile(@ModelAttribute("user") User user, BindingResult result){
        User u = userService.findById(user.getUserId());
        user.setRole(u.getRole());
        user.setPassword(u.getPassword());
        user.setConnectionStatus(u.getConnectionStatus());
        user.setEnabled(u.isEnabled());
        userService.save(user);
        return "Profile";
    }

    @GetMapping("/profile")
    public String profile(Model model){
        //model.addAttribute("user", userService.findUserByEmail("fhmhaider19@gmail.com"));
        User loggedInUser = userService.findUserByEmail(SecurityContextHolder.getContext().getAuthentication().getName());
        model.addAttribute("loggedInUser", loggedInUser);
        model.addAttribute("user", loggedInUser);
        return "Profile";
    }

    @GetMapping("/profile/{userId}")
    public String profile(Model model, @PathVariable int userId){
        User u = null;
        for(User us : userService.findAll()){
            if(us.getUserId() == userId)
                u=us;
        }
        model.addAttribute("user", u);
        User loggedInUser = userService.findUserByEmail(SecurityContextHolder.getContext().getAuthentication().getName());
        model.addAttribute("loggedInUser", loggedInUser);
        if(loggedInUser.getRole().equals("admin") || loggedInUser.getRole().equals("admin"))
            return "Profile";
        else
            return "Error";
    }

    @GetMapping("/make-payment")
    public String MakePaymentPage(Model model){
        User loggedInUser = userService.findUserByEmail(SecurityContextHolder.getContext().getAuthentication().getName());
        model.addAttribute("user", loggedInUser);
        if(loggedInUser.getRole().equals("user"))
            return "MakePayment";
        else return "Error";
    }

    @PostMapping("/make-payment")
    public void MakePayment(){
        Date date = Calendar.getInstance().getTime();
        DateFormat dateFormat = new SimpleDateFormat("yyyy-M");
        String strDate = dateFormat.format(date);
        User user = userService.findUserByEmail(SecurityContextHolder.getContext().getAuthentication().getName());
        Payment payment =  new Payment();
        payment.setPaymentDate(strDate);
        payment.setAmount(user.getInternetPackage().getPrice());
        //payment.setAmount(1500);
        payment.setUser(user);
        paymentService.save(payment);
    }

    @GetMapping("/test")
    public String test(){
        User user = userService.findUserByEmail(SecurityContextHolder.getContext().getAuthentication().getName());
        InternetPackage i = new InternetPackage();
        i.setPrice(1200);
        i.setPackageName("Platinum");
        i.setInternetPackageId(2);
        user.setInternetPackage(i);
        userService.save(user);
        return "Home";
    }

    @GetMapping("/ticket")
    public String tickets(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        List<Ticket> tickets = new ArrayList<Ticket>();
        if(user.getRole().equals("user")){
            for(Ticket t : ticketService.findAll()){
                if(t.getUser().getUserId() == user.getUserId())
                    tickets.add(t);
            }
            model.addAttribute("tickets", tickets);
        }
        model.addAttribute("loggedInUser", user );
        model.addAttribute("tickets", ticketService.findAll());
        return "Tickets";
    }

    @GetMapping("/create-ticket")
    public String createTicket(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        model.addAttribute("user", user );
        if(user.getRole().equals("user"))
            return "CreateTicket";
        else return "Error";
    }

    @PostMapping("/create-ticket")
    public @ResponseBody String submitTickets(@ModelAttribute ("ticket") Ticket ticket, Model model)
    {

        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());

        model.addAttribute("user", user );
        ticket.setUser(user);
        ticketService.save(ticket);
        return "CreateTicket";
    }

    @GetMapping("/user")
    public String users(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        if(user.getRole().equals("user")) return "Error";
        model.addAttribute("loggedInUser", user );
        model.addAttribute("users", userService.findAll());
        return "Users";
    }
    @GetMapping("/customer")
    public String customers(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        model.addAttribute("loggedInUser", user );
        List<User> ul = new ArrayList<User>();
        for(User u : userService.findAll()){
            if(u.getRole().equals("user"))
                ul.add(u);
        }
        model.addAttribute("users", ul);
        return "Users";
    }

    @GetMapping("/employee")
    public String employees(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        model.addAttribute("loggedInUser", user );
        List<User> ul = new ArrayList<User>();
        for(User u : userService.findAll()){
            if(u.getRole().equals("employee"))
                ul.add(u);
        }
        model.addAttribute("users", ul);
        if(user.getRole().equals("user")) return "Error";
        return "Users";
    }

    @GetMapping("/admin")
    public String admins(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        model.addAttribute("loggedInUser", user );
        List<User> ul = new ArrayList<User>();
        for(User u : userService.findAll()){
            if(u.getRole().equals("admin"))
                ul.add(u);
        }
        model.addAttribute("users", ul);
        if(user.getRole().equals("user")) return "Error";
        return "Users";
    }

    @GetMapping("/payment")
    public String payments(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        List<Payment> p = new ArrayList<Payment>();
        if(user.getRole().equals("user")){
            for(Payment pm : paymentService.findAll()){
                if(pm.getUser().getUserId() == user.getUserId())
                    p.add(pm);
            }
            model.addAttribute("payments", p);
        }
        else model.addAttribute("payments", paymentService.findAll());
        model.addAttribute("loggedInUser", user );

        return "Payments";
    }

    @GetMapping("/ip")
    public String ipAddress(Model model){
        SecurityContext securityContext = SecurityContextHolder.getContext();
        User user = userService.findUserByEmail(securityContext.getAuthentication().getName());
        model.addAttribute("loggedInUser", user );
        model.addAttribute("ipAddresses", ipAddressService.findAll());
        return "IpAddresses";
    }


}
