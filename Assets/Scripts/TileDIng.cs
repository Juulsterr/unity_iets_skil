using UnityEngine;
using UnityEngine.Tilemaps;

public class TileDIng : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;
    BoundsInt bounds;
    int xmin , ymin;
    int width, height;

    void Start()
    {
        bounds = tilemap.cellBounds;
        Debug.Log(bounds);

        xmin = bounds.xMin;
        ymin = bounds.yMin;
        width = bounds.size.x;
        height = bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Input.mousePosition;
        Vector3 worldpos = Camera.main.ScreenToWorldPoint(mousepos);

        Vector3Int cellpos = tilemap.WorldToCell(worldpos);

        for(int i=0; i<width; i++)
        {
            for(int j=0; j<height; j++)
            {
                Vector3Int pos = new Vector3Int(xmin + i, ymin + j, 0);
               Debug.Log(pos);
            }
        }

        tilemap.SetTileFlags(cellpos, TileFlags.None);
        tilemap.SetColor(cellpos, Color.red);
    }
}
