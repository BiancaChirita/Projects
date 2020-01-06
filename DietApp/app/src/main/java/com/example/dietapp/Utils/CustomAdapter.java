package com.example.dietapp.Utils;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.dietapp.R;

import java.util.ArrayList;

public class CustomAdapter extends BaseAdapter {

    private Context context;
    ArrayList<DataContent> content;

    public CustomAdapter(Context context, ArrayList<DataContent> content){
        this.context = context;
        this.content = content;
    }

    @Override
    public int getCount(){
        return content.size();
    }

    @Override
    public Object getItem(int position){
        return content.get(position);
    }

    @Override
    public long getItemId(int position){
        return position;
    }

    private class ViewHolder{
        TextView txtName, txtGrams, txtCalories;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent){

        ViewHolder holder;

        if(convertView == null){
            LayoutInflater inflater = (LayoutInflater) context.getSystemService(context.LAYOUT_INFLATER_SERVICE);
            convertView = inflater.inflate(R.layout.layout_center_food_list, null);
            holder = new ViewHolder();
            holder.txtName = (TextView) convertView.findViewById(R.id.tvFoodName);
            holder.txtGrams = (TextView) convertView.findViewById(R.id.tvGrams);
            holder.txtCalories = (TextView) convertView.findViewById(R.id.tvCaloriesCount);

            convertView.setTag(holder);
        }else {
            holder = (ViewHolder) convertView.getTag();
        }

        final DataContent dataContent = content.get(position);
        holder.txtName.setText(dataContent.getFoodName());
        holder.txtGrams.setText(dataContent.getFoodGrams());
        holder.txtCalories.setText(dataContent.getFoodCalories());

        return convertView;

    }

}
