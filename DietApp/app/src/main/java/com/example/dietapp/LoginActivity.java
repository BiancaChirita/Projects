package com.example.dietapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import androidx.appcompat.app.AppCompatActivity;

import com.example.dietapp.Utils.DatabaseHelper;
import com.example.dietapp.Utils.UserDataContent;

public class LoginActivity extends AppCompatActivity {

    Button loginBtn;
    EditText email, password;
    TextView goRegisterLink;

    DatabaseHelper db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        email = (EditText) findViewById(R.id.emailLogin);
        password = (EditText) findViewById(R.id.passwordLogin);
        loginBtn = (Button) findViewById(R.id.loginBtn);
        goRegisterLink = (TextView) findViewById(R.id.goRegisterLink);
        db = new DatabaseHelper(this);

        goRegisterLink.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent startIntent = new Intent(getApplicationContext(), RegisterActivity.class);
                startActivity(startIntent);
            }
        });


        loginBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String sEmail = email.getText().toString();
                String sPassword = password.getText().toString();
                String sDate = getCurrentDate();

                Boolean chkEmailPassword = db.chkEmailPassword(sEmail, sPassword);
                if(chkEmailPassword){
                    Intent intent = new Intent(LoginActivity.this, HomeActivity.class);
                    startActivity(intent);
                    UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
                    userDataContent.setEmail(sEmail);
                    String sUsername = db.getUsername(sEmail);
                    userDataContent.setUsername(sUsername);
                    userDataContent.setPassword(sPassword);
                    userDataContent.setDate(sDate);
                }else{
                    Toast.makeText(getApplicationContext(), "Wrong email or password", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }

    public String getCurrentDate() {
        Calendar calendar = Calendar.getInstance();
        SimpleDateFormat mdformat = new SimpleDateFormat("dd / MM / yyyy ");
        String strDate = mdformat.format(calendar.getTime());
        return strDate;
    }
}
