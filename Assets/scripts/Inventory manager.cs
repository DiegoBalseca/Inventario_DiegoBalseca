using UnityEngine;
using UnityEngine.UI;
public class Inventorymanager : MonoBehaviour
{

    public static Inventorymanager Instance;

    void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    
    public ScriptableItem[] items;
    public Text[] ItemsNames;
    public Image[] ItemsImage;
    public InventorySlot[] itemSlots;

    public void AddItem(ScriptableItem item)
    {
        for(int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = item;
                ItemsNames[i].text = item.itemName;
                ItemsImage[i].sprite = item.itemSprite;

                itemSlots[i].slotItem = item;
                itemSlots[i].slotNumber = i;

                return;
            }
        }
    }
}
