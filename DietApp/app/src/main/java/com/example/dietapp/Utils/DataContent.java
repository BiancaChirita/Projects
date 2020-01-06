package com.example.dietapp.Utils;

public class DataContent {

    private String name;
    String grams, calories;

    public DataContent (String name, String grams, String calories){
        this.name = name;
        this.grams = grams;
        this.calories = calories;
    }

    public String getFoodName(){ return this.name; }
    public String getFoodGrams() { return this.grams; }
    public String getFoodCalories() {return  this.calories; }

}
