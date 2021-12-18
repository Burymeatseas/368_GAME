using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasFightStarted : MonoBehaviour
{
    public StatueMonster StatueMonster;
   
   void OnTriggerEnter()
   {
	   StatueMonster.HasFightStarted = true;
   }
}
