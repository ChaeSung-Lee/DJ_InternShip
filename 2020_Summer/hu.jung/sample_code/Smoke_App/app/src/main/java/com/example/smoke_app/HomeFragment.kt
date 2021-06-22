package com.example.smoke_app

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.view.animation.AnimationUtils
import kotlinx.android.synthetic.main.fragment_home.*

// TODO: Rename parameter arguments, choose names that match
// the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [HomeFragment.newInstance] factory method to
 * create an instance of this fragment.
 */
class HomeFragment : Fragment() {
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
        return inflater.inflate(R.layout.fragment_home, container, false)
    }


    companion object {
        /**
         * Use this factory method to create a new instance of
         * this fragment using the provided parameters.
         *
         * @param param1 Parameter 1.
         * @param param2 Parameter 2.
         * @return A new instance of fragment HomeFragment.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            HomeFragment().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }
var ttb_count = 0 //home_no_time_count
    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        btn_test.setOnClickListener {
            val transBottom_In = AnimationUtils.loadAnimation(context, R.anim.anim_translate_bottom_in)
            val transBottom_Out = AnimationUtils.loadAnimation(context, R.anim.anim_translate_bottom_out)
            if (ttb_count == 0) {
                layout_drink.startAnimation(transBottom_In)
                layout_smoke.startAnimation(transBottom_Out)
                layout_drink.visibility = View.VISIBLE
                layout_smoke.visibility = View.INVISIBLE
                ttb_count = 1

            } else {
                layout_drink.startAnimation(transBottom_Out)
                layout_smoke.startAnimation(transBottom_In)
                layout_drink.visibility = View.INVISIBLE
                layout_smoke.visibility = View.VISIBLE
                ttb_count = 0
            }


        }



    }
}


