using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iluminación : MonoBehaviour
{
    private SpriteRenderer Sprite;
    private Sprite aux;

    public Sprite nuevoSprite;
    private void Start()
    {
        Sprite = gameObject.GetComponent<SpriteRenderer>();
        aux = Sprite.sprite;
    }

    public void Rotismo(){
        aux = Sprite.sprite;
    }

    private void OnMouseOver()
    {
        if(!MinigameEnter.circularDisable && EsconderTexto.boton_no)
            Sprite.sprite = nuevoSprite;
    }

    private void OnMouseExit()
    {
        Sprite.sprite = aux;
    }
}
