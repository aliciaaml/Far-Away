using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSmooth : MonoBehaviour
{
    public Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, 3f * Time.deltaTime);
    }
}
