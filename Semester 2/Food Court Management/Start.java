import java.lang.*;
import java.util.Scanner;
import Class.*;
import FileIO.*;

public class Start{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        FoodCourt foodcourt = new FoodCourt();
        FileReadWrite frwd = new FileReadWrite();
        Restaurant restaurant = null;
        Employee employee = null;
        FoodItem fooditem = null;

        while (true){
            System.out.println("1. Employee Management");
            System.out.println("2. Restaurant Management");
            System.out.println("3. Restauranr Food Item Management");
            System.out.println("4. FoodItem Quantity Add-Sell");
            System.out.println("5. Exit");
            System.out.print("Select an option : ");
            switch (Integer.parseInt(sc.nextLine())){
                case 1:
                    System.out.println("___________________________________________\n");
                    System.out.println(">>>>>>Employee Management<<<<<<");
                    System.out.println("1. Insert New Employee");
                    System.out.println("2. Remove Existing Employee");
                    System.out.println("3. Search an Employee");
                    System.out.println("4. Show All Employees");
                    System.out.println("5. Go Back");

                    System.out.print("Enter You Option : ");

                    switch (Integer.parseInt(sc.nextLine())){
                        case 1:
                            System.out.println("___________________________________________\n");
                            employee = new Employee();
                            System.out.print("Enter Employee ID : ");
                            employee.setEmpId(sc.nextLine());
                            System.out.print("Enter Employee Name : ");
                            employee.setName(sc.nextLine());
                            System.out.print("Enter Employe Salary : ");
                            employee.setSalary(Double.parseDouble(sc.nextLine()));

                            if(foodcourt.insertEmployee(employee)){
                                System.out.println("Employee Inserted");
                            } 
                            else System.out.println("Failed to insert Employee");
                            System.out.println("___________________________________________\n");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            employee = null;
                            System.out.print("Enter Employee ID : ");
                            employee = foodcourt.searchEmployee(sc.nextLine());
                            if (foodcourt.removeEmployee(employee)){
                                System.out.println("Employee Removed");
                            } 
                            else System.out.println("Invalid employee ID");
                            System.out.println("___________________________________________\n");
                            break;

                        case 3:
                            System.out.println("___________________________________________\n");
                            employee = null;
                            System.out.print("Enter an Employee ID : ");
                            employee = foodcourt.searchEmployee(sc.nextLine());

                            if (employee != null){
                                System.out.println("\nEmployee found...");
                                System.out.println("Employee ID: " + employee.getEmpId());
                                System.out.println("Employee Name: " + employee.getName());
                                System.out.println("Employee Salary: " + employee.getSalary());
                            } 
                            else System.out.println("Invalid employee ID");
                            System.out.println("___________________________________________\n");
                            break;

                        case 4:
                            System.out.println("___________________________________________\n");
                            System.out.println("Employee List - \n");
                            foodcourt.showAllEmployees();
                            System.out.println("___________________________________________\n");
                            break;

                        case 5:
                            break;

                        default:
                            System.out.println("___________________________________________\n");
                            System.out.println("Invalid Option.");
                            System.out.println("___________________________________________\n");
                            break;
                    }
                    break;

                case 2:
                    System.out.println("___________________________________________\n");
                    System.out.println(">>>>>>Restaurant Management<<<<<<");
                    System.out.println("1. Insert New Restaurant");
                    System.out.println("2. Remove Existing Restaurant");
                    System.out.println("3. Show All Restaurant");
                    System.out.println("4. Search A Restaurant");
                    System.out.println("5. Go Back");

                    System.out.print("Enter You Option : ");
                    switch (Integer.parseInt(sc.nextLine())){
                        case 1:
                            System.out.println("___________________________________________\n");
                            restaurant = new Restaurant();
                            System.out.print("Enter Restaurant Name : ");
                            restaurant.setName(sc.nextLine());
                            System.out.print("Enter Restaurant ID : ");
                            restaurant.setRid(sc.nextLine());

                            if (foodcourt.insertRestaurant(restaurant)){
                                System.out.println("Restaurant Inserted");
                            } 
                            else System.out.println("Failed to insert restaurant.");
                            System.out.println("___________________________________________\n");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            restaurant = new Restaurant();
                            System.out.print("Enter a Restaurant ID : ");
                            restaurant = foodcourt.searchRestaurant(sc.nextLine());

                            if (foodcourt.removeRestaurant(restaurant)) {
                                System.out.println("Restaurant Removed.");
                            } 
                            else System.out.println("Invalid restaurant ID");
                            System.out.println("___________________________________________\n");
                            break;

                        case 3:
                            System.out.println("___________________________________________\n");
                            System.out.println("Restaurant List - \n");
                            foodcourt.showAllRestaurants();
                            System.out.println("___________________________________________\n");
                            break;

                        case 4:
                            System.out.println("___________________________________________\n");
                            restaurant = new Restaurant();
                            System.out.print("Enter an Restaurant ID : ");
                            restaurant = foodcourt.searchRestaurant(sc.nextLine());

                            if (restaurant != null) {
                                System.out.println("\nRestaurant Found...");
                                System.out.println("Restaurant ID : " + restaurant.getRid());
                                System.out.println("Restaurant Name : " + restaurant.getName());

                            } else System.out.println("Invalid restaurant ID");
                            System.out.println("___________________________________________\n");
                            break;

                        case 5:
                            break;

                        default:
                            System.out.println("___________________________________________\n");
                            System.out.println("Invalid Option.");
                            System.out.println("___________________________________________\n");
                            break;
                    }
                    break;

                case 3:
                    System.out.println("___________________________________________\n");
                    System.out.println(">>>>>>Restauranr Food Item Management<<<<<<");
                    System.out.println("1. Insert New Food Item");
                    System.out.println("2. Remove Existing Food Item");
                    System.out.println("3. Show All Food Items");
                    System.out.println("4. Search a Food Item");
                    System.out.println("5. Go Back");

                    System.out.print("Enter You Option : ");
                    switch (Integer.parseInt(sc.nextLine())) {
                        case 1:
                            System.out.println("___________________________________________\n");
                            restaurant = new Restaurant();
                            System.out.print("Enter Restaurant ID : ");
                            restaurant = foodcourt.searchRestaurant(sc.nextLine()); 
                            
                            if (restaurant != null){
                                System.out.println("Choose your Food Item Type - ");
                                System.out.println("1. Main Dish");
                                System.out.println("2. Appitizer");
                                System.out.print("Enter Food Type : ");

                                switch (Integer.parseInt(sc.nextLine())) {
                                    case 1:
                                        System.out.println("___________________________________________\n");
                                        fooditem = new MainDish();
                                        System.out.print("Enter Food Item ID : ");
                                        fooditem.setFid(sc.nextLine());
                                        System.out.print("Enter Food Name : ");
                                        fooditem.setName(sc.nextLine());
                                        System.out.print("Enter Quantity : ");
                                        fooditem.setAvailableQuantity(Integer.parseInt(sc.nextLine()));
                                        System.out.print("Enter Price : ");
                                        fooditem.setPrice(Double.parseDouble(sc.nextLine()));
                                        System.out.print("Enter Category : ");
                                        ((MainDish) fooditem).setCategory(sc.nextLine());

                                        if(restaurant.insertFoodItem(fooditem)){
                                            System.out.println("Food Item inserted.");
                                        } 
                                        else {System.out.println("Food Item Can Not be inserted.");}
                                        System.out.println("___________________________________________\n");
                                        break;

                                    case 2:
                                        System.out.println("___________________________________________\n");
                                        fooditem = new Appitizers();
                                        System.out.print("Enter Food Item ID : ");
                                        fooditem.setFid(sc.nextLine());
                                        System.out.print("Enter Food Name : ");
                                        fooditem.setName(sc.nextLine());
                                        System.out.print("Enter Quantity : ");
                                        fooditem.setAvailableQuantity(Integer.parseInt(sc.nextLine()));
                                        System.out.print("Enter Price : ");
                                        fooditem.setPrice(Double.parseDouble(sc.nextLine()));
                                        System.out.print("Enter Size : ");
                                        ((Appitizers)fooditem).setSize(Integer.parseInt(sc.nextLine()));

                                        if (restaurant.insertFoodItem(fooditem)) {
                                            System.out.println("Food Item inserted");
                                        } 
                                        else {System.out.println("Failed to insert fooditem");}
                                        System.out.println("___________________________________________\n");
                                        break;

                                    default:   
                                        System.out.println("___________________________________________\n");
                                        System.out.println("Invalid Input...");
                                        System.out.println("___________________________________________\n");
                                        break;
                                }

                            } 
                            else System.out.println("Invalid Restaurant ID.");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            fooditem = null;
                            System.out.println("---------------------------------");
                            System.out.print("Enter Restaurant ID : ");
                            restaurant = foodcourt.searchRestaurant(sc.nextLine()); 
                            if (restaurant == null) {
                                System.out.println("Invalid Restaurant ID");
                                break;
                            }
                            System.out.print("Enter a Food ID to Remove : ");
                            fooditem = restaurant.searchFoodItem(sc.nextLine());

                            if (fooditem != null) {
                                if (restaurant.removeFoodItem(fooditem)){
                                    System.out.println("Food Item Removed");
                                } 
                                else {System.out.println("Failed to remove food item.");}
                            } 
                            else {System.out.println("Invalid food item ID");}
                            System.out.println("___________________________________________\n");
                            break;

                        case 3:
                            System.out.println("___________________________________________\n");
                            System.out.print("Enter Restaurant ID : ");
                            restaurant = foodcourt.searchRestaurant(sc.nextLine());
                            if (restaurant == null) {
                                System.out.println("Invalid Restaurant ID");
                                break;
                            }
                            restaurant.showAllFoodItems();
                            System.out.println("___________________________________________\n");
                            break;

                        case 4:
                            System.out.println("___________________________________________\n");
                            restaurant = new Restaurant();
                            System.out.print("Enter Restaurant ID : ");
                            restaurant = foodcourt.searchRestaurant(sc.nextLine());
                            if(restaurant == null){
                                System.out.println("Invalid Restaurant ID");
                                break;
                            }
                            System.out.print("Enter an Food ID : ");
                            String fid3 = sc.nextLine();
                            fooditem = restaurant.searchFoodItem(fid3);

                            if (fooditem != null){
                                System.out.println("\nFood Item Found...");
                                System.out.println("Food ID : " + fooditem.getFid());
                                System.out.println("Food Name : " + fooditem.getName());
                            } 
                            else System.out.println("Invalid food item ID");
                            System.out.println("___________________________________________\n");
                            break;
                        case 5:
                            break;

                        default:
                            System.out.println("___________________________________________\n");
                            System.out.println("Invalid Choice...");
                            System.out.println("___________________________________________\n");
                            break;
                    }
                    break;

                case 4:
                    System.out.println("___________________________________________\n");
                    System.out.println(">>>>>>FoodItem Quantity Add-Sell<<<<<<");
                    System.out.println("1. Add FoodItem");
                    System.out.println("2. Sell FoodItem");
                    System.out.println("3. Show Add Sell History");
                    System.out.println("4. Go Back");

                    System.out.print("Enter You Option: ");
                    switch (Integer.parseInt(sc.nextLine())) {
                        case 1:
                            System.out.println("___________________________________________\n");
                            restaurant = new Restaurant();
                            System.out.print("Enter Restaurant ID : ");
                            String rid = sc.nextLine();
                            restaurant = foodcourt.searchRestaurant(rid);
                            if (restaurant != null){
                                System.out.print("Enter Food ID : ");
                                String fid = sc.nextLine();
                                fooditem = restaurant.searchFoodItem(fid);
                                if(fooditem != null){
                                    System.out.print("Enter Amount to Add Quantity : ");
                                    int quantity = Integer.parseInt(sc.nextLine());
                                    if (fooditem.addQuantity(quantity)) {
                                        System.out.println("Food Item added.");
                                        frwd.writeInFile("Food Item Added => "+" Food Name : "+fooditem.getName()+ ", FId : "+fid+", Added Quantity : "+quantity);
                                    } 
                                    else {System.out.println("Failed to add food item.");}
                                } 
                                else {System.out.print("Invalid Food ID");}
                            } 
                            else {System.out.print("Invalid Restaurant ID.");}
                            System.out.println("___________________________________________\n");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            restaurant = new Restaurant();
                            System.out.println("---------------------------------");
                            System.out.print("Enter Restaurant ID : ");
                            String rid2 = sc.nextLine();
                            restaurant = foodcourt.searchRestaurant(rid2);
                            if (restaurant != null){
                                System.out.print("Enter Food Item ID : ");
                                String fid2 = sc.nextLine();
                                fooditem = restaurant.searchFoodItem(fid2);
                                if (fooditem != null){
                                    System.out.print("Enter Amount to Sell Quantity : ");
                                    int quantity2 = Integer.parseInt(sc.nextLine());

                                    if (fooditem.sellQuantity(quantity2)) {
                                        System.out.println("Sell Done.");
                                        frwd.writeInFile("Food Item Sold => "+" Food Name : "+fooditem.getName()+ ", FId : "+fid2+", Sold Quantity : "+quantity2);

                                    } 
                                    else {System.out.println("Failed to sell food item.");}
                                } 
                                else {System.out.print("Invalid Food Item Number");}
                            } 
                            else {System.out.print("Invalid Restaurant ID.");}
                            System.out.println("___________________________________________\n");
                            break;

                        case 3:
                            System.out.println("___________________________________________\n");
                            frwd.readFromFile();
                            System.out.println("___________________________________________\n");
                            break;

                        case 4:
                            break;

                        default:
                            System.out.println("___________________________________________\n");
                            System.out.println("Invalid Choice...");
                            break;
                            
                    }
                    break;

                case 5:
                    return;
                    
            }
            System.out.println("___________________________________________\n");
        }
    }
}

