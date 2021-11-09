using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
 
	public Animation DoorAnim;
	public bool IsPlayerNear = false;
	public bool IsDoorRedLocked = true;
	public bool IsDoorBlueLocked = true;
	public bool IsDoorGreenLocked = true;
	public bool IsDoorYellowLocked = true;
	
	bool IsDoorOpen = false;
	
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if(IsPlayerNear && Input.GetKey(KeyCode.E) && !IsDoorOpen && !IsDoorRedLocked && !IsDoorBlueLocked && !IsDoorGreenLocked && !IsDoorYellowLocked)
		{
			DoorAnim.Play("Door_Open");
			IsDoorOpen = true;
		}
    }
	
	void OnTriggerEnter()
	{
		IsPlayerNear = true;
	}
	void OnTriggerExit()
	{
		IsPlayerNear = false;
		if(IsDoorOpen && !IsPlayerNear)
		{
			DoorAnim.Play("Door_Close");
			IsDoorOpen = false;
		}
	}
}
