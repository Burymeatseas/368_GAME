using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageLevelGeneration : MonoBehaviour
{
	public Texture2D levelImage;
	
	public GameObject groundPrefab;
	public GameObject wallPrefab;
	
    void Start()
    {
        Color[] pixels = levelImage.GetPixels();
		
		int worldX = levelImage.width;
		int worldZ = levelImage.height;
		
		Vector3[] spawnPositions =
			new Vector3[pixels.Length];
		
		Vector3 startingSpawnPosition =
			new Vector3(-Mathf.Round(worldX / 2),
						0,
						-Mathf.Round(worldZ / 2));
		
		Vector3 currentSpawnPosition =
			startingSpawnPosition;
			
			
			
			
		int counter = 0;
		for (int z = 0; z < worldZ; z++)
		{
			for (int x = 0; z < worldX; x++)
			{
				spawnPositions[counter] =
					currentSpawnPosition;
				counter++;
				currentSpawnPosition.x++;
			}
			
			currentSpawnPosition.x =
				startingSpawnPosition.x;
			currentSpawnPosition.z++;
		}
		counter = 0;
		
		
		
		foreach (Vector3 pos in spawnPositions)
		{
			Color c = pixels[counter];
			
			if (c.Equals(Color.black))
			{
				var newGround =
					Instantiate(groundPrefab);
					
				newGround.transform.position =
				pos;
			}
			
			else if (c.Equals(Color.white))
			{
				var newWall =
					Instantiate(wallPrefab);
					
				newWall.transform.position =
				pos;
			}
			counter++;
		}
    }

  
}
