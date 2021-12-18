using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	public HealthManager PlayerHealth;
	public float Damage = 100f;
	
	void OnTriggerEnter()
	{
		PlayerHealth.ApplyDamage(Damage);
	}
	
}
