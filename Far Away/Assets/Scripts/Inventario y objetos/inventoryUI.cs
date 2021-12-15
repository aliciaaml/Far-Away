using UnityEngine;

public class inventoryUI : MonoBehaviour
{ 
    Inventory inventory;
    public Transform Parent;

    Slot[] slots;

    bool checkInventory = false;

    #region Singleton

    public static inventoryUI inst;


    private void Awake()
    {
        if (inventoryUI.inst == null)         // Primera vez que se crea una intancia, osea primera instancia.
        {
            inventoryUI.inst = this;          // Instancia ÚNICA --> no duplicados en cambios de escena ni en DontDestroyOnLoad()
                                            // Si este script se vuelve a cargar, Inventory.inst ya no será null, evitando así la creación de duplicados.
                                            // Inventory.inst para acceder a esta instancia desde cualquier escena
            DontDestroyOnLoad(gameObject);  // DontDestroyOnLoad crea una escena independiente y mueve a ella lo que sea que le digamos para mantenerla entre escenas, pero puede producir duplicados
        }

        else
        {
            Destroy(gameObject);            // Si ya hay una instancia destruye la segunda
        }
    }

    #endregion

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
        if (Input.GetKeyDown(KeyCode.I) && !checkInventory)
        {
            gameObject.GetComponent<Animator>().SetBool("Mouse", true);
            checkInventory = true;
        }

        else if (Input.GetKeyDown(KeyCode.I) && checkInventory)
        { 
            gameObject.GetComponent<Animator>().SetBool("Mouse", false);
            checkInventory = false;
        }
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
