import java.lang.*;
import java.util.Scanner;
import Class.*;
import FileIO.*;

public class Start{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Market market = new Market();
        FileIO frwd = new FileIO();
        Shop shop = null;
        Employee employee = null;
        Product product = null;

        while (true){
            System.out.println("1. Employee Management");
            System.out.println("2. Shop Management");
            System.out.println("3. Shop Product Management");
            System.out.println("4. Product Quantity Add-Sell");
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

                            if(market.insertEmployee(employee)){
                                System.out.println("Employee Inserted");
                            } 
                            else System.out.println("Failed to insert Employee");
                            System.out.println("___________________________________________\n");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            employee = null;
                            System.out.print("Enter Employee ID : ");
                            employee = market.searchEmployee(sc.nextLine());
                            if (market.removeEmployee(employee)){
                                System.out.println("Employee Removed");
                            } 
                            else System.out.println("Invalid employee ID");
                            System.out.println("___________________________________________\n");
                            break;

                        case 3:
                            System.out.println("___________________________________________\n");
                            employee = null;
                            System.out.print("Enter an Employee ID : ");
                            employee = market.searchEmployee(sc.nextLine());

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
                            market.showAllEmployees();
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
                    System.out.println(">>>>>>Shop Management<<<<<<");
                    System.out.println("1. Insert New Shop");
                    System.out.println("2. Remove Existing Shop");
                    System.out.println("3. Show All Shop");
                    System.out.println("4. Search A Shop");
                    System.out.println("5. Go Back");

                    System.out.print("Enter You Option : ");
                    switch (Integer.parseInt(sc.nextLine())){
                        case 1:
                            System.out.println("___________________________________________\n");
                            shop = new Shop();
                            System.out.print("Enter Shop Name : ");
                            shop.setName(sc.nextLine());
                            System.out.print("Enter Shop ID : ");
                            shop.setSid(sc.nextLine());

                            if (market.insertShop(shop)){
                                System.out.println("Shop Inserted");
                            } 
                            else System.out.println("Failed to insert shops.");
                            System.out.println("___________________________________________\n");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            shop = new Shop();
                            System.out.print("Enter a Shop ID : ");
                            shop = market.searchShop(sc.nextLine());

                            if (market.removeShop(shop)) {
                                System.out.println("Shop Removed.");
                            } 
                            else System.out.println("Invalid shop ID");
                            System.out.println("___________________________________________\n");
                            break;

                        case 3:
                            System.out.println("___________________________________________\n");
                            System.out.println("Shop List - \n");
                            market.showAllShops();
                            System.out.println("___________________________________________\n");
                            break;

                        case 4:
                            System.out.println("___________________________________________\n");
                            shop = new Shop();
                            System.out.print("Enter an Shop ID : ");
                            shop = market.searchShop(sc.nextLine());

                            if (shop != null) {
                                System.out.println("\nShop Found...");
                                System.out.println("Shop ID : " + shop.getSid());
                                System.out.println("Shop Name : " + shop.getName());

                            } else System.out.println("Invalid shop ID");
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
                    System.out.println(">>>>>>Shop Product Management<<<<<<");
                    System.out.println("1. Insert New Product Item");
                    System.out.println("2. Remove Existing Product Item");
                    System.out.println("3. Show All Product Items");
                    System.out.println("4. Search a Product Item");
                    System.out.println("5. Go Back");

                    System.out.print("Enter You Option : ");
                    switch (Integer.parseInt(sc.nextLine())) {
                        case 1:
                            System.out.println("___________________________________________\n");
                            shop = new Shop();
                            System.out.print("Enter Shop ID : ");
                            shop = market.searchShop(sc.nextLine()); 
                            
                            if (shop != null){
                                System.out.println("Choose your Product Item Type - ");
                                System.out.println("1. Local Product");
                                System.out.println("2. Imported Product");
                                System.out.print("Enter Product Type : ");

                                switch (Integer.parseInt(sc.nextLine())) {
                                    case 1:
                                        System.out.println("___________________________________________\n");
                                        product = new LocalProduct();
                                        System.out.print("Enter Product Item ID : ");
                                        product.setPid(sc.nextLine());
                                        System.out.print("Enter Product Name : ");
                                        product.setName(sc.nextLine());
                                        System.out.print("Enter Quantity : ");
                                        product.setAvailableQuantity(Integer.parseInt(sc.nextLine()));
                                        System.out.print("Enter Price : ");
                                        product.setPrice(Double.parseDouble(sc.nextLine()));
                                        System.out.print("Enter Category : ");
                                        ((LocalProduct) product).setDiscountRate(Double.parseDouble(sc.nextLine()));

                                        if(shop.insertProduct(product)){
                                            System.out.println("Product Item inserted.");
                                        } 
                                        else {System.out.println("Product Item Can Not be inserted.");}
                                        System.out.println("___________________________________________\n");
                                        break;

                                    case 2:
                                        System.out.println("___________________________________________\n");
                                        product = new ImportedProduct();
                                        System.out.print("Enter Product Item ID : ");
                                        product.setPid(sc.nextLine());
                                        System.out.print("Enter Product Name : ");
                                        product.setName(sc.nextLine());
                                        System.out.print("Enter Quantity : ");
                                        product.setAvailableQuantity(Integer.parseInt(sc.nextLine()));
                                        System.out.print("Enter Price : ");
                                        product.setPrice(Double.parseDouble(sc.nextLine()));
                                        System.out.print("Enter Size : ");
                                        ((ImportedProduct)product).setCountryName(Integer.parseInt(sc.nextLine()));

                                        if (shop.insertProduct(product)) {
                                            System.out.println("Product Item inserted");
                                        } 
                                        else {System.out.println("Failed to insert product");}
                                        System.out.println("___________________________________________\n");
                                        break;

                                    default:   
                                        System.out.println("___________________________________________\n");
                                        System.out.println("Invalid Input...");
                                        System.out.println("___________________________________________\n");
                                        break;
                                }

                            } 
                            else System.out.println("Invalid Shop ID.");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            product = null;
                            System.out.println("---------------------------------");
                            System.out.print("Enter Shop ID : ");
                            shop = market.searchShop(sc.nextLine()); 
                            if (shop == null) {
                                System.out.println("Invalid Shop ID");
                                break;
                            }
                            System.out.print("Enter a Product ID to Remove : ");
                            product = shop.searchProduct(sc.nextLine());

                            if (product != null) {
                                if (shop.removeProduct(product)){
                                    System.out.println("Product Item Removed");
                                } 
                                else {System.out.println("Failed to remove Product item.");}
                            } 
                            else {System.out.println("Invalid Product item ID");}
                            System.out.println("___________________________________________\n");
                            break;

                        case 3:
                            System.out.println("___________________________________________\n");
                            System.out.print("Enter Shop ID : ");
                            shop = market.searchShop(sc.nextLine());
                            if (shop == null) {
                                System.out.println("Invalid Shop ID");
                                break;
                            }
                            shop.showAllProducts();
                            System.out.println("___________________________________________\n");
                            break;

                        case 4:
                            System.out.println("___________________________________________\n");
                            shop = new Shop();
                            System.out.print("Enter Shop ID : ");
                            shop = market.searchShop(sc.nextLine());
                            if(shop == null){
                                System.out.println("Invalid Shop ID");
                                break;
                            }
                            System.out.print("Enter an Product ID : ");
                            String pid3 = sc.nextLine();
                            product = shop.searchProduct(pid3);

                            if (product != null){
                                System.out.println("\nProduct Item Found...");
                                System.out.println("Product ID : " + product.getPid());
                                System.out.println("Product Name : " + product.getName());
                            } 
                            else System.out.println("Invalid Product item ID");
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
                    System.out.println(">>>>>>Product Quantity Add-Sell<<<<<<");
                    System.out.println("1. Add Product");
                    System.out.println("2. Sell Product");
                    System.out.println("3. Show Add Sell History");
                    System.out.println("4. Go Back");

                    System.out.print("Enter You Option: ");
                    switch (Integer.parseInt(sc.nextLine())) {
                        case 1:
                            System.out.println("___________________________________________\n");
                            shop = new Shop();
                            System.out.print("Enter Shop ID : ");
                            String  sid = sc.nextLine();
                            shop = market.searchShop(sid);
                            if (shop != null){
                                System.out.print("Enter Product ID : ");
                                String pid = sc.nextLine();
                                product = shop.searchProduct(pid);
                                if(product != null){
                                    System.out.print("Enter Amount to Add Quantity : ");
                                    int quantity = Integer.parseInt(sc.nextLine());
                                    if (product.addQuantity(quantity)) {
                                        System.out.println("Product Item added.");
                                        frwd.writeInFile("Product Item Added => "+" Product Name : "+product.getName()+ ", FId : "+pid+", Added Quantity : "+quantity);
                                    } 
                                    else {System.out.println("Failed to add Product item.");}
                                } 
                                else {System.out.print("Invalid Product ID");}
                            } 
                            else {System.out.print("Invalid Shop ID.");}
                            System.out.println("___________________________________________\n");
                            break;

                        case 2:
                            System.out.println("___________________________________________\n");
                            shop = new Shop();
                            System.out.println("---------------------------------");
                            System.out.print("Enter Shop ID : ");
                            String sid2 = sc.nextLine();
                            shop = market.searchShop(sid2);
                            if (shop != null){
                                System.out.print("Enter Product Item ID : ");
                                String pid2 = sc.nextLine();
                                product = shop.searchProduct(pid2);
                                if (product != null){
                                    System.out.print("Enter Amount to Sell Quantity : ");
                                    int quantity2 = Integer.parseInt(sc.nextLine());

                                    if (product.sellQuantity(quantity2)) {
                                        System.out.println("Sell Done.");
                                        frwd.writeInFile("Product Item Sold => "+" Product Name : "+product.getName()+ ", FId : "+pid2+", Sold Quantity : "+quantity2);

                                    } 
                                    else {System.out.println("Failed to sell Product item.");}
                                } 
                                else {System.out.print("Invalid Product Item Number");}
                            } 
                            else {System.out.print("Invalid Shop ID.");}
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

