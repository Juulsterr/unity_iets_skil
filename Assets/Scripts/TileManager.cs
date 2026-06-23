using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManager : MonoBehaviour
{

    [SerializeField] Tilemap myTilemap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Input.mousePosition;
                Debug.Log("Mouse Position: " + mousePos);

                Vector3 WorldPos = Camera.main.ScreenToWorldPoint(mousePos);
                WorldPos.z = 0;
                Debug.Log("World Position: " + WorldPos);
            }
    }
}
