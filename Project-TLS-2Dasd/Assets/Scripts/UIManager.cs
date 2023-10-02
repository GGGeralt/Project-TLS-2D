using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //OPTIMALIZATION: give event here that launches each time it is needed
    [SerializeField] Slider healthSlider;


    private void FixedUpdate()
    {
        healthSlider.value = Player.Instance.Health.currentValue;
    }
}
