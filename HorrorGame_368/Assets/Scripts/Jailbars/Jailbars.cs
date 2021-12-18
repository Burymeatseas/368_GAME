using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jailbars : MonoBehaviour
{
	public bool IsPlayerIn = false;
	public Animation JailbarsAnim;

    // Update is called once per frame
    void Update()
    {
        if( IsPlayerIn)
		{
			JailbarsAnim.Play("JailbarsClose");
		}
    }
	
	void OnTriggerEnter()
	{
		IsPlayerIn = true;
	}
}
