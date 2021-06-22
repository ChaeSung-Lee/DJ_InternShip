package com.example.smoke_app

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.view.animation.AnimationUtils
import androidx.recyclerview.widget.LinearLayoutManager
import kotlinx.android.synthetic.main.fragment_health.*

// TODO: Rename parameter arguments, choose names that match
// the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [HealthFragment.newInstance] factory method to
 * create an instance of this fragment.
 */
class HealthFragment : Fragment() {
    // TODO: Rename and change types of parameters
    private var param1: String? = null
    private var param2: String? = null



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            param1 = it.getString(ARG_PARAM1)
            param2 = it.getString(ARG_PARAM2)
        }
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_health, container, false)

    }

    companion object {
        /**
         * Use this factory method to create a new instance of
         * this fragment using the provided parameters.
         *
         * @param param1 Parameter 1.
         * @param param2 Parameter 2.
         * @return A new instance of fragment HealthFragment.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            HealthFragment().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }


var health_change_count = 0
    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        btn_health_changeView.setOnClickListener {

            val transRight_In = AnimationUtils.loadAnimation(context, R.anim.anim_translate_right_in)
            val transRight_Out = AnimationUtils.loadAnimation(context, R.anim.anim_translate_right_out)
            val transLeft_In = AnimationUtils.loadAnimation(context,R.anim.anim_translate_left_in)
            val transLeft_Out = AnimationUtils.loadAnimation(context,R.anim.anim_translate_left_out)
            if (health_change_count == 0) {
                health_drink_recycler_view.startAnimation(transLeft_In)
                health_smoke_recycler_view.startAnimation(transLeft_Out)
                health_drink_recycler_view.visibility = View.VISIBLE
                health_smoke_recycler_view.visibility = View.INVISIBLE
                health_change_count = 1
                btn_health_changeView.text = "금주 건강상태"

            } else {
                health_smoke_recycler_view.startAnimation(transRight_In)
                health_drink_recycler_view.startAnimation(transRight_Out)
                health_smoke_recycler_view.visibility = View.VISIBLE
                health_drink_recycler_view.visibility = View.INVISIBLE
                health_change_count = 0
                btn_health_changeView.text = "금연 건강상태"
            }
        }

        val profileList_smoke = arrayListOf(
            HealthProfilesSmoke(1200,"20분 경과","혈압, 맥박, 손발체온 정상"),
            HealthProfilesSmoke(7200,"2시간 경과","혈액 속의 니코틴이 감소"),
            HealthProfilesSmoke(28800,"8시간 경과","혈액 속의 일산화탄소, 산소 농도 정상"),
            HealthProfilesSmoke(86400,"24시간 경과","일산화탄소가 전부 배출되고, 심장마비의 위험이 감소"),
            HealthProfilesSmoke(172800,"48시간 경과","신경말단 기능이 회복되어 후각, 미각 정상"),
            HealthProfilesSmoke(864000,"10일 경과","기관지 기능 회복, 호흡 정상"),
            HealthProfilesSmoke(1728000,"20일 경과","폐 속의 누적된 가래가 묽어지기 시작"),
            HealthProfilesSmoke(2592000,"1개월 경과","피부가 좋아짐, 혈액 순환 개선, 폐 기능 30% 향상, 체력증가, 혈압 정상화"),
            HealthProfilesSmoke(7776000,"3개월 경과","기관지 섬모 기능 회복, 폐기능의 정상화, 남자의 경우 정자의 수 증가"),
            HealthProfilesSmoke(23328000,"9개월 경과","기침, 코막힘, 피로, 호흡곤란 감소, 폐의 섬모가 성장하기 시작"),
            HealthProfilesSmoke(31104000,"1년 경과","관상동맥질환(심장병)에 걸릴 위험이 흡연자의 절반수준"),
            HealthProfilesSmoke(155520000,"5년 경과","폐암으로 사망할 위험이 흡연자의 절반 수준, 자궁경부암과 뇌졸중에 걸릴 위험이 비흡연자와 동일" ),
            HealthProfilesSmoke(311040000,"10년 경과","폐암 사망률이 흡연자의 10% 이하, 구강암, 후두암, 식도암, 방광암, 인두암 등에 걸릴 위험 감소"),
            HealthProfilesSmoke(466560000,"15년 경과","관상동맥질환(심장병)에 걸릴 위험이 비흠연자들과 동일")

        )
        health_smoke_recycler_view.layoutManager = activity?.let{LinearLayoutManager(context, LinearLayoutManager.VERTICAL,false)}
        health_smoke_recycler_view.setHasFixedSize(true)
        health_smoke_recycler_view.adapter = HealthProfileAdapterSmoke(profileList_smoke)

        val profileList_drink = arrayListOf(
            HealthProfilesDrink(21600,"6시간 경과","간이 알코올을 분해, 혈중 알코올농도 정상화"),
            HealthProfilesDrink(86400,"24시간 경과","잔여 독소 제거, 혈당 수치 정상화, 머리가 맑아지고 우울감 감소"),
            HealthProfilesDrink(604800,"1주 경과","술로 인한 이뇨 작용 촉진 및 수분 부족 증상 완화, 수면 주기 정상화"),
            HealthProfilesDrink(1209600,"2주 경과","역류성 식도염 사라짐, 체중 감소"),
            HealthProfilesDrink(1814400,"3주 경과","고혈압의 경우, 혈압이 정상으로 돌아옴"),
            HealthProfilesDrink(2592000,"1개월 경과","피부에 생기와 탄력이 다시 돌아옴"),
            HealthProfilesDrink(5184000,"2개월 경과","간 기능의 향상, 간 주변의 지방이 사라지고 지방간으로부터 회복"),
            HealthProfilesDrink(7776000,"3개월 경과","혈액이 새롭게 교체되어 에너지가 넘치고 건강한 상태"),
            HealthProfilesDrink(31104000,"1년 경과","금주를 유지하여 건강해진 몸 유지")

        )
        health_drink_recycler_view.layoutManager = activity?.let{LinearLayoutManager(context, LinearLayoutManager.VERTICAL,false)}
        health_drink_recycler_view.setHasFixedSize(true)
        health_drink_recycler_view.adapter = HealthProfileAdapterDrink(profileList_drink)


    }
}
