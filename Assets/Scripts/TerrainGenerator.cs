using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int worldSize = 10;
    public GameObject tile;
    public int tileSize = 5;
    public int maxHeight = 10;
    public GameObject[,] terrain;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        terrain = new GameObject[worldSize, worldSize];
        for (int i = 0; i < worldSize; i++)
        {
            for (int j = 0; j < worldSize; j++)
            {
                float height = Random.Range(0, maxHeight);
                terrain[i,j] = Instantiate(tile, new Vector3(i * tileSize, height, j * tileSize), Quaternion.identity);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
