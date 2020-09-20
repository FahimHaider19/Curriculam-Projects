package Class;

import Interface.*;

public class Restaurant implements FoodItemOperations {
    private String rid;
    private String name;
    private FoodItem fooditems[] = new FoodItem[100];
    public void setName(String name){this.name = name;}
    public void setRid(String rid){this.rid = rid;}
    public String getName(){return name;}
    public String getRid(){return rid;}
    public boolean insertFoodItem(FoodItem f) {
        for (int i = 0; i < fooditems.length; i++)
            if (fooditems[i] == null){
                fooditems[i] = f;
                return true;
            }
        return false;
    }
    public boolean removeFoodItem(FoodItem f){
        if(f==null) return false;
        for (int i = 0; i < fooditems.length; i++)
            if (fooditems[i] == f) {
                fooditems[i] = null;
                return true;
            }
        return false;
    }
    public FoodItem searchFoodItem(String fid){
        for (int i = 0; i < fooditems.length; i++)
            if (fooditems[i] != null && fooditems[i].getFid().equals(fid)){
                return fooditems[i];
            }
        return null;
    }
    public void showAllFoodItems(){
        boolean empty = false;
        for(int i = 0; i < fooditems.length; i++) 
            if(fooditems[i] != null) {empty=true;break;}
        if(empty == false) System.out.println("Food Item list Empty");
        
        for (int i = 0; i < fooditems.length; i++)
            if (fooditems[i] != null){
                fooditems[i].showInfo();
                /*
                System.out.println("Food Name : " + fooditems[i].getName());
                System.out.println("Food ID : " + fooditems[i].getFid());
                System.out.println("Available Quantity : " + fooditems[i].getAvailableQuantity());
                System.out.println("Food Price : " + fooditems[i].getPrice());
                if(fooditems[i] instanceof MainDish){
                    FoodItem temp = fooditems[i];
                    System.out.println("Food Category : " + ((MainDish)temp).getCategory());
                }
                if(fooditems[i] instanceof Appitizers){
                    FoodItem temp = fooditems[i];
                    System.out.println("Size : " + ((Appitizers)temp).getSize());
                }*/
            }
    }
}