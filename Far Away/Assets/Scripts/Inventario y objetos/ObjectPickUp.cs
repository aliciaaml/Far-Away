using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{
    private Camera camera;

    public Item item;

    public static inventoryUI ui;

    public static bool ciruclar_item;
    public static bool nota_item;
    public static bool trozoNota_item;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        ciruclar_item=false;
        nota_item=false;
        trozoNota_item=false;

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

            if(!MinigameEnter.circularDisable && EsconderTexto.boton_no){

                if (hit.collider != null && hit.transform == transform)
                {
                    if (hit.transform.CompareTag("Objeto"))
                    {
                        //ui.gameObject.GetComponent<Animator>().SetBool("NewItem", true);


                        if (item.name == "Circular")
                        {
                            ciruclar_item = true;
                        }

                        if (item.name == "Nota")
                        {
                            nota_item = true;
                        }

                        if (item.name == "TrozoNota2")
                        {
                            trozoNota_item = true;
                        }

                        Inventory.inst.Add(item);
                        Destroy(gameObject);

                    }
                }
                
            }
        }
    }
}
