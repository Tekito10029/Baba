using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapControl : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile tile, tile2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SetTile());
    }

    void Update()
    {

    }
    IEnumerator SetTile()
    {
        int i = -12;
        int random;
        while (i < 0)
        {
            tilemap.SetTile(new Vector3Int(i, -5, 0), tile);
            i++;
        }
        yield return null;
        while (true)
        {

            random = Random.Range(0, 10);
            if (random < 5)
            {
                tilemap.SetTile(new Vector3Int(i, 0, 0), tile2);
                tilemap.SetTile(new Vector3Int(i + 1, 0, 0), tile2);
                tilemap.SetTile(new Vector3Int(i + 2, 0, 0), tile2);
            }
            if (random > 3)
            {
                tilemap.SetTile(new Vector3Int(i, -5, 0), tile);
                tilemap.SetTile(new Vector3Int(i + 1, -5, 0), tile);
                tilemap.SetTile(new Vector3Int(i + 2, -5, 0), tile);
            }


            i += 3;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
