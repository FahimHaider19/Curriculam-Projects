package Interface;

import Class.*;

public interface ProductOperations{
    boolean insertProduct(Product f);
    boolean removeProduct(Product f);
    Product searchProduct(String pid);
    void showAllProducts();
}