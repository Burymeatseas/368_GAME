using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   bool IsPlayerNear = false;
	public StatueMonster StatueMonster;
	public Animation ButtonAnim;
	
	public bool IsGreenButton = false;
	public bool IsRedButton = false;
	public bool IsBlueButton = false;
	public bool IsYellowButton = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(IsPlayerNear && Input.GetKey(KeyCode.E))
	   {
		   ButtonAnim.Play("ButtonPress");
		 if(IsGreenButton)
		 {
			 StatueMonster.GreenButton = true;
		 }
		 if(IsRedButton)
		 {
			 StatueMonster.RedButton = true;
		 }
		 if(IsGreenButton)
		 {
			 StatueMonster.BlueButton = true;
		 }
		 if(IsGreenButton)
		 {
			 StatueMonster.YellowButton = true;
		 }
	   }
    }
	void OnTriggerEnter()
	{
		IsPlayerNear = true;
	}
	void OnTriggerExit()
	{
		IsPlayerNear = false;
	}
}
