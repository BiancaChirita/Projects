package com.example.dietapp;

import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.util.Log;
import android.view.Display;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import com.example.dietapp.Utils.BottomNavigationViewHelper;
import com.example.dietapp.Utils.DatabaseHelper;
import com.example.dietapp.Utils.UserDataContent;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.io.ByteArrayOutputStream;
import java.sql.SQLException;

public class HomeActivity extends AppCompatActivity {

    DatabaseHelper db;
    private static final String TAG = "HomeActivity";
    private static final int ACTIVITY_NUM = 2;

    private Context context = HomeActivity.this;

    TextView usernameTV, nameTV, descriptionTV;
    ImageView imageIV;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
        Log.d(TAG, "onCreate: started");
        UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
        String email = userDataContent.getEmail();
        if (email.equals("")){
            Intent intent = new Intent(context, StartActivity.class);
            startActivity(intent);
        }

        db = new DatabaseHelper(this);

        usernameTV = (TextView) findViewById(R.id.usernameTxtView);
        nameTV = (TextView) findViewById(R.id.nameTxtView);
        descriptionTV = (TextView) findViewById(R.id.descriptionTxtView);

        imageIV =(ImageView) findViewById(R.id.profileImgView);


        String username = db.getUsername(email);
        String name = db.getUserName(email);
        String description = db.getUserDescription(email);

        usernameTV.setText(username);
        nameTV.setText(name);
        descriptionTV.setText(description);

        Intent in = getIntent();
        int index = in.getIntExtra("com.example.ITEM_INDEX", -1);
        Bitmap bitmap = null;
        bitmap = db.getUserImage(email);

        if(bitmap !=null){
            imageIV.setImageBitmap(bitmap);
        }else {

            int image = getImage(index);
            scaleImage(imageIV, image);
        }


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

    private int getImage(int index){
        return R.drawable.profile_icon;
    }

    private void scaleImage(ImageView img, int pic){
        Display screen = getWindowManager().getDefaultDisplay();
        BitmapFactory.Options options = new BitmapFactory.Options();

        options.inJustDecodeBounds = true;
        BitmapFactory.decodeResource(getResources(), pic, options);

        int imgWidth = options.outWidth;
        int screenWidth = screen.getWidth();

        if(imgWidth > screenWidth){
            int ratio = Math.round((float)imgWidth/(float)screenWidth);
            options.inSampleSize = ratio;
        }

        options.inJustDecodeBounds = false;
        Bitmap scaleImg = BitmapFactory.decodeResource(getResources(), pic, options);
        img.setImageBitmap(scaleImg);
    }

}
