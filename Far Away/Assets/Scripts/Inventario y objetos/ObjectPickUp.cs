using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{
    private Camera camera;

    public Item item;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;

        foreach (Item item in Inventory.inst.items)
        {
            if (item == gameObject.GetComponent<ObjectPickUp>().item)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.transform.tag == "Objeto")
            {
                animator.SetBool("NewItem", true);
                Inventory.inst.Add(item);
                Destroy(gameObject);
                
            }
        }

        //animator.SetBool("NewItem", false);
    }
}
