using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject platformPrefab;


    private int numOfPlatforms = 300;
    public float startingPos;
    void Start()
    {
        InstantiatePlatforms();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiatePlatforms()
    {
        float x;
        float y= startingPos;
        for (int i = 0; i < numOfPlatforms; i++)
        {
            x = Random.Range(-2.4f, 2.4f);
            y += Random.Range(2f, 7f);
            Vector3 position = new Vector3(x, y, 0f);
            Instantiate(platformPrefab, position, Quaternion.identity);
        }
    }
}
