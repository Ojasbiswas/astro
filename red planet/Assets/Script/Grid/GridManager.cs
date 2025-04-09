using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;

    [SerializeField] private Tile tile;

    //[SerializeField] private Transform cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++)
            {
                var spawnedTile = Instantiate(tile, new Vector2(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x},{y}";
            }
        
        }

        //cam.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10);
    }
}
