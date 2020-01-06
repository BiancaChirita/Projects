package com.example.dietapp;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import com.example.dietapp.Utils.BottomNavigationViewHelper;
import com.example.dietapp.Utils.DailyCaloriesAdapter;
import com.example.dietapp.Utils.DailyCaloriesContent;
import com.example.dietapp.Utils.DatabaseHelper;
import com.example.dietapp.Utils.UserDataContent;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import org.w3c.dom.Text;

import java.util.ArrayList;

public class PlanActivity extends AppCompatActivity {

    DatabaseHelper db;
    private static final String TAG = "PlanActivity";
    private static final int ACTIVITY_NUM = 0;

    private Context context = PlanActivity.this;

    TextView txtAdd, txtTotalCalories;
    ListView listView;

    ArrayList<DailyCaloriesContent> arrayList = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_plan);

        UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
        String email = userDataContent.getEmail();
        if (email.equals("")){
            Intent intent = new Intent(context, StartActivity.class);
            startActivity(intent);
        }

        db = new DatabaseHelper(this);


        listView = (ListView) findViewById(R.id.dailyView);

        txtAdd = (TextView) findViewById(R.id.txtAdd);
        txtAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(context, AddPlanActivity.class);
                startActivity(intent);
            }
        });

        txtTotalCalories = (TextView) findViewById(R.id.txtTotalCalories);
        String date = userDataContent.getDate();
        String totalCalories = db.getTotalCalories(date);
        txtTotalCalories.setText(totalCalories);

        arrayList = db.getAllDailyCalories(email);
        DailyCaloriesAdapter dailyCaloriesAdapter = new DailyCaloriesAdapter(this, arrayList);
        listView.setAdapter(dailyCaloriesAdapter);

        setupBottomNavigationView();
        setupToolbar();
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
