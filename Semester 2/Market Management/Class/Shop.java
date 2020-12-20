package Class;

import Interface.*;

public class Shop implements ProductOperations {
    private String  sid;
    private String name;
    private Product products[] = new Product[100];
    public void setName(String name){this.name = name;}
    public void setSid(String  sid){this.sid =  sid;}
    public String getName(){return name;}
    public String getSid(){return  sid;}
    public boolean insertProduct(Product f) {
        for (int i = 0; i < products.length; i++)
            if (products[i] == null){
                products[i] = f;
                return true;
            }
        return false;
    }
    public boolean removeProduct(Product f){
        if(f==null) return false;
        for (int i = 0; i < products.length; i++)
            if (products[i] == f) {
                products[i] = null;
                return true;
            }
        return false;
    }
    public Product searchProduct(String pid){
        for (int i = 0; i < products.length; i++)
            if (products[i] != null && products[i].getPid().equals(pid)){
                return products[i];
            }
        return null;
    }
    public void showAllProducts(){
        boolean empty = false;
        for(int i = 0; i < products.length; i++) 
            if(products[i] != null) {empty=true;break;}
        if(empty == false) System.out.println("Product Item list Empty");
        
        for (int i = 0; i < products.length; i++)
            if (products[i] != null){
                products[i].showInfo();
                /*
                System.out.println("Product Name : " + products[i].getName());
                System.out.println("Product ID : " + products[i].getPid());
                System.out.println("Available Quantity : " + products[i].getAvailableQuantity());
                System.out.println("Product Price : " + products[i].getPrice());
                if(products[i] instanceof LocalProduct){
                    Product temp = products[i];
                    System.out.println("Product Category : " + ((LocalProduct)temp).getDiscountRate());
                }
                if(products[i] instanceof ImportedProduct){
                    Product temp = products[i];
                    System.out.println("Size : " + ((ImportedProduct)temp).getCountryName());
                }*/
            }
    }
}