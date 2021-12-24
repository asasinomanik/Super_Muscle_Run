using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject avatar1, avatar2, avatar3, avatar4, avatar5;

	// variable contains which avatar is on and active
	int whichAvatarIsOn = 3;

	// Use this for initialization
	void Start () {

		// anable first avatar and disable another one
		avatar1.gameObject.SetActive (false);
		avatar2.gameObject.SetActive (false);
		avatar3.gameObject.SetActive(true);
		avatar4.gameObject.SetActive(false);
		avatar5.gameObject.SetActive(false);
	}

	public void Fat()
    {
		if (whichAvatarIsOn == 2)
		{
			whichAvatarIsOn = 1;
			avatar1.gameObject.SetActive(true);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 3)
        {
			whichAvatarIsOn = 2;
			avatar2.gameObject.SetActive(true);
			avatar1.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 4)
		{
			whichAvatarIsOn = 2;
			avatar2.gameObject.SetActive(true);
			avatar1.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 5)
		{
			whichAvatarIsOn = 2;
			avatar2.gameObject.SetActive(true);
			avatar1.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
		}

	}
	public void Muscle()
	{
		if (whichAvatarIsOn == 1)
		{
			whichAvatarIsOn = 2;
			avatar2.gameObject.SetActive(true);
			avatar1.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 2)
		{
			whichAvatarIsOn = 3;
			avatar3.gameObject.SetActive(true);
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 3)
		{
			whichAvatarIsOn = 4;
			avatar4.gameObject.SetActive(true);
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 4)
		{
			whichAvatarIsOn = 5;
			avatar5.gameObject.SetActive(true);
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
		}

	}
}
