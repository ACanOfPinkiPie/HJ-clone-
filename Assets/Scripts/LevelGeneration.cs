using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class LevelGeneration : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlatformPrefab;
    public int MaxPlatforms;
    public int MinPlatforms;
    public float DistanceBetweenPlatforms;
    public Transform FinishPlatform;
    public Transform CylinderRoot;
    public float ExtraCylinderScale = 1f;
    public Game Game;


    private void Awake()
    {
        int levelIndex = Game.LevelIndex;
        Random random = new Random(levelIndex);

        int platformsCount = RandomRange(random, MinPlatforms, MaxPlatforms + 1);
        for(int i = 0; i < platformsCount; i++)
        {
            int prefabIndex = RandomRange(random, 0, PlatformPrefabs.Length);
            GameObject platformPlafab = i == 0 ? FirstPlatformPrefab : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(platformPlafab, transform);
            platform.transform.localPosition = CalculatePlatformPosition(i);
            if(i > 0)
            {
                platform.transform.localRotation = Quaternion.Euler(0, RandomRange (random, 0, 360f), 0);
            }
           
        }

        FinishPlatform.localPosition = CalculatePlatformPosition(platformsCount);
        CylinderRoot.localScale = new Vector3 (1, platformsCount * DistanceBetweenPlatforms + ExtraCylinderScale, 1);
    }

    private int RandomRange(Random random, int min, int maxExclisive)
    {
        int number = random.Next();
        int lenght = maxExclisive - min;
        number %= lenght;
        return min + number;
    }
    private float RandomRange(Random random, float min, float max)
    {
        float t = (float)random.NextDouble();
        return Mathf.Lerp(min, max, t);
    }
    private Vector3 CalculatePlatformPosition(int platformIndex)
    {
        return new Vector3(0, -DistanceBetweenPlatforms * platformIndex, 0);
    }
}
