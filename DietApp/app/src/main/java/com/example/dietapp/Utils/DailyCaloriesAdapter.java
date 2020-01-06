package com.example.dietapp.Utils;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.dietapp.R;

import java.util.ArrayList;

public class DailyCaloriesAdapter extends BaseAdapter {

    private Context context;
    ArrayList<DailyCaloriesContent> content;

    public DailyCaloriesAdapter(Context context, ArrayList<DailyCaloriesContent> content){
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
        TextView txtDate, txtTotalCalories;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent){

        DailyCaloriesAdapter.ViewHolder holder;

        if(convertView == null){
            LayoutInflater inflater = (LayoutInflater) context.getSystemService(context.LAYOUT_INFLATER_SERVICE);
            convertView = inflater.inflate(R.layout.layout_center_list_plan, null);
            holder = new DailyCaloriesAdapter.ViewHolder();
            holder.txtDate = (TextView) convertView.findViewById(R.id.txtDate);
            holder.txtTotalCalories = (TextView) convertView.findViewById(R.id.txtCaloriesDaily);

            convertView.setTag(holder);
        }else {
            holder = (DailyCaloriesAdapter.ViewHolder) convertView.getTag();
        }

        final DailyCaloriesContent dailyCaloriesContent = content.get(position);
        holder.txtDate.setText(dailyCaloriesContent.getDate());
        holder.txtTotalCalories.setText(dailyCaloriesContent.getDailyTotalCalories());

        return convertView;

    }

}
