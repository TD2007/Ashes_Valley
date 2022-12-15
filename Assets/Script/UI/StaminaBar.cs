using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

     public void SetStamina(int stamina) {
        slider.value = stamina;
    }

    public void SetMaxStamina(int stamina) {
        slider.maxValue = stamina;
        slider.value = stamina;
    }
}
