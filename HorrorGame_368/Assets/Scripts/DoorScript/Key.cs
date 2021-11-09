using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	
	public bool IsGreenKey = false;
	public bool IsRedKey = false;
	public bool IsBlueKey = false;
	public bool IsYellowKey = false;
	
	public DoorControl LockedDoor;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter()
	{
		if(IsGreenKey)
		 {
			 LockedDoor.IsDoorGreenLocked = false;
		 }
		 if(IsRedKey)
		 {
			 LockedDoor.IsDoorRedLocked = false;
		 }
		 if(IsBlueKey)
		 {
			 LockedDoor.IsDoorBlueLocked = false;
		 }
		 if(IsYellowKey)
		 {
			 LockedDoor.IsDoorYellowLocked = false;
		 }
		Destroy(gameObject);
	}
}
