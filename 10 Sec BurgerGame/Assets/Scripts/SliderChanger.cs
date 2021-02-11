using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChanger : MonoBehaviour
{
    private float timeRemaining;
    public Slider slider;
    public float TimerMax = 10f;



    private void Start()
    {
        timeRemaining = TimerMax;
    }


    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateSliderValue();

       
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
        }
        else if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
       

    }

    public float CalculateSliderValue()
    {
        return (timeRemaining / TimerMax);
    }


}
