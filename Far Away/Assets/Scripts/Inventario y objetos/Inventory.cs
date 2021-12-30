using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // ESTE SCRIPT PUEDE IR EN EL PERSONAJE, PERO COMO NO ESTA EN ESCENA ESTA EN UN OBJETO VACIO

    #region Singleton

    public static Inventory inst;

    public static int contador=0;

    private void Awake()
    {
        if (Inventory.inst == null)         // Primera vez que se crea una intancia, osea primera instancia.
        {
            Inventory.inst = this;          // Instancia �NICA --> no duplicados en cambios de escena ni en DontDestroyOnLoad()
                                            // Si este script se vuelve a cargar, Inventory.inst ya no ser� null, evitando as� la creaci�n de duplicados.
                                            // Inventory.inst para acceder a esta instancia desde cualquier escena
            DontDestroyOnLoad(gameObject);  // DontDestroyOnLoad crea una escena independiente y mueve a ella lo que sea que le digamos para mantenerla entre escenas, pero puede producir duplicados
        }

        else
        {
            Destroy(gameObject);            // Si ya hay una instancia destruye la segunda
        }
    }

    #endregion

    #region Delegate

    public delegate void OnItemChange();
    public OnItemChange OnItemChangeCallback;

    #endregion

    public List<Item> items = new List<Item>();

    public void Add(Item item)
    {
        items.Add(item);

        contador+=1;
      
        Debug.Log("contador: "+contador);

        if (OnItemChangeCallback != null) { OnItemChangeCallback.Invoke(); }
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (OnItemChangeCallback != null) { OnItemChangeCallback.Invoke(); }
    }
}
