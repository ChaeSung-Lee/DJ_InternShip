package com.example.smoke_app

import android.content.Context
import android.graphics.Color
import android.graphics.Typeface
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.TextView
import kotlinx.android.synthetic.main.activity_splash.view.*
import java.util.*
import kotlin.collections.ArrayList
import kotlin.collections.HashSet

class DiaryCalendarAdapter(context: Context, days:ArrayList<Date>, eventDays:HashSet<Date>,inputMonth:Int):
    ArrayAdapter<Date>(context,R.layout.diary_calendar_layout,days){

    //for view inflation
    private val inflater:LayoutInflater= LayoutInflater.from(context)
    private val inputMonth = inputMonth-1

    override fun getView(position: Int, view: View?, parent: ViewGroup): View {
        var diary_view = view
        val calendar = Calendar.getInstance()
        val date = getItem(position)

        calendar.time=date
        val day = calendar.get(Calendar.DATE)
        val month=calendar.get(Calendar.MONTH)
        val year = calendar.get(Calendar.YEAR)

        //오늘에 해당하는 캘린더를 가져옴
        val today = Date()
        val calendarToday = Calendar.getInstance()
        calendarToday.time = today

        //날짜 디자인으로 먼저 만들어둔 diary_calendar_day_layout을 inflate
        if(diary_view == null){
            diary_view = inflater.inflate(R.layout.diary_calendar_day_layout,parent,false)
        }

        //기호에 따라 뷰의 생김새와 일자의 디자인 변경
        (diary_view as TextView).setTypeface(null,Typeface.NORMAL)
        diary_view.setTextColor(Color.parseColor("#222222"))



            //inputMonth는 ViewPager의 해당 페이지에 출력하는 Month를 표시
        if(month != inputMonth || year != calendarToday.get(Calendar.YEAR)){
            //diary_view.visibility=View.INVISIBLE //해당월이 아닌 경우 GridView에 표시되지 않음
            diary_view.setTextColor(Color.parseColor("#bbbbbb"))
        }else {
            var light =diary_view




        }


        if(month == calendarToday.get(Calendar.MONTH) && year == calendarToday.get(Calendar.YEAR) && day==calendarToday.get(Calendar.DATE)){
            diary_view.setTextColor(Color.parseColor("#ff00ff"))
            //오늘의 날짜에 디자인 설정
        }

        // 날짜를 텍스트뷰에 설정
        diary_view.text = calendar.get(Calendar.DATE).toString()

        return diary_view
    }
}
