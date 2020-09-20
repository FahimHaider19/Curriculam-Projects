package Class;

public class MainDish extends FoodItem {
    private String category;
    public void setCategory(String category){this.category = category;}
    public String getCategory(){return category;}
    public void showInfo(){
        System.out.println("Food Name : " + name);
        System.out.println("Food ID : " + fid);
        System.out.println("Available Quantity : " + availableQuantity);
        System.out.println("Food Price : " + price);
        System.out.println("Food Category : " + category);
    }
}