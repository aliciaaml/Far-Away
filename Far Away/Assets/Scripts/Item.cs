using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventario/Item")]

public class Item : ScriptableObject
{
    new public string name = "New name";
    public Sprite icon = null;
}
