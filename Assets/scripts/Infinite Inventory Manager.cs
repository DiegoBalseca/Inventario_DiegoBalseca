using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InfiniteInventoryManager : MonoBehaviour
{
    public static InfiniteInventoryManager Instance;

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

        InventoryCanvasTransform = GameObject.Find("Inventory").transform;
    }
    
    public List<ScriptableItem> items;
    public List<InventorySlot> itemsSlots;
    public GameObject slotPrefab;
    private Transform InventoryCanvasTransform;

    public void AddItem(ScriptableItem item)
    {
        GameObject prefab = Instantiate(slotPrefab);
        prefab.transform.SetParent(InventoryCanvasTransform);
        InfiniteInventorySlot prefabScript = prefab.GetComponent<InfiniteInventorySlot>();
        prefabScript.slotItem = item;
        items.Add(item);
    }

}
