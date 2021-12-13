using UnityEngine;

public class inventoryUI : MonoBehaviour
{ 
    Inventory inventory;
    public Transform Parent;

    Slot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.inst;
        inventory.OnItemChangeCallback += UpdateUI;

        slots = Parent.GetComponentsInChildren<Slot>();

        gameObject.GetComponent<Animator>().SetBool("Mouse", false);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < inventory.items.Count; i++)
        {
            slots[i].icon.sprite = inventory.items[i].icon;
        }

        if (Input.mousePosition.x >= 1600f && Input.mousePosition.x < 1800f)
        {
            gameObject.GetComponent<Animator>().SetTrigger("MouseEnter");

        }

        if (Input.mousePosition.x > 1600f)
        {
            gameObject.GetComponent<Animator>().SetBool("Mouse", true);
        }
        else { gameObject.GetComponent<Animator>().SetBool("Mouse", false); }
    }

    public void AnimationIn()
    {
        gameObject.GetComponent<Animator>().SetBool("FinishIn", true);
        gameObject.GetComponent<Animator>().SetBool("FinishOut", false);
    }

    public void AnimationOut()
    {
        gameObject.GetComponent<Animator>().SetBool("FinishOut", true);
        gameObject.GetComponent<Animator>().SetBool("FinishIn", false);
    }

    public void AnimationPopUp()
    {
        gameObject.GetComponent<Animator>().SetBool("NewItem", false);
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {

            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].CleanSlot();
            }
        }
    }
}
