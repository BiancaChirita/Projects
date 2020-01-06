package com.example.dietapp;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.graphics.Bitmap;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.util.Base64;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.dietapp.Utils.DatabaseHelper;
import com.example.dietapp.Utils.UserDataContent;

import java.io.ByteArrayOutputStream;

public class EditActivity extends AppCompatActivity {

    public static final String TAG = "EditActivity";
    private static final int GALLERY_REQUEST_CODE = 1 ;
    private Context context = EditActivity.this;

    DatabaseHelper db;
    EditText userName, userDescription;
    ImageView userImage, saveChanges, backArrow;
    TextView changeImage;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit);

        db = new DatabaseHelper(this);

        userName = (EditText) findViewById(R.id.editName);
        userDescription = (EditText) findViewById(R.id.editDescription);
        userImage = (ImageView) findViewById(R.id.ivChangePhoto);

        changeImage = (TextView) findViewById(R.id.tvChangePhoto);
        changeImage.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                selectImage();
            }
        });

        backArrow = (ImageView) findViewById(R.id.ic_back_profile);
        backArrow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Log.d(TAG, "onClick: navigating back to 'AccountSettingsActivity'");
                finish();
            }
        });

            saveChanges = (ImageView) findViewById(R.id.ic_check);
            saveChanges.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {

                    try{

                    UserDataContent userDataContent = com.example.dietapp.Utils.UserDataContent.getInstance();
                    String email = userDataContent.getEmail();
                    String sUserName = userName.getText().toString();
                    String sUserDescription = userDescription.getText().toString();

                    Boolean chkUserData = db.chkUserData(email);

                    BitmapDrawable drawable = (BitmapDrawable) userImage.getDrawable();
                    Bitmap bitmap = drawable.getBitmap();
                    final byte[] sUserImage = getBitmapAsByteArray(bitmap);
                    String base64Image = Base64.encodeToString(sUserImage, Base64.DEFAULT);

                    if (sUserName.equals("") || sUserDescription.equals("")) {
                        Toast.makeText(getApplicationContext(), "The fields are empty", Toast.LENGTH_SHORT).show();
                    } else {
                        if (chkUserData) {
                            db.UpdateUserAdditionData(sUserName, sUserDescription, base64Image, email);
                            userDataContent.setUserName(sUserName);
                            userDataContent.setDescription(sUserDescription);
                            Intent intent = new Intent(context, HomeActivity.class);
                            startActivity(intent);
                        }
                    }
                    }catch (Exception e){
                        Toast.makeText(context, "Doesn't work", Toast.LENGTH_SHORT).show();
                    }
                }
            });
    }

    private void selectImage(){
        Intent intent = new Intent(Intent.ACTION_PICK);
        intent.setType("image/*");
        String[] mimeTypes = {"image/jpeg", "image/png"};
        intent.putExtra(Intent.EXTRA_MIME_TYPES, mimeTypes);
        startActivityForResult(intent, GALLERY_REQUEST_CODE);
    }

    public void onActivityResult(int requestCode, int resultCode, Intent data){
        if(resultCode == Activity.RESULT_OK)
            switch (requestCode){
                case GALLERY_REQUEST_CODE:
                    Uri selectedImage = data.getData();
                    userImage.setImageURI(selectedImage);
                    break;
            }
    }

    public static byte[] getBitmapAsByteArray(Bitmap bitmap){
        ByteArrayOutputStream outputStream = new ByteArrayOutputStream();
        bitmap.compress(Bitmap.CompressFormat.JPEG, 0, outputStream);
        return outputStream.toByteArray();
    }

}
