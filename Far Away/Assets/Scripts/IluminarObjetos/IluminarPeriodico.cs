using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IluminarPeriodico : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;

    void Start(){

        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver(){

        m_SpriteRenderer.sprite=Resources.Load<Sprite>("Sprites/Periodico1Iluminado");
    }

    void OnMouseExit(){

        m_SpriteRenderer.sprite=Resources.Load<Sprite>("Sprites/Periodico1");
    }
}
