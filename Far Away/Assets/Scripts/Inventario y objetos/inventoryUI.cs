using UnityEngine;

public class inventoryUI : MonoBehaviour
{ 
    Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.inst;
        inventory.OnItemChangeCallback += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {

    }
}
