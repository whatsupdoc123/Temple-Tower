using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GammaSlider : MonoBehaviour
{
    public float rgbValue = 0.5f;

    public void ChangeLight()
    {
        rgbValue = GUI.HorizontalSlider(new Rect(Screen.width / 2 - 50, 90, 100, 30), rgbValue, 0f, 1.0f);
        RenderSettings.ambientLight = new Color(rgbValue, rgbValue, rgbValue, 1);
    }

}
