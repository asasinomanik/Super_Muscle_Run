using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStrength : MonoBehaviour
{
    public int strenght = 0;
    public Text strengthText;

    private void Update()
    {
        strengthText.text = "Strenght : " + strenght.ToString();
    }
}
