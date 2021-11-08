using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSmooth : MonoBehaviour
{
    public Vector3 targetPos;
    private Vector3 correctPos;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Awake()
    {
        targetPos = transform.position;
        correctPos = transform.position;
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.03f);

        if (targetPos == correctPos)
        {
            sprite.color = Color.green;
        }
        else
        {
            sprite.color = Color.white;
        }

    }
}
