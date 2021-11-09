using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControl : MonoBehaviour
{
	public Animation ElevatorAnim;
	public bool IsPlayerNear = false;
	
	public bool IsElevatorUp = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsPlayerNear && Input.GetKey(KeyCode.E) && !IsElevatorUp && !ElevatorAnim.isPlaying)
		{
			ElevatorAnim.Play("ElevatorUp");
			IsElevatorUp = true;
		}
		
		else if(IsPlayerNear && Input.GetKey(KeyCode.E) && IsElevatorUp && !ElevatorAnim.isPlaying)
		{
			ElevatorAnim.Play("ElevatorDown");
			IsElevatorUp = false;
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