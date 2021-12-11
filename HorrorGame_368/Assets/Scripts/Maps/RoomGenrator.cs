using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenrator : MonoBehaviour
{
	//Make variables for each room
	public GameObject SmallDungeon1;
	
	public GameObject SmallDungeon2;
	
	public GameObject SmallDungeon3;
	
	public GameObject LargeDungeon1;
	
	public GameObject LargeDungeon2;
	
	public GameObject Door1;
	
	public GameObject Door2;
	
	public int NumberOfActiveDoors;
	
	int Door1Seed;
	
	int Door2Seed;
	
	public GameObject Door1ConnectedRoom;
	
	public GameObject Door2ConnectedRoom;
	
	void OnTriggerEnter()
	{
		Door1Seed = Random.Range(0,4);
		switch (Door1Seed)
		{
			case 0:
				Instantiate(SmallDungeon1, Door1.transform.position);
				break;
			case 1:
				Instantiate(SmallDungeon2, Door1.transform.position);
				break;
			case 2:
				Instantiate(SmallDungeon3, Door1.transform.position);
				break;
			case 3:
				Instantiate(LargeDungeon1, Door1.transform.position);
				break;
			case 4:
				Instantiate(LargeDungeon1, Door1.transform.position);
				break;
				
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
