package com.example.dietapp;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.example.dietapp.Utils.BottomNavigationViewHelper;
import com.example.dietapp.Utils.CustomAdapter;
import com.example.dietapp.Utils.DatabaseHelper;
import com.example.dietapp.Utils.UserDataContent;
import com.google.android.material.bottomnavigation.BottomNavigationView;

public class AccountSettingsActivity extends AppCompatActivity {

    private static final String TAG = "AccountSettingsActivity";
    private Context context = AccountSettingsActivity.this;
    private static final int ACTIVITY_NUM = 2;

    DatabaseHelper db;
    SQLiteDatabase sqLiteDatabase;
    CustomAdapter customAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings);
        Log.d(TAG, "onCreate: started");

        db = new DatabaseHelper(this);

        setupBottomNavigationView();

        TextView editProfile = (TextView) findViewById(R.id.editProfile);
        TextView editAccount = (TextView) findViewById(R.id.editAccountTv);
        final TextView deleteAccount = (TextView) findViewById(R.id.tvDeleteAccount);
        TextView logOut = (TextView) findViewById(R.id.tvLogOut);

        editProfile.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                click(view);
            }
        });
        editAccount.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                click(view);
            }
        });
        deleteAccount.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                AlertDialog.Builder builder = new AlertDialog.Builder(context);
                builder.setTitle("Are you sure?");

                builder.setPositiveButton("Yes", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialogInterface, int i) {

                        UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
                        String email = userDataContent.getEmail();
                        String date = userDataContent.getDate();
                        db.deleteUser(email, date);

                        Intent intent;
                        intent = new Intent(context, StartActivity.class);
                        startActivity(intent);

                    }
                });

                builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialogInterface, int i) {

                        Intent intent;
                        intent = new Intent(context, AccountSettingsActivity.class);
                        startActivity(intent);

                    }
                });

                AlertDialog dialog = builder.create();
                dialog.show();
            }
        });
        logOut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
                userDataContent.setEmail("");
                click(view);
            }
        });

        ImageView backArrow = (ImageView) findViewById(R.id.backArrowOptions);
        backArrow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Log.d(TAG, "onClick: navigating back to 'HomeActivity'");
                finish();
            }
        });

    }

    private void setupBottomNavigationView(){
        Log.d(TAG, "setupBottomNavigationView: setting up BottomNavigationView");
        BottomNavigationView bottomNavigationView = (BottomNavigationView) findViewById(R.id.nav_view);
        BottomNavigationViewHelper.setupBottomNavigationView(bottomNavigationView);
        BottomNavigationViewHelper.enableNavigation(context, bottomNavigationView);
        Menu menu = bottomNavigationView.getMenu();
        MenuItem menuItem = menu.getItem(ACTIVITY_NUM);
        menuItem.setChecked(true);
    }

    public void click(View v) {
        Intent intent = null;
        switch(v.getId()) {
            case R.id.editProfile:
                intent = new Intent(this, EditActivity.class);
                break;
            case R.id.editAccountTv:
                intent = new Intent(this, EditUserDetailsActivity.class);
                break;
            case R.id.tvDeleteAccount:
                break;
            case R.id.tvLogOut:
                finish();

                intent = new Intent(this, StartActivity.class);
                Toast.makeText(context,"Log Out Successful", Toast.LENGTH_LONG).show();
                break;
        }
        startActivity(intent);
    }

}
