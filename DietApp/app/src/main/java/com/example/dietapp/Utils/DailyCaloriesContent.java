package com.example.dietapp.Utils;

public class DailyCaloriesContent {

    private String date, calories;

    public DailyCaloriesContent(String date, String calories){
        this.date = date;
        this.calories = calories;
    }

    public String getDate(){ return this.date; }
    public String getDailyTotalCalories(){ return this.calories; }

}
