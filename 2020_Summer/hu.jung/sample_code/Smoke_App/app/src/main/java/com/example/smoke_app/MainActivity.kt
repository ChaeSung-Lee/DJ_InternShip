package com.example.smoke_app

import android.content.Context
import android.database.sqlite.SQLiteDatabase
import android.database.sqlite.SQLiteOpenHelper
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.widget.*
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import com.google.firebase.database.*
import kotlinx.android.synthetic.main.activity_main.*
import kotlinx.android.synthetic.main.fragment_home.*
import kotlinx.android.synthetic.main.init_dialog.*
import kotlinx.android.synthetic.main.init_dialog.view.*
import java.text.DateFormat
import java.text.SimpleDateFormat
import java.util.*


class MainActivity : AppCompatActivity() {
    //데이터베이스 레퍼런스 호출
    lateinit var databaseReference : DatabaseReference

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
            setContentView(R.layout.activity_main)

            Dialog() //다이얼로그 함수 실행
            configureBottomNavigation()   // 네비게이션 함수 실행


    }

    //BottomNavigation 함수 선언
    private fun configureBottomNavigation(){
        // vp_main 어댑터 MainPagerAdapter를 기반으로 선언
        vp_main.adapter = MainPagerAdapter(supportFragmentManager,5)
        Bottom_menu.setupWithViewPager(vp_main)

        val bottomNaviLayout:View = this.layoutInflater.inflate(R.layout.bottom_navigation_tab,null,false)

        Bottom_menu.getTabAt(0)!!.customView = bottomNaviLayout.findViewById(R.id.bottom_home_tab) as RelativeLayout
        Bottom_menu.getTabAt(1)!!.customView = bottomNaviLayout.findViewById(R.id.bottom_health_tab) as RelativeLayout
        Bottom_menu.getTabAt(2)!!.customView = bottomNaviLayout.findViewById(R.id.bottom_diary_tab) as RelativeLayout
        Bottom_menu.getTabAt(3)!!.customView = bottomNaviLayout.findViewById(R.id.bottom_community_tab) as RelativeLayout
        Bottom_menu.getTabAt(4)!!.customView = bottomNaviLayout.findViewById(R.id.bottom_settings_tab) as RelativeLayout
    }

    //Dialog 함수 선언
    private fun Dialog(){
        val mDialogView = LayoutInflater.from(this).inflate(R.layout.init_dialog,null)
        //얼럿다이어그램 빌더
        val mBuilder = AlertDialog.Builder(this)
            .setView(mDialogView)


        //show diagram
        val mAlertDialog = mBuilder.show()
        mAlertDialog.setCancelable(false) // 다이얼로그 이외의 창을 선택해도 안꺼짐
        //데이터베이스에 중복된 데이터가 있는지 확인
        var checkRegister : ValueEventListener = object:ValueEventListener{
            //에러시
            override fun onCancelled(databaseerror: DatabaseError) {

            }
            //수행시
            override fun onDataChange(datasnapshot: DataSnapshot) {
                var child : Iterator<DataSnapshot> = datasnapshot.children.iterator() //(=firebase data list)
                while (child.hasNext()){
                    if(mDialogView.et_nickname.text.toString() == child.next().key){
                        Toast.makeText(applicationContext,"이미 사용중인 닉네임입니다.",Toast.LENGTH_SHORT).show()
                        databaseReference.removeEventListener(this)
                        return

                    }
                }

                //중복된 아이디가 없다면 새로운 데이터 추가
                makeNewId()
            }

            fun makeNewId(){
                var date:Date = Date(System.currentTimeMillis())
                var df: DateFormat = SimpleDateFormat("yyyy-MM-dd HH:mm:ss")
                var setdate = df.format(date).toString()
                databaseReference.child(mDialogView.et_nickname.text.toString()).child("가입일").setValue(setdate)
                Toast.makeText(applicationContext,"Success",Toast.LENGTH_SHORT).show()
                mAlertDialog.dismiss()

            }

        }
        //ok button click of custom layout
        mDialogView.btn_dialogOK.setOnClickListener {
            if (mDialogView.et_nickname.text.toString().isEmpty()){
                Toast.makeText(applicationContext,"닉네임을 입력하세요.",Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            databaseReference = FirebaseDatabase.getInstance().getReference("Nickname")
            //dismiss dialog

            //get text from EditText of custom layout
            val nickname = mDialogView.et_nickname.text.toString()
            val drink_count = mDialogView.tv_dialogDrinkcount.text.toString()
            val smoke_count = mDialogView.tv_dialogSmokeCount.text.toString()
            //텍스트뷰에 다이얼로그 값 입력
            tv_home_nickname.setText("Name : " + nickname)
            textView4.setText("drink : " + drink_count)
            databaseReference.addListenerForSingleValueEvent(checkRegister)



        }


        mDialogView.btn_drinkminus.setOnClickListener {


            var drinkcountMinus = Integer.parseInt(mDialogView.tv_dialogDrinkcount.text.toString())
            //drinkcount값이 0보다 작을 시
            if(drinkcountMinus == 0){
                Toast.makeText(this,"이미 최소 음주량입니다.",Toast.LENGTH_SHORT).show()
            }
            else
            drinkcountMinus -=1
            mDialogView.tv_dialogDrinkcount.setText(drinkcountMinus.toString())


        }
        mDialogView.btn_drinkplus.setOnClickListener {
            var drinkcountPlus = Integer.parseInt(mDialogView.tv_dialogDrinkcount.text.toString())
            drinkcountPlus +=1
            mDialogView.tv_dialogDrinkcount.setText(drinkcountPlus.toString())
        }
        mDialogView.btn_smokeminus.setOnClickListener {
            var smokecountMinus = Integer.parseInt(mDialogView.tv_dialogSmokeCount.text.toString())

            //smokecount값이 0보다 작을 시
            if(smokecountMinus == 0){
                Toast.makeText(this,"이미 최소 흡연량입니다.",Toast.LENGTH_SHORT).show()
            }
            else
                smokecountMinus -= 1
            mDialogView.tv_dialogSmokeCount.setText(smokecountMinus.toString())
        }
        mDialogView.btn_smokeplus.setOnClickListener {
            var smokecountPlus = Integer.parseInt(mDialogView.tv_dialogSmokeCount.text.toString())
            smokecountPlus += 1
            mDialogView.tv_dialogSmokeCount.setText(smokecountPlus.toString())
        }
    }




}




