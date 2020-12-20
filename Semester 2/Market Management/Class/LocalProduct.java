package Class;

import Interface.*;

public class LocalProduct extends Product {
    protected double discountRate;
    public void setDiscountRate(double discountRate){this.discountRate = discountRate;}
    public double getDiscountRate(){return discountRate;}
    public void showInfo(){
        System.out.println("Product Name : " + name);
        System.out.println("Product ID : " + pid);
        System.out.println("Available Quantity : " + availableQuantity);
        System.out.println("Product Price : " + price);
        System.out.println("Product Category : " + discountRate);
    }
}