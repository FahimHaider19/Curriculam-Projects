package Class;

import Interface.*;

public class FoodCourt implements RestaurantOperations,EmployeeOperations{
    private Restaurant restaurant[] = new Restaurant[100];
    private Employee employees[] = new Employee[100];
    public boolean insertRestaurant(Restaurant r) {
        for (int i = 0; i < restaurant.length; i++) 
            if (restaurant[i] == null) {
                restaurant[i] = r;
                return true;
            }
        return false;
    }
    public boolean removeRestaurant(Restaurant r) {
        if(r==null) return false;
        for (int i = 0; i < restaurant.length; i++) {
            if (restaurant[i] == r) {
                restaurant[i] = null;
                return true;
            }
        }
        return false;
    }
    public Restaurant searchRestaurant(String rid) {
        for (int i = 0; i < restaurant.length; i++)
            if (restaurant[i] != null && restaurant[i].getRid().equals(rid))
                return restaurant[i];
        return null;
    }
    public void showAllRestaurants() {
        boolean empty = false;
        for(int i = 0; i < restaurant.length; i++) 
            if(restaurant[i] != null) {empty=true;break;}
        if(empty == false) System.out.println("Restaurant list Empty");
        for (int i = 0; i < restaurant.length; i++)
            if (restaurant[i] != null) {
                System.out.println("Restaurant Name : " + restaurant[i].getName());
                System.out.println("Restaurant ID : " + restaurant[i].getRid());
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