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

    private bool solved;
    private int contador;

    // Start is called before the first frame update
    void Start()
    {
        //shuffle(); //Para verificar el pop up comentad esto, moved unas pocas piezas y volvedlas a poner bien
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
                }
            }
        }

        // Comprueba que todos las tiles son verdes (posicion corecta) y activa el pop up
        for (int i = 0; i < 8; i++)
        {
            if (tiles[i].GetComponent<SpriteRenderer>().color == Color.green)
            {
                contador += 1;
            }
            else { contador = 0; solved = false; }
            if (contador == 8) { solved = true; }
        }

        if (solved) { 
            Leer.SetActive(true); 
            Boton.SetActive(true); 
            
        }
        else { 
            Leer.SetActive(false); 
            Boton.SetActive(false);}
    }


    public void shuffle() //Mezcla las tiles automaticamente
    {
        for (int i = 0; i < 8; i++)
        {
            var lastPos = tiles[i].targetPos;
            int randomI = Random.Range(0, 7);
            tiles[i].targetPos = tiles[randomI].targetPos;
            tiles[randomI].targetPos = lastPos;
        }
    }
}
