using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StatueMonster : MonoBehaviour
{
	public GameObject Column1;
	public GameObject Column2;
	public GameObject Column3;
	public GameObject Column4;
	public GameObject Player;
	
	public float SpawnTimer = 2f;
	public bool HasFightStarted = false;
	
	public bool GreenButton = false;
	public bool RedButton = false;
	public bool BlueButton = false;
	public bool YellowButton = false;
	
	Vector3 DelayedPlayerPosition;
	float Countdown = 0f;
	
    // Start is called before the first frame update
    void Start()
    {
        Countdown = 0f;
		DelayedPlayerPosition = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		if(GreenButton && RedButton && BlueButton && YellowButton)
		{
			HasFightStarted = false;
			SceneManager.LoadScene(5);
		}
		
		
		if(HasFightStarted)
		{
			Countdown -= Time.deltaTime;
			if(Countdown<= 0f)
			{
				Column1.transform.position = new Vector3(DelayedPlayerPosition.x,transform.position.y + -6f,DelayedPlayerPosition.z);
				DelayedPlayerPosition = Player.transform.position;
				Countdown = SpawnTimer;
			}
		}
		
    }
}
