using UnityEngine;
using UnityEngine.UI;
using System;
 
public class HealthBarHandler : MonoBehaviour
{
    private static Image HealthBarImage;

    private void Start()
    {
        HealthBarImage = GetComponent<Image>();
        Debug.Log(HealthBarImage);
    }

    public static void SetHealthBarValue(float value)
    {
        HealthBarImage.fillAmount = Math.Max(0,value);
        if(HealthBarImage.fillAmount < 0.3f)
        {
            SetHealthBarColor(Color.red);
        }
        else if(HealthBarImage.fillAmount < 0.6f)
        {
            SetHealthBarColor(Color.yellow);
        }
        else
        {
            SetHealthBarColor(Color.green);
        }
    }
 
    public static float GetHealthBarValue()
    {
        return HealthBarImage.fillAmount;
    }
 
    public static void SetHealthBarColor(Color healthColor)
    {
        HealthBarImage.color = healthColor;
    }
 
}