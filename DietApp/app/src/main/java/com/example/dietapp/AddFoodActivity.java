package com.example.dietapp;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.dietapp.Utils.DatabaseHelper;

public class AddFoodActivity extends AppCompatActivity {

    public static final String TAG = "AddFoodActivity";

    EditText name, grams, calories;
    ImageView save;
    Intent intent;
    DatabaseHelper db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_food);
        Log.d(TAG, "onCreate: started");

        db = new DatabaseHelper(this);

        ImageView backArrow = (ImageView) findViewById(R.id.ic_back);
        backArrow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Log.d(TAG, "onClick: navigating back to 'FoodListActivity'");
                finish();
            }
        });

        name = (EditText)findViewById(R.id.addFoodName);
        grams = (EditText)findViewById(R.id.addGrams);
        calories = (EditText)findViewById(R.id.addCalories);
        save = (ImageView) findViewById(R.id.ic_save);
        save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String food_name = name.getText().toString()+"\n";
                String food_grams = grams.getText().toString();
                String food_calories = calories.getText().toString();
                Boolean insert = db.insertFood(food_name, food_grams, food_calories);

                if (insert){
                    intent = new Intent(AddFoodActivity.this, FoodListActivity.class);
                    startActivity(intent);
                    Toast.makeText(getApplicationContext(), "Addition Successful",Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}
