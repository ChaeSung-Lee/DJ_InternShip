package com.example.smoke_app

import android.content.Context
import android.util.AttributeSet
import android.view.LayoutInflater
import android.widget.GridView
import android.widget.LinearLayout
import kotlinx.android.synthetic.main.fragment_diary.view.*
import java.util.*
import kotlin.collections.ArrayList
import kotlin.collections.HashSet

open class DiarycalendarView:LinearLayout {
    lateinit var header:LinearLayout
    lateinit var gridView:GridView

    constructor(context: Context):this(context,null)

    constructor(context: Context,attrs: AttributeSet?):this(context,attrs,0){
        initControl(context,attrs!!)
    }

    constructor(context:Context,attrs:AttributeSet?,defStyleAttr:Int):super(context,attrs,defStyleAttr)

    private fun assignUiElement(){
        //layout is inflated, assign local variables to components
        header = findViewById(R.id.diary_calendar_header)
        gridView = findViewById(R.id.diary_calendar_grid)

    }
    fun updateCalendar(events:HashSet<Date>,inputCalendar:Calendar){
        val cells = ArrayList<Date>()

        inputCalendar.set(Calendar.DAY_OF_MONTH,1)

        //빼주는 값의 경우 한 주의 시작요일에 따라 다르게 설정해주면 됨
        //-1 = 일요일 -2 = 토요일 ...
        val monthBeginningCell = inputCalendar.get(Calendar.DAY_OF_WEEK)-1

        inputCalendar.add(Calendar.DAY_OF_MONTH,-monthBeginningCell)

        //grid에 넣을 cell들의 setup
        while (cells.size < 42){
            cells.add(inputCalendar.time)
            inputCalendar.add(Calendar.DAY_OF_MONTH,1)
        }

        //grid update
        gridView.adapter = DiaryCalendarAdapter(context,cells,events,inputCalendar.get(Calendar.MONTH))
    }

    private fun initControl(context: Context,attrs: AttributeSet){
        val inflater = context.getSystemService(Context.LAYOUT_INFLATER_SERVICE) as LayoutInflater
        inflater.inflate(R.layout.diary_calendar_layout,this)
        assignUiElement()
    }

}