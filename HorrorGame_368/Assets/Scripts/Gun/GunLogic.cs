using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunLogic : MonoBehaviour
{
	public float damage = 7f;
	
	public float range = 100f;
	
	public int clipsize = 10;
	
	public int MaxAmmoHeld = 100;

	public float firerate = 1f;
	
	public float weaponSpread = 1f;
	
	public float ImpactForce = 100f;
	
	public Camera fpsCam;
	
	public Text AmmoCountUI;
	
	float lengthSinceLastFire = 0f;
   
    int currentAmmo;
	
	int currentAmmoHeld;
	
	public AudioSource Gunshot;

	void Start()
   {
       currentAmmo = clipsize;
       currentAmmoHeld = MaxAmmoHeld;
       AmmoCountUI.text = (currentAmmo.ToString()) + "/" + (currentAmmoHeld.ToString());
   }
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && lengthSinceLastFire>(1/firerate)  && currentAmmo > 0)
        {
          Fire();

          lengthSinceLastFire = 0f;
          currentAmmo -= 1;
          if(currentAmmo == 0 && currentAmmoHeld > clipsize)
		  {
              currentAmmoHeld -= clipsize;
              currentAmmo = clipsize;
          }
          else if(currentAmmo == 0 && currentAmmoHeld < clipsize)
          {
              currentAmmo = currentAmmoHeld;
              currentAmmoHeld = 0;
          }
		  
		  AmmoCountUI.text = (currentAmmo.ToString()) + "/" + (currentAmmoHeld.ToString());
		}
    }
	
	void Fire()
	{
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hit, range))
		{
			//Debug.Log(hit.transform.name);
			Shatter shatter = hit.transform.GetComponent<Shatter>();
			//Only fire if target has script
			if(shatter !=null)
			{
				shatter.ApplyDamage(damage);
				Debug.Log("hit");
			}
			if(hit.rigidbody != null)
			{
				hit.rigidbody.AddForce(-hit.normal * ImpactForce );
			}
		}
	}
}
