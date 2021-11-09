using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCeilingLogic : MonoBehaviour
{
	public bool IsActive = true;
	public GameObject FallingCeiling;

	void OnTriggerEnter()
	{
		Destroy (gameObject);
		FallingCeiling.GetComponent<Rigidbody>().useGravity = true;
	}
}
