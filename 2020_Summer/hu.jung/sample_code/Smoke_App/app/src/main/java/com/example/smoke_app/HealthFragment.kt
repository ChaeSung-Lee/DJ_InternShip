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
                btn_health_changeView.text = "?????? ????????????"

            } else {
                health_smoke_recycler_view.startAnimation(transRight_In)
                health_drink_recycler_view.startAnimation(transRight_Out)
                health_smoke_recycler_view.visibility = View.VISIBLE
                health_drink_recycler_view.visibility = View.INVISIBLE
                health_change_count = 0
                btn_health_changeView.text = "?????? ????????????"
            }
        }

        val profileList_smoke = arrayListOf(
            HealthProfilesSmoke(1200,"20??? ??????","??????, ??????, ???????????? ??????"),
            HealthProfilesSmoke(7200,"2?????? ??????","?????? ?????? ???????????? ??????"),
            HealthProfilesSmoke(28800,"8?????? ??????","?????? ?????? ???????????????, ?????? ?????? ??????"),
            HealthProfilesSmoke(86400,"24?????? ??????","?????????????????? ?????? ????????????, ??????????????? ????????? ??????"),
            HealthProfilesSmoke(172800,"48?????? ??????","???????????? ????????? ???????????? ??????, ?????? ??????"),
            HealthProfilesSmoke(864000,"10??? ??????","????????? ?????? ??????, ?????? ??????"),
            HealthProfilesSmoke(1728000,"20??? ??????","??? ?????? ????????? ????????? ???????????? ??????"),
            HealthProfilesSmoke(2592000,"1?????? ??????","????????? ?????????, ?????? ?????? ??????, ??? ?????? 30% ??????, ????????????, ?????? ?????????"),
            HealthProfilesSmoke(7776000,"3?????? ??????","????????? ?????? ?????? ??????, ???????????? ?????????, ????????? ?????? ????????? ??? ??????"),
            HealthProfilesSmoke(23328000,"9?????? ??????","??????, ?????????, ??????, ???????????? ??????, ?????? ????????? ???????????? ??????"),
            HealthProfilesSmoke(31104000,"1??? ??????","??????????????????(?????????)??? ?????? ????????? ???????????? ????????????"),
            HealthProfilesSmoke(155520000,"5??? ??????","???????????? ????????? ????????? ???????????? ?????? ??????, ?????????????????? ???????????? ?????? ????????? ??????????????? ??????" ),
            HealthProfilesSmoke(311040000,"10??? ??????","?????? ???????????? ???????????? 10% ??????, ?????????, ?????????, ?????????, ?????????, ????????? ?????? ?????? ?????? ??????"),
            HealthProfilesSmoke(466560000,"15??? ??????","??????????????????(?????????)??? ?????? ????????? ?????????????????? ??????")

        )
        health_smoke_recycler_view.layoutManager = activity?.let{LinearLayoutManager(context, LinearLayoutManager.VERTICAL,false)}
        health_smoke_recycler_view.setHasFixedSize(true)
        health_smoke_recycler_view.adapter = HealthProfileAdapterSmoke(profileList_smoke)

        val profileList_drink = arrayListOf(
            HealthProfilesDrink(21600,"6?????? ??????","?????? ???????????? ??????, ?????? ??????????????? ?????????"),
            HealthProfilesDrink(86400,"24?????? ??????","?????? ?????? ??????, ?????? ?????? ?????????, ????????? ???????????? ????????? ??????"),
            HealthProfilesDrink(604800,"1??? ??????","?????? ?????? ?????? ?????? ?????? ??? ?????? ?????? ?????? ??????, ?????? ?????? ?????????"),
            HealthProfilesDrink(1209600,"2??? ??????","????????? ????????? ?????????, ?????? ??????"),
            HealthProfilesDrink(1814400,"3??? ??????","???????????? ??????, ????????? ???????????? ?????????"),
            HealthProfilesDrink(2592000,"1?????? ??????","????????? ????????? ????????? ?????? ?????????"),
            HealthProfilesDrink(5184000,"2?????? ??????","??? ????????? ??????, ??? ????????? ????????? ???????????? ????????????????????? ??????"),
            HealthProfilesDrink(7776000,"3?????? ??????","????????? ????????? ???????????? ???????????? ????????? ????????? ??????"),
            HealthProfilesDrink(31104000,"1??? ??????","????????? ???????????? ???????????? ??? ??????")

        )
        health_drink_recycler_view.layoutManager = activity?.let{LinearLayoutManager(context, LinearLayoutManager.VERTICAL,false)}
        health_drink_recycler_view.setHasFixedSize(true)
        health_drink_recycler_view.adapter = HealthProfileAdapterDrink(profileList_drink)


    }
}
