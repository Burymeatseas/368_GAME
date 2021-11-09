using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
	public Transform HealthHome;
	public float Health = 100f;
   
	public void ApplyDamage(float DamageAmount)
	{
		Health -= DamageAmount;
		HealthHome.transform.localScale = new Vector3(Health, 1f, .01f);
		if(Health<=0)
		{
			SceneManager.LoadScene("Midterm");
		}
		if(Health>100f)
		{
			Health = 100f;
			HealthHome.transform.localScale = new Vector3(Health, 1f, .01f);
		}
	}
}
