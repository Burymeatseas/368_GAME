using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : MonoBehaviour
{
	public GameObject shatteredVersion;
	
	public float MaxHealth =  50;
	
	public float currentHealth;
	
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
    }
	
	public void ApplyDamage(float damage)
	{
		currentHealth -= damage;
		
		if(currentHealth < 0)Break();
	}
	
	void Break()
	{
		Instantiate(shatteredVersion, transform.position, transform.rotation);
		 
		Destroy(gameObject);
	}
}
