using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    [SerializeField] private Transform EmptyTile;
    [SerializeField] private TileSmooth[] tiles;
    [SerializeField] private GameObject Texto;
    [SerializeField] private GameObject Boton;
    [SerializeField] private GameObject Leer;

    private Camera camera;

    private int EmptyTileIndex = 8;

    // Start is called before the first frame update
    void Start()
    {
        shuffle(); //Para verificar el pop up comentad esto, moved unas pocas piezas y volvedlas a poner bien
        camera = Camera.main;

        Texto.SetActive(false);
        Boton.SetActive(false);
        Leer.SetActive(false);
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

                    int tileIndex = findIndex(tile);
                    tiles[EmptyTileIndex] = tiles[tileIndex];
                    tiles[tileIndex] = null;
                    EmptyTileIndex = tileIndex;
                }
            }
        }

        int correctTiles = 0;
        foreach (var a in tiles)
        {
            if (a != null)
            {
                if (a.inRightPlace)
                {
                    correctTiles++;
                }
            }
        }
        if (correctTiles == tiles.Length-1)
        {
            Leer.SetActive(true);
            Boton.SetActive(true);
        }
        else
        {
            Leer.SetActive(false);
            Boton.SetActive(false);
        }

    }

    public void shuffle() //Mezcla las tiles automaticamente
    {

        int inversion;

        if (EmptyTileIndex != 8)
        {
            var tile8Aux = tiles[8].targetPos;
            tiles[8].targetPos = EmptyTile.position;
            EmptyTile.position = tile8Aux;

            tiles[EmptyTileIndex] = tiles[8];
            tiles[8] = null;

            EmptyTileIndex = 8;
        }

        do
        {
            for (int i = 0; i < 8; i++)
            {
                var lastPos = tiles[i].targetPos;
                int randomI = Random.Range(0, 7);
                tiles[i].targetPos = tiles[randomI].targetPos;
                tiles[randomI].targetPos = lastPos;
                var tile = tiles[i];
                tiles[i] = tiles[randomI];
                tiles[randomI] = tile;
            }

            inversion = Inversions();
            Debug.Log("Suffled");

        } while (inversion % 2 != 0);
    }

    public int findIndex(TileSmooth ts)
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if (tiles[i] != null)
            {
                if (tiles[i] == ts)
                {
                    return i;
                }
            }
        }

        return -1;
    }

    int Inversions()                                // Comprueba que no haya tiles más grandes por debajo de un atile dada
    {
        int inversionsSUM = 0;

        for (int i = 0; i < tiles.Length; i++)
        {
            int thisInversion = 0;

            for (int j = i; j < tiles.Length; j++)
            {
                if (tiles[j] != null)
                {
                    if (tiles[i].num > tiles[j].num)        
                    {
                        thisInversion ++;
                    }
                }
            }

            inversionsSUM += thisInversion;
        }

        return inversionsSUM;                       // Si es par es resolvible // Si es impar es imposible (en principio xd)
    }
}
