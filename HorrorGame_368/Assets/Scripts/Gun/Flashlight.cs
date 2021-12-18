using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
	public Animation FlashlightAnim;
	
	public bool IsLight = true;
	
    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.F) && IsLight && !FlashlightAnim.isPlaying)
		{
			FlashlightAnim.Play("FlashlightOff");
			IsLight = false;
		}
		
		else if(Input.GetKey(KeyCode.F) && !IsLight && !FlashlightAnim.isPlaying)
		{
			FlashlightAnim.Play("FlashlightOn");
			IsLight = true;
		}
    }
}
