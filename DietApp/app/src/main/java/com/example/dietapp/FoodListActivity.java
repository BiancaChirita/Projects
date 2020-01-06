package com.example.dietapp;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import com.example.dietapp.Utils.BottomNavigationViewHelper;
import com.example.dietapp.Utils.CustomAdapter;
import com.example.dietapp.Utils.DataContent;
import com.example.dietapp.Utils.DatabaseHelper;
import com.example.dietapp.Utils.UserDataContent;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.util.ArrayList;

public class FoodListActivity extends AppCompatActivity {

    DatabaseHelper db;
    private static final String TAG = "FoodListActivity";
    private static final int ACTIVITY_NUM = 1;

    private Context context = FoodListActivity.this;

    ArrayList<DataContent> arrayList = new ArrayList<>();
    ListView listView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_food_list);
        Log.d(TAG, "onCreate: started");

        UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
        String email = userDataContent.getEmail();
        if (email.equals("")){
            Intent intent = new Intent(context, StartActivity.class);
            startActivity(intent);
        }

        db = new DatabaseHelper(this);

        setupBottomNavigationView();
        setupToolbar();

        TextView add = (TextView) findViewById(R.id.tvAddFood);
        add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(context, AddFoodActivity.class);
                startActivity(intent);
            }
        });

        listView = (ListView) findViewById(R.id.foodListView);

        arrayList = db.getAllFoodData();

        CustomAdapter customAdapter = new CustomAdapter(this, arrayList);
        listView.setAdapter(customAdapter);
    }

    private void setupToolbar(){
        Toolbar toolbar = (Toolbar) findViewById(R.id.profileToolbar);
        setSupportActionBar(toolbar);

        ImageView settingMenu = (ImageView) findViewById(R.id.settingMenu);
        settingMenu.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Log.d(TAG, "onClick: navigation to account settings.");
                Intent intent = new Intent(context, AccountSettingsActivity.class);
                startActivity(intent);
            }
        });
    }

    private void setupBottomNavigationView(){
        Log.d(TAG, "setupBottomNavigationView: seting up BottomNavigationView");
        BottomNavigationView bottomNavigationView = (BottomNavigationView) findViewById(R.id.nav_view);
        BottomNavigationViewHelper.setupBottomNavigationView(bottomNavigationView);
        BottomNavigationViewHelper.enableNavigation(context, bottomNavigationView);
        Menu menu = bottomNavigationView.getMenu();
        MenuItem menuItem = menu.getItem(ACTIVITY_NUM);
        menuItem.setChecked(true);
    }

}
