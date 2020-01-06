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
import com.example.dietapp.Utils.UserDataContent;

public class EditUserDetailsActivity extends AppCompatActivity {

    public static final String TAG = "EditUserDetailsActivity";

    EditText username, password, confirmPassword;
    DatabaseHelper db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_user_details);

        db = new DatabaseHelper(this);

        username = (EditText) findViewById(R.id.edit_username);
        password = (EditText) findViewById(R.id.edit_password);
        confirmPassword = (EditText) findViewById(R.id.edit_confirm_password);

        ImageView backArrow = (ImageView) findViewById(R.id.ic_back_account);
        backArrow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Log.d(TAG, "onClick: navigating back to 'AccountSettingsActivity'");
                finish();
            }
        });

        ImageView saveIcon = (ImageView) findViewById(R.id.ic_save);
        saveIcon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String sUsername = username.getText().toString();
                String sPassword = password.getText().toString();
                String sConfirmPassword = confirmPassword.getText().toString();

                if(sUsername.equals("") || sPassword.equals("") || sConfirmPassword.equals("")){
                    Toast.makeText(getApplicationContext(), "Fields are empty", Toast.LENGTH_SHORT).show();
                }else {
                    if (sPassword.equals(sConfirmPassword)) {
                        UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
                        String sEmail = userDataContent.getEmail();
                        db.UpdateUserDetails(sEmail, sUsername, sPassword);
                        userDataContent.setUsername(sUsername);
                        userDataContent.setPassword(sPassword);
                        Intent intent = new Intent(EditUserDetailsActivity.this, HomeActivity.class);
                        startActivity(intent);

                    } else {
                        Toast.makeText(getApplicationContext(), "Passwords do not match", Toast.LENGTH_SHORT).show();
                    }
                }

            }
        });

    }
}
