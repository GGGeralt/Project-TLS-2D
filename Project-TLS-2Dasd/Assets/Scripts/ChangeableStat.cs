using System;
using UnityEngine;

[Serializable]
public class ChangeableStat
{
    public Stat maximunValue;
    public int currentValue;
    public void Increase(int value)
    {
        currentValue = Mathf.Clamp(currentValue + value, 0, maximunValue.Value);
        Debug.Log("Increased");
    }

    public void Decrease(int value)
    {
        currentValue = Mathf.Clamp(currentValue - value, 0, maximunValue.Value);
        Debug.Log("Decreased");
    }
}
