package org.example;

public enum InternetPackage {
    Standard(7001, "Standard", 800, 30),
    Gold(7002, "Gold", 1000, 40),
    Platinum(7003, "Platinum", 1200, 50),
    Diamond(7004, "Diamond", 1500, 60),
    Sapphire(7005, "Sapphire", 2000, 80),
    Star(7006, "Star", 3000, 90),
    Sky(7007, "Sky", 4000, 100);



    InternetPackage(int packageId, String packageName, int price, int speed) {
        this.packageId = packageId;
        PackageName = packageName;
        this.price = price;
        this.speed = speed;
    }

    public int getPackageId() {
        return packageId;
    }

    public String getPackageName() {
        return PackageName;
    }

    public int getPrice() {
        return price;
    }

    public int getSpeed() {
        return speed;
    }

    private final int packageId;
    private final String PackageName;
    private final int price;
    private final int speed;
};