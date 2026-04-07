using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;
    public int slotNumber;
    public GameObject inspectWindow;
    public Image inspectionImage;
    public Text inspectionName;
    public Text inspectiionPrice;
    public Text inspectionDescription;

    public Button thisSlotButton;

    public Button deleteButton;
    public Button closeButton;
    
    void Start()
    {
        thisSlotButton = GetComponentInChildren<Button>();
        thisSlotButton.onClick.AddListener(InspectItem);
    }

    
    void InspectItem()
    {
        if(slotItem != null)
        {
            closeButton.onClick.AddListener(CloseWindow);
            closeButton.onClick.AddListener(DeleteItem);

            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectiionPrice.text = slotItem.itemSellPrice.ToString();
            inspectionDescription.text = slotItem.itemDescription;

            inspectWindow.SetActive(true);
        }
    }

    void CloseWindow()
    {

    }

    void DeleteItem()
    {

    }
}
