using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
	public Animation MedKitAnim;
	public HealthManager PlayerHealth;
	public float Healing = 50f;
    // Start is called before the first frame update
    void Start()
    {
        MedKitAnim.Play("MedkitIdle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter()
	{
		PlayerHealth.ApplyDamage(-1 * Healing);
		Destroy (gameObject);
	}
}
