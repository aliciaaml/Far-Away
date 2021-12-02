using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IluminarRadio : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;

    void Start(){

        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver(){

        m_SpriteRenderer.sprite=Resources.Load<Sprite>("Sprites/Radio1Iluminada");
    }

    void OnMouseExit(){

        m_SpriteRenderer.sprite=Resources.Load<Sprite>("Sprites/Radio1");
    }
}
