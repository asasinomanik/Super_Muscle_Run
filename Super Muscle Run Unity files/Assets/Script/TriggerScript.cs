using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    SwitchCharacterScript switchCharacterScript;

    private void Start()
    {
        switchCharacterScript = FindObjectOfType<SwitchCharacterScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RedCube")
        {
            print("triggered with red cube");
            switchCharacterScript.Fat();
        }
        if(other.tag == "GreenCube")
        {
            print("triggered with green cube");
            switchCharacterScript.Muscle();
        }
    }
}
