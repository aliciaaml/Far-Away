using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    [SerializeField] private Transform EmptyTile;
    [SerializeField] private TileSmooth[] tiles;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        shuffle();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit)
            {
                if (Vector2.Distance(EmptyTile.position, hit.transform.position) < 2.5)
                {
                    Vector2 auxEmptyPos = EmptyTile.position;
                    TileSmooth tile = hit.transform.GetComponent<TileSmooth>();
                    EmptyTile.position = tile.targetPos;
                    tile.targetPos = auxEmptyPos;
                }
            }
        }
    }

    public void shuffle()
    {
        for (int i = 0; i < 6; i++)
        {
            var lastPos = tiles[i].targetPos;
            int randomI = Random.Range(0, 6);
            tiles[i].targetPos = tiles[randomI].targetPos;
            tiles[randomI].targetPos = lastPos;
        }
    }
}
