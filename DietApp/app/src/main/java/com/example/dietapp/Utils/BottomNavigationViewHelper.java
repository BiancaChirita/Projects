package com.example.dietapp.Utils;

import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.view.MenuItem;

import androidx.annotation.NonNull;

import com.example.dietapp.FoodListActivity;
import com.example.dietapp.HomeActivity;
import com.example.dietapp.PlanActivity;
import com.example.dietapp.R;
import com.google.android.material.bottomnavigation.BottomNavigationView;

public class BottomNavigationViewHelper {
    private static final String TAG = "BottomNavigationView";

    public static void setupBottomNavigationView(BottomNavigationView bottomNavigationView){
        Log.d(TAG, "setupBottomNavigationView: Setting up BottomNavigationView");
    }

    public static void enableNavigation(final Context context, BottomNavigationView view){
        view.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
                switch (menuItem.getItemId()){
                    case R.id.ic_plan:
                        Intent intent2 = new Intent(context, PlanActivity.class);
                        context.startActivity(intent2);
                        break;

                    case R.id.ic_list:
                        Intent intent3 = new Intent(context, FoodListActivity.class);
                        context.startActivity(intent3);
                        break;

                    case R.id.ic_person:
                        Intent intent1 = new Intent(context, HomeActivity.class);
                        context.startActivity(intent1);
                        break;
                }
                return false;
            }
        });
    }
}
