using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : MonoBehaviour
{
	public GameObject shatteredVersion;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shatteredVersion, transform.position, transform.rotation);
		Destroy(gameObject);
    }

   
}
