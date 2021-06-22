package com.example.smoke_app

import androidx.fragment.app.Fragment
import androidx.fragment.app.FragmentManager
import androidx.fragment.app.FragmentPagerAdapter
import androidx.fragment.app.FragmentStatePagerAdapter

//페이지 어댑터 클래스 선언
class MainPagerAdapter(fragmentManager:FragmentManager,val fragmentCount : Int): FragmentStatePagerAdapter(
    fragmentManager){
    //번호 호출 시 각각의 프래그먼트 return
    override fun getItem(position: Int): Fragment {
        when(position){
            0 -> return HomeFragment()
            1 -> return HealthFragment()
            2 -> return DiaryFragment()
            3 -> return CommunityFragment()
            else -> return SettingsFragment()
        }
    }

    override fun getCount() : Int = fragmentCount
}


