package com.example.dietapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.dietapp.Utils.DatabaseHelper;

public class RegisterActivity extends AppCompatActivity {

    private static final String EXTRA_ADD_UPDATE = "com.example.insertUser";
    DatabaseHelper db;
    Button registerBtn;
    EditText email, username, password, confPassword;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        db = new DatabaseHelper(this);

        email = (EditText) findViewById(R.id.emailRegister);
        username = (EditText) findViewById(R.id.usernameRegister);
        password = (EditText) findViewById(R.id.passwordRegister);
        confPassword = (EditText) findViewById(R.id.confirmPasswordRegister);
        registerBtn = (Button) findViewById(R.id.registerBtn);

        registerBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String sEmail = email.getText().toString();
                String sUsername = username.getText().toString();
                String sPassword = password.getText().toString();
                String sConfPassword = confPassword.getText().toString();

                if(sEmail.equals("") || sUsername.equals("") || sPassword.equals("") || sConfPassword.equals("")){
                    Toast.makeText(getApplicationContext(), "Fields are empty", Toast.LENGTH_SHORT).show();
                }else {
                    if(sPassword.equals(sConfPassword)){
                        Boolean chkEmail = db.chkEmail(sEmail);
                        if(chkEmail){
                            Boolean insert = db.insertUser(sEmail, sUsername, sPassword);
                            if(insert){
                                Intent intent = new Intent(RegisterActivity.this, LoginActivity.class);
                                startActivity(intent);
                            }else {
                                Toast.makeText(getApplicationContext(), "Email already exists", Toast.LENGTH_SHORT).show();
                            }
                        }else {
                            Toast.makeText(getApplicationContext(), "Password do not match", Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            }
        });
    }
}
