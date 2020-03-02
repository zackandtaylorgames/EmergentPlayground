using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField]
    private GameObject tile;

    [SerializeField]
    private int WORLD_WIDTH;
    [SerializeField]
    private int WORLD_HEIGHT;

    [SerializeField]
    private float WIDTH_OFFSET;
    [SerializeField]
    private float HEIGHT_OFFSET;

    void Start()
    {
        GenerateWorld();
    }

    void GenerateWorld()
    {
        for(int j = 0; j < WORLD_HEIGHT; j++)
        {
            for(int i = 0; i < WORLD_WIDTH; i++)
            {
                GameObject newTile = Instantiate(tile, new Vector2(i + WIDTH_OFFSET, j + HEIGHT_OFFSET), Quaternion.identity);
                newTile.GetComponent<Tile>().SetValues((float)i, (float)j);
                newTile.transform.SetParent(gameObject.transform);
            }
        }
    }
}
