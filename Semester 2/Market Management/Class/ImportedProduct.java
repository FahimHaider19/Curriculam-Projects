package Class;

import Interface.*;

public class ImportedProduct extends Product {
    private int size;
    public void setCountryName(int size){this.size = size;}
    public int getCountryName(){return size;}
    public void showInfo(){
        System.out.println();
        System.out.println("Product Name : " + name);
        System.out.println("Product ID : " + pid);
        System.out.println("Available Quantity : " + availableQuantity);
        System.out.println("Product Price : " + price);
        System.out.println("Size : " + size);
    }
}