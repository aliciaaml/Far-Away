using UnityEngine;

public class inventoryUI : MonoBehaviour
{ 
    Inventory inventory;
    public Transform Parent;

    Slot[] slots;

    public Animator animator;

    bool animation = false;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.inst;
        inventory.OnItemChangeCallback += UpdateUI;

        slots = Parent.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                animation = true;
                animator.SetBool("NewItem", animation);
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                animation = false;
                slots[i].CleanSlot();
            }
        }
    }
}
