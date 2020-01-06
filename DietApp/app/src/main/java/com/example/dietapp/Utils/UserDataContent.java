package com.example.dietapp.Utils;

public class UserDataContent {

    private String email, username, password;
    private String name, description;
    private String date;
    private String totalCalories, foodGrams, foodCalories;
    private String foodName;
    private byte[] image;
    private static UserDataContent instance = new UserDataContent();

    private UserDataContent() {}

    public static UserDataContent getInstance(){
        return instance;
    }

    public void setEmail(String email){ this.email = email; }
    public void setUsername(String username ) { this.username = username; }
    public void setPassword(String password) { this.password = password; }

    public String getEmail(){ return this.email; }
    public String getUsername() { return this.username; }
    public String getPassword() {return  this.password; }

    public void setUserName(String name){ this.name = name; }
    public void setDescription(String description){ this.description = description; }
    public void setImage(byte[] image){ this.image = image; }

    public String getName(){ return this.name; }
    public String getDescription(){ return this.description; }
    public byte[] getImage(){ return this.image;}

    public void setDate(String date){ this.date = date; }
    public void setTotalCalories(String totalCalories){ this.totalCalories = totalCalories; }

    public String getDate(){ return  this.date; }
    public String getTotalCalories(){ return this.totalCalories; }

    public void setDailyFoodName(String foodName){ this.foodName = foodName; }
    public void setDailyFoodGrams(String foodGrams){ this.foodGrams = foodGrams; }
    public void setDailyFoodCalories(String foodCalories){ this.foodCalories = foodCalories; }

    public String getDailyFoodName(){ return this.foodName; }
    public String getDailyFoodGrams(){ return this.foodGrams; }
    public String getDailyFoodCalories(){ return this.foodCalories; }
}
