using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingAura : MonoBehaviour
{
   public HealthManager PlayerHealth;
	public float Damage = 20f;
	
	void OnTriggerStay()
	{
		PlayerHealth.ApplyDamage(Damage * Time.deltaTime);
	}
	
}
