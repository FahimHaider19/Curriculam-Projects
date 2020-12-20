package Class;

import Interface.*;

public class Market implements ShopOperations,EmployeeOperations{
    private Shop shops[] = new Shop[100];
    private Employee employees[] = new Employee[100];
    public boolean insertShop(Shop r) {
        for (int i = 0; i < shops.length; i++) 
            if (shops[i] == null) {
                shops[i] = r;
                return true;
            }
        return false;
    }
    public boolean removeShop(Shop r) {
        if(r==null) return false;
        for (int i = 0; i < shops.length; i++) {
            if (shops[i] == r) {
                shops[i] = null;
                return true;
            }
        }
        return false;
    }
    public Shop searchShop(String  sid) {
        for (int i = 0; i < shops.length; i++)
            if (shops[i] != null && shops[i].getSid().equals( sid))
                return shops[i];
        return null;
    }
    public void showAllShops() {
        boolean empty = false;
        for(int i = 0; i < shops.length; i++) 
            if(shops[i] != null) {empty=true;break;}
        if(empty == false) System.out.println("Shop list Empty");
        for (int i = 0; i < shops.length; i++)
            if (shops[i] != null) {
                System.out.println("Shop Name : " + shops[i].getName());
                System.out.println("Shop ID : " + shops[i].getSid());
                System.out.println();
            }
    }
    public boolean insertEmployee(Employee e){
        for (int i = 0; i < employees.length; i++)
            if (employees[i] == null){
                employees[i] = e;
                return true;
            }
        return false;
    }
    public boolean removeEmployee(Employee e){
        if(e==null) return false;
        for (int i = 0; i < employees.length; i++) {
            if (employees[i] == e) {
                employees[i] = null;
                return true;
            }
        }
        return false;
    }
    public Employee searchEmployee(String empId) {
        for (int i = 0; i < employees.length; i++)
            if (employees[i] != null && employees[i].getEmpId().equals(empId))
                return employees[i];
        return null;
    }
    public void showAllEmployees() {
        boolean empty = false;
        for(int i = 0; i < employees.length; i++) 
            if(employees[i] != null) {empty=true;break;}
        if(empty == false) System.out.println("Employee list Empty");
        
        for (int i = 0; i < employees.length; i++)
            if (employees[i] != null){
                System.out.println("Employee Name: " + employees[i].getName());
                System.out.println("Employee ID: " + employees[i].getEmpId());
                System.out.println("Salary: " + employees[i].getSalary());
                System.out.println();
            }
        System.out.println();
    }
}