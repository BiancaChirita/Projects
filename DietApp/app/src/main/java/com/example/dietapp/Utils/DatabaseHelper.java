package com.example.dietapp.Utils;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.util.Base64;

import java.util.ArrayList;

public class DatabaseHelper extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "Db9.db";
    private static final int DATABASE_VERSION = 1;

    private static final String TABLE_USERS = "users";
    private static final String COLUMN_EMAIL = "email";
    private static final String COLUMN_USERNAME = "username";
    private static final String COLUMN_PASSWORD = "password";

    private static final String TABLE_FOODS = "foods";
    private static final String COLUMN_NAME = "name";
    private static final String COLUMN_GRAMS = "grams";
    private static final String COLUMN_CALORIES = "calories";

    private static final String TABLE_USERS_ADDITIONS = "users_additions";
    private static final String COLUMN_USER_NAME = "user_name";
    private static final String COLUMN_USER_DESCRIPTION = "user_description";
    private static final String COLUMN_USER_IMAGE = "user_image";

    private static final String TABLE_DAILY_CALORIES = "daily_calories";
    private static final String COLUMN_TOTAL_CALORIES = "total_calories";
    private static final String COLUMN_DATE = "date";

    private static final String TABLE_DAILY_FOODS = "daily_foods";
    private static final String COLUMN_FOOD_NAME = "food_name";
    private static final String COLUMN_FOOD_GRAMS = "food_grams";
    private static final String COLUMN_FOOD_CALORIES = "food_calories";

    public DatabaseHelper(Context context){
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }


    private static final String TABLE_CREATE =
                " CREATE TABLE " + TABLE_USERS +"(" +
                        COLUMN_EMAIL + " TEXT NOT NULL PRIMARY KEY, " +
                        COLUMN_USERNAME + " TEXT NOT NULL, " +
                        COLUMN_PASSWORD + " TEXT NOT NULL) ";

    private static final String TABLE_FOOD_CREATE =
                " CREATE TABLE " + TABLE_FOODS + "(" +
                        COLUMN_NAME + " TEXT NOT NULL PRIMARY KEY, " +
                        COLUMN_GRAMS + " TEXT NOT NULL, " +
                        COLUMN_CALORIES + " TEXT NOT NULL) ";

    private static final String TABLE_USER_ADDITION_CREATE =
                " CREATE TABLE " + TABLE_USERS_ADDITIONS + "(" +
                        COLUMN_USER_NAME + " TEXT NOT NULL, " +
                        COLUMN_USER_DESCRIPTION + " TEXT NOT NULL, "  +
                        COLUMN_USER_IMAGE + " TEXT, " +
                        COLUMN_EMAIL + " TEXT NOT NULL, " +
                        " FOREIGN KEY(" + COLUMN_EMAIL + ")REFERENCES " + TABLE_USERS + "(" + COLUMN_EMAIL + ")" + ")";

    private static final String TABLE_DAILY_CALORIES_CREATE =
                " CREATE TABLE " + TABLE_DAILY_CALORIES + "(" +
                        COLUMN_TOTAL_CALORIES + " TEXT NOT NULL, " +
                        COLUMN_DATE + " TEXT PRIMARY KEY, " +
                        COLUMN_EMAIL + " TEXT NOT NULL, " +
                        " FOREIGN KEY(" + COLUMN_EMAIL + ")REFERENCES " + TABLE_USERS + "(" + COLUMN_EMAIL + ")" + ")";

    private static final String TABLE_DAILY_FOODS_CREATE =
                " CREATE TABLE " + TABLE_DAILY_FOODS + "(" +
                        COLUMN_FOOD_NAME + " TEXT NOT NULL, " +
                        COLUMN_FOOD_GRAMS + " TEXT NOT NULL, " +
                        COLUMN_FOOD_CALORIES + " TEXT NOT NULL, " +
                        COLUMN_DATE + " TEXT NOT NULL, " +
                        " FOREIGN KEY(" + COLUMN_DATE + ")REFERENCES " + TABLE_DAILY_CALORIES + "(" + COLUMN_DATE + ")" + ")";

    public void onCreate(SQLiteDatabase db) {
        db.execSQL(TABLE_CREATE);
        db.execSQL(TABLE_FOOD_CREATE);
        db.execSQL(TABLE_USER_ADDITION_CREATE);
        db.execSQL(TABLE_DAILY_CALORIES_CREATE);
        db.execSQL(TABLE_DAILY_FOODS_CREATE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion){
        db.execSQL(" DROP TABLE IF EXISTS " + TABLE_USERS);
        db.execSQL(TABLE_CREATE);

        db.execSQL(" DROP TABLE IF EXISTS " + TABLE_FOODS);
        db.execSQL(TABLE_FOOD_CREATE);

        db.execSQL(" DROP TABLE IF EXISTS " + TABLE_USERS_ADDITIONS);
        db.execSQL(TABLE_USER_ADDITION_CREATE);

        db.execSQL(" DROP TABLE IF EXISTS " + TABLE_DAILY_CALORIES);
        db.execSQL(TABLE_DAILY_CALORIES_CREATE);

        db.execSQL(" DROP TABLE IF EXISTS " + TABLE_DAILY_FOODS);
        db.execSQL(TABLE_DAILY_FOODS_CREATE);
    }

    //inserting in users table
    public Boolean insertUser(String email, String username, String password){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COLUMN_EMAIL, email);
        contentValues.put(COLUMN_USERNAME, username);
        contentValues.put(COLUMN_PASSWORD, password);
        long in = db.insert(TABLE_USERS, null, contentValues);
        if(in == 1)
            return false;
        else {
            insertAdditionalData("", "", null,email);
            insertDailyCalories("", "", email);
            return true;
        }
    }

    //inserting in foods table
    public Boolean insertFood (String name, String grams, String calories){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COLUMN_NAME, name);
        contentValues.put(COLUMN_GRAMS, grams);
        contentValues.put(COLUMN_CALORIES, calories);
        long in = db.insert(TABLE_FOODS, null, contentValues);
        if(in == 1)
            return false;
        else
            return true;
    }

    //inserting the additional data for an user
    private void insertAdditionalData (String userName, String userDescription, byte[] userImage, String email){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COLUMN_USER_NAME, userName);
        contentValues.put(COLUMN_USER_DESCRIPTION, userDescription);
        contentValues.put(COLUMN_USER_IMAGE, userImage);
        contentValues.put(COLUMN_EMAIL, email);
        db.insert(TABLE_USERS_ADDITIONS, null, contentValues);
    }

    //inserting in daily calories table
    public Boolean insertDailyCalories (String totalCalories, String date, String email){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COLUMN_TOTAL_CALORIES, totalCalories);
        contentValues.put(COLUMN_DATE, date);
        contentValues.put(COLUMN_EMAIL, email);
        long in = db.insert(TABLE_DAILY_CALORIES, null, contentValues);
        if (in == 1)
            return false;
        else {
            insertDailyFoods("", "0", "0", date);
            return true;
        }
    }

    //inserting in daily foods table
    public Boolean insertDailyFoods (String name, String grams, String calories, String date){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COLUMN_FOOD_NAME, name);
        contentValues.put(COLUMN_FOOD_GRAMS, grams);
        contentValues.put(COLUMN_FOOD_CALORIES, calories);
        contentValues.put(COLUMN_DATE, date);
        long in = db.insert(TABLE_DAILY_FOODS, null, contentValues);
        if (in == 1)
            return false;
        else
            return true;
    }

    //checking if email exists
    public Boolean chkEmail(String email){
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_USERS + " WHERE "+ COLUMN_EMAIL + " = ? ", new String[]{email});
        if (cursor.getCount() > 0)
            return false;
        else
            return true;
    }

    //checking the email and password
    public Boolean chkEmailPassword(String email, String password){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery("SELECT * FROM "+ TABLE_USERS +" WHERE "+ COLUMN_EMAIL + " = ? AND " + COLUMN_PASSWORD + " = ?",
                new String[]{email, password});
        if(cursor.getCount() > 0)
            return true;
        else
            return false;
    }

    public Boolean chkDailyCalories(String date){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_DAILY_CALORIES + " WHERE " + COLUMN_DATE + "=?",
                new String[]{date});
        if(cursor.getCount() > 0)
            return true;
        else
            return false;
    }

    //deleting the user from table
    public void deleteUser(String email, String date) {
        SQLiteDatabase db = this.getWritableDatabase();
        db.execSQL(" DELETE FROM " + TABLE_DAILY_FOODS + " WHERE " + COLUMN_DATE + " ='" + date + "'");
        db.execSQL(" DELETE FROM " + TABLE_DAILY_CALORIES + " WHERE " + COLUMN_EMAIL + " ='" + email + "'");
        db.execSQL(" DELETE FROM " + TABLE_USERS_ADDITIONS + " WHERE " + COLUMN_EMAIL + " ='" + email + "'");
        db.execSQL(" DELETE FROM " + TABLE_USERS + " WHERE " + COLUMN_EMAIL + " ='" + email + "'");

        db.close();
    }

    public void deleteFood(String name){
        SQLiteDatabase db = this.getWritableDatabase();
        db.execSQL(" DELETE FROM " + TABLE_FOODS + " WHERE " + COLUMN_NAME + "='" + name + "'");

        db.close();
    }

    public void UpdateUserDetails(String email, String username, String password){
        SQLiteDatabase db = this.getReadableDatabase();
        db.execSQL(" UPDATE " + TABLE_USERS + " SET " + COLUMN_USERNAME + " ='" + username + "' , " + COLUMN_PASSWORD +
                " ='" + password + "' WHERE " + COLUMN_EMAIL + " ='" + email + "' " );
        db.close();
    }

    public void UpdateUserAdditionData(String userName, String userDescription, String userImage, String email){
        SQLiteDatabase db = this.getReadableDatabase();
        db.execSQL(" UPDATE " + TABLE_USERS_ADDITIONS + " SET " + COLUMN_USER_NAME + "='" + userName + "' , " +
                COLUMN_USER_DESCRIPTION + "='" + userDescription + "' , " + COLUMN_USER_IMAGE + " ='" + userImage + "' " +
                " WHERE " + COLUMN_EMAIL + "='" + email + "' ");
        db.close();
    }

    public void UpdateDailyCalories(String totalCalories, String date, String email){
        SQLiteDatabase db = this.getReadableDatabase();
        db.execSQL(" UPDATE " + TABLE_DAILY_CALORIES + " SET " + COLUMN_TOTAL_CALORIES + "='" + totalCalories + "' WHERE " +
                COLUMN_DATE + "='" + date + "' AND " + COLUMN_EMAIL + "='" + email + "'");
        db.close();
    }

    public void UpdateDailyFoods(String name, String grams, String calories, String date){
        SQLiteDatabase db = this.getReadableDatabase();
        db.execSQL(" UPDATE " + TABLE_DAILY_FOODS + " SET " + COLUMN_FOOD_NAME + "='" + name + "' , " +
                COLUMN_FOOD_GRAMS + "='" + grams + "' , " + COLUMN_FOOD_CALORIES + "='" + calories + "' WHERE " +
                COLUMN_DATE + "='" + date + "'");
        db.close();
    }

    public void UpdateFoods(String name, String grams, String calories){
        SQLiteDatabase db = this.getReadableDatabase();
        db.execSQL(" UPDATE " + TABLE_FOODS + " SET " + COLUMN_GRAMS + "='" + grams + "' , " +
                COLUMN_CALORIES + "='" + calories + "' WHERE " + COLUMN_NAME + "='" + name + "'");
        db.close();
    }

    public ArrayList<DataContent> getAllFoodData() {
        ArrayList<DataContent> foodList = new ArrayList<>();
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_FOODS,null);

        while(cursor.moveToNext()) {
            String name = cursor.getString(cursor.getColumnIndex(COLUMN_NAME));
            String grams = cursor.getString(cursor.getColumnIndex(COLUMN_GRAMS));
            String calories = cursor.getString(cursor.getColumnIndex(COLUMN_CALORIES));

            DataContent dataContent = new DataContent(name, grams, calories);
            foodList.add(dataContent);
        }
        return foodList;
    }

    public ArrayList<String> getAllFoodNames(){
        ArrayList<String> nameList = new ArrayList<>();
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_FOODS, null);

        while (cursor.moveToNext()){
            String name = cursor.getString(cursor.getColumnIndex(COLUMN_NAME));

            nameList.add(name);
        }
        return nameList;
    }

    public ArrayList<DailyCaloriesContent> getAllDailyCalories(String email) {
        ArrayList<DailyCaloriesContent> allDailyCalories = new ArrayList<>();
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_DAILY_CALORIES + " WHERE " + COLUMN_EMAIL + "=?",
                new String[]{email});

        while(cursor.moveToNext()) {
            String date = cursor.getString(cursor.getColumnIndex(COLUMN_DATE));
            String totalCalories = cursor.getString(cursor.getColumnIndex(COLUMN_TOTAL_CALORIES));

            DailyCaloriesContent dailyCaloriesContent = new DailyCaloriesContent(date,totalCalories);
            allDailyCalories.add(dailyCaloriesContent);
        }
        return allDailyCalories;
    }

    public ArrayList<String> getAllCalories(String date){
        ArrayList<String> caloriesList = new ArrayList<>();
        SQLiteDatabase db =  this.getWritableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_DAILY_FOODS + " WHERE " + COLUMN_DATE + "=?",
                new String[]{date});

        while (cursor.moveToNext()){
            String calories = cursor.getString(cursor.getColumnIndex(COLUMN_FOOD_CALORIES));

            caloriesList.add(calories);
        }
        return caloriesList;
    }

    public int getNumberofFoodsForDate(String date){
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_DAILY_FOODS + " WHERE " + COLUMN_DATE + "=?",
                new String[]{date});

        int number = 0;
        while (cursor.moveToNext()){
            number++;
        }
        return number;
    }

    public String getUsername(String email){
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_USERS + " WHERE " + COLUMN_EMAIL + " =? ",
                new String[]{email});
        cursor.moveToFirst();
        return cursor.getString(cursor.getColumnIndex(COLUMN_USERNAME));
    }

    public Boolean chkUserData(String email){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_USERS_ADDITIONS + " WHERE "+ COLUMN_EMAIL + " =? ", new String[]{email});
        if (cursor.getCount() > 0)
            return true;
        else
            return false;
    }

    public Bitmap getUserImage(String email){
        SQLiteDatabase db = this.getWritableDatabase();
        String query = " SELECT * FROM " + TABLE_USERS_ADDITIONS + " WHERE " + COLUMN_EMAIL + " =? ";
        Cursor cursor = db.rawQuery(query, new String[]{email});
        Bitmap image ;

        if(cursor.moveToNext()){
            String imageBase64 = cursor.getString(cursor.getColumnIndex(COLUMN_USER_IMAGE));
            if (imageBase64 == null){
                return null;
            }else{
                byte[] imageByte = Base64.decode(imageBase64, Base64.DEFAULT);
                image = BitmapFactory.decodeByteArray(imageByte, 0, imageByte.length);
                return image;
            }
        }
        if(cursor != null && !cursor.isClosed()){
            cursor.close();
        }
        return null;
    }

    public String getUserName (String email){
        SQLiteDatabase db = this.getReadableDatabase();
        String query = " SELECT * FROM " + TABLE_USERS_ADDITIONS + " WHERE " + COLUMN_EMAIL + "=?";
        Cursor cursor = db.rawQuery(query, new String[]{email});

        if (cursor.getCount() > 0){
            cursor.moveToFirst();
            return cursor.getString(cursor.getColumnIndex(COLUMN_USER_NAME));
        }
        else
            return "";
    }

    public String getUserDescription (String email){
        SQLiteDatabase db = this.getReadableDatabase();
        String query = " SELECT * FROM " + TABLE_USERS_ADDITIONS + " WHERE " + COLUMN_EMAIL + "=?";
        Cursor cursor = db.rawQuery(query, new String[]{email});

        if (cursor.getCount() > 0){
            cursor.moveToFirst();
            return cursor.getString(cursor.getColumnIndex(COLUMN_USER_DESCRIPTION));
        }
        else
            return "";
    }

    public String getFoodCalories(String name){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_FOODS + " WHERE " + COLUMN_NAME + "=?",
                new String[]{name});

        if(cursor.getCount() > 0){
            cursor.moveToFirst();
            return cursor.getString(cursor.getColumnIndex(COLUMN_CALORIES));
        }else
            return "";
    }

    public String getFoodGrams(String name){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_FOODS + " WHERE " + COLUMN_NAME + "=?",
                new String[]{name});

        if(cursor.getCount() > 0){
            cursor.moveToFirst();
            return cursor.getString(cursor.getColumnIndex(COLUMN_GRAMS));
        }else
            return "";
    }

    public String getTotalCalories(String date){
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(" SELECT * FROM " + TABLE_DAILY_CALORIES + " WHERE " + COLUMN_DATE + "=?",
                new String[]{date});

        if (cursor.getCount() > 0){
            cursor.moveToFirst();
            return cursor.getString(cursor.getColumnIndex(COLUMN_TOTAL_CALORIES));
        }else
            return "";
    }

}
