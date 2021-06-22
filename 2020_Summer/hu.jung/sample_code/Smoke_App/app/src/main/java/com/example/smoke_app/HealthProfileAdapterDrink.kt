package com.example.smoke_app

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.dinuscxj.progressbar.CircleProgressBar
import java.util.*
import kotlin.collections.ArrayList

class HealthProfileAdapterDrink(val profileList: ArrayList<HealthProfilesDrink>) : RecyclerView.Adapter<HealthProfileAdapterDrink.CustomViewHolder>() {


    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): HealthProfileAdapterDrink.CustomViewHolder {
        val view = LayoutInflater.from(parent.context)
            .inflate(R.layout.health_recycler_drink_item, parent, false)
        return CustomViewHolder(view)
    }

    override fun getItemCount(): Int {
        return profileList.size
    }


    override fun onBindViewHolder(holder: HealthProfileAdapterDrink.CustomViewHolder, position: Int) {
        holder.drink_time_text.text = profileList.get(position).drimk_time_text
        holder.drink_text.text = profileList.get(position).drink_text
        var progress_Max = profileList.get(position).progress_max

        var timeValue=0

        val year = 2020
        val month = 8
        val day = 5
        val hour = 12
        val minute =30
        val second = 0

        val yDay = Calendar.getInstance()
        val toDay = Calendar.getInstance()
        yDay.set(year,month-1,day,hour,minute,second)

        var diffSec:Long = (toDay.timeInMillis - yDay.timeInMillis)/1000
        var diffsecond:Long=(diffSec)

        timeValue = diffsecond.toInt()
        holder.progressBar.max = progress_Max
        holder.progressBar.progress = timeValue
        if(timeValue>=progress_Max){
            holder.progressBar.setProgressFormatter{progress, max ->
                val DEFAULT_PATTERN = "완료"
                String.format(DEFAULT_PATTERN,(progress.toFloat()/max.toFloat()*100).toInt())
            }
        }
        else{
            holder.progressBar.setProgressFormatter{progress, max ->
                val DEFALUT_PATTERN = "%d%%"
                String.format(DEFALUT_PATTERN,(progress.toFloat()/max.toFloat()*100).toInt())
            }
        }





    }


    //viewholder inner class
    class CustomViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        val drink_time_text = itemView.findViewById<TextView>(R.id.tv_health_drink_time)
        val drink_text = itemView.findViewById<TextView>(R.id.tv_health_drink) //detail text
        val progressBar = itemView.findViewById<CircleProgressBar>(R.id.pb_drink_circle)
    }
}
