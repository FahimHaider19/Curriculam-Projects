package Interface;

import Class.*;

public interface ShopOperations{
    boolean insertShop(Shop r);
    boolean removeShop(Shop r);
    Shop searchShop(String  sid);
    void showAllShops();
}