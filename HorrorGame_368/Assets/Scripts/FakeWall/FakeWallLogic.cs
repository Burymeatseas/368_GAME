using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeWallLogic : MonoBehaviour
{
	public Animation FakeWallAnim;
	public bool IsPlayerNear = false;
	public bool IsWall = true;
	
   
    // Update is called once per frame
    void Update()
    {
        if(IsPlayerNear && Input.GetKey(KeyCode.E) && IsWall)
		{
			FakeWallAnim.Play("FakeWallFall");
			IsWall = false;
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
