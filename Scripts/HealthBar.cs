using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static Image Healthbar;
    float value;
    // Start is called before the first frame update
    void Start()
    {
        Healthbar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void SetHealthBarValue(float value) 
    {
        Healthbar.fillAmount = value;
    }

    public static float GetHealthBarValue() 
    {
        return Healthbar.fillAmount;
    }

    public void Health() 
    {
        SetHealthBarValue(GetHealthBarValue() - 0.03f);
    }
}
