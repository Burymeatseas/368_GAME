using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitJailbarsLogic : MonoBehaviour
{
   public GameObject[] enemies;
   public Animation JailbarsAnim;

    // Update is called once per frame
    void Update()
    {
		enemies = GameObject.FindGameObjectsWithTag("Opponent");
		if( enemies.Length == 0)
		{
			JailbarsAnim.Play("JailbarsOpen");
		}
    }
}
