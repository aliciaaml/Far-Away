using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iluminación : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Sprite aux;

    public Sprite nuevoSprite;
    private void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        aux = sprite.sprite;
    }

    public void Rotismo(){
        aux = sprite.sprite;
    }


    private void OnMouseOver()
    {
        if(!MinigameEnter.circularDisable && EsconderTexto.boton_no)
            sprite.sprite = nuevoSprite;
    }

    private void OnMouseExit()
    {
        sprite.sprite = aux;
    }
}
