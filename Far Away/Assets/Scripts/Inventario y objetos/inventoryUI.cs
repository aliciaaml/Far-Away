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
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].CleanSlot();
            }
        }
    }
}
