using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iluminación : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Sprite aux;

    [SerializeField] Sprite nuevoSprite;
    private void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        aux = sprite.sprite;
    }


    private void OnMouseOver()
    {
        sprite.sprite = nuevoSprite;
    }

    private void OnMouseExit()
    {
        sprite.sprite = aux;
    }
}
