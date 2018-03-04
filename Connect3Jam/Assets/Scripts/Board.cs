using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //make grid
    public int width;
    public int height;
    public GameObject tilePrefab;
    private BackgroundTile[,] allTiles;

    void Start ()
    {
        allTiles = new BackgroundTile[width, height];

        Setup();
    }

    private void Setup ()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 tempPos = new Vector2(x, y);
                GameObject go = Instantiate(tilePrefab, tempPos, Quaternion.identity);
                go.transform.parent = transform;
                go.name = "( " + x + ", " + y + " )";
            }
        }
    }
}
