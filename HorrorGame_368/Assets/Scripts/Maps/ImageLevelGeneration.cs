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
		int worldY = levelImage.height;
		
		Vector3[] spawnPositions =
			new Vector3[pixels.Length];
		
		Vector3 startingSpawnPosition =
			new Vector3(-Mathf.Round(worldX / 2),
						0,
						-Mathf.Round(worldY / 2));
		
		Vector3 currentSpawnPosition =
			startingSpawnPosition;
			
			
    }

  
}
