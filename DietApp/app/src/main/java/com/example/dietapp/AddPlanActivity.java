package com.example.dietapp;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.dietapp.Utils.DatabaseHelper;
import com.example.dietapp.Utils.UserDataContent;

import java.lang.reflect.Array;
import java.util.ArrayList;

public class AddPlanActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener{

    private Context context = AddPlanActivity.this;
    DatabaseHelper db;

    ImageView ic_back;
    Button saveBtn;
    Spinner spinnerFood;
    EditText addGrams;
    ArrayList<String> foods;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_plan);

        db = new DatabaseHelper(this);

        foods = db.getAllFoodNames();

        spinnerFood = (Spinner) findViewById(R.id.spinnerFood);
        addGrams = (EditText) findViewById(R.id.etAddGrams);

        ic_back = (ImageView) findViewById(R.id.ic_back_plan);
        ic_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(context, PlanActivity.class);
                startActivity(intent);
            }
        });

        saveBtn = (Button) findViewById(R.id.saveBtn);
        saveBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                float totalSum = 0;
                UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
                String email = userDataContent.getEmail();
                String name = userDataContent.getDailyFoodName();
                String sGrams = addGrams.getText().toString();
                String sCalories = db.getFoodCalories(name);
                String sFoodGrams = db.getFoodGrams(name);
                float grams = Float.parseFloat(sGrams);
                float calories = Float.parseFloat(sCalories);
                float foodGrams = Float.parseFloat(sFoodGrams);
                float sum = grams * (calories / foodGrams);
                String date = userDataContent.getDate();
                String sSum = String.valueOf(sum);
                db.insertDailyFoods(name, sGrams, sSum, date);
                int number;
                number = db.getNumberofFoodsForDate(date);
                ArrayList<String> allCalories = db.getAllCalories(date);
                for (int i = 0; i < number; i++) {
                    String sFoodCalories = allCalories.get(i);
                    float foodCalories = Float.parseFloat(sFoodCalories);
                    totalSum += foodCalories;
                }
                String sTotalSum = String.valueOf(totalSum);
                userDataContent.setTotalCalories(sTotalSum);
                Boolean chkDailyCalories = db.chkDailyCalories(date);
                if (chkDailyCalories){
                    db.UpdateDailyCalories(sTotalSum, date, email);
                }else{
                    db.insertDailyCalories(sTotalSum, date, email);
                }
                Intent intent = new Intent(context, PlanActivity.class);
                startActivity(intent);
            }
        });

        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, foods);
        arrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinnerFood.setAdapter(arrayAdapter);
        spinnerFood.setOnItemSelectedListener(this);
    }

    @Override
    public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
        Toast.makeText(getApplicationContext(), "Food selected" ,Toast.LENGTH_SHORT).show();
        UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
        String name = foods.get(i);
        userDataContent.setDailyFoodName(name);
    }

    @Override
    public void onNothingSelected(AdapterView<?> adapterView) {

    }

    private static int changeToInt (String string){
        String temp = "";
        for(int i = 0; i < string.length(); i++){
            char ch = string.charAt(i);
            if (Character.isDigit(ch))
                temp += ch;
        }
        return Integer.parseInt(temp);
    }
}
