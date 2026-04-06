using UnityEngine;
using UnityEngine.UI;

public class InfiniteInventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;
    private Text itemNameText;
    private Image itemImage;

    //Ventan de inspection
    public GameObject inspectWindow;
    public Image inspectionImage;
    public Text inspectionName;
    public Text inspectionPrice;
    public Text inspectionDesctiption;

    public Button thisSlotButton;
    public Button deleteButton;
    public Button closeButton;

    void Awake()
    {
        itemNameText = GetComponentInChildren<Text>();
        itemImage = GetComponentInChildren<Image>();

        GameObject canvas = GameObject.Find("InventoryCanvas");
        inspectWindow = canvas.transform.Find("InspectWindow").gameObject;
        inspectionImage = inspectWindow.transform.Find("Item Image").GetComponent<Image>();
        inspectionName = inspectWindow.transform.Find("Item Name").GetComponent<Text>();
        inspectionPrice = inspectWindow.transform.Find("Item Price").GetComponent<Text>();
        inspectionDesctiption = inspectWindow.transform.Find("Item Description").GetComponent<Text>();
        closeButton = inspectWindow.transform.Find("CloseButton").GetComponent<Button>();
        deleteButton = inspectWindow.transform.Find("DeleteButton").GetComponent<Button>();

        thisSlotButton = GetComponentInChildren<Button>();
        thisSlotButton.onClick.AddListener(InspectItem);
    }

    void Start()
    {
        itemNameText. text = slotItem.itemName;
        itemImage.sprite = slotItem.itemSprite;
    }

    void InspectItem()
    {
        if(slotItem != null)
        {
            deleteButton.onClick.RemoveAllListeners();
            closeButton.onClick.AddListener(CloseWindow);
            deleteButton.onClick.AddListener(DeleteItem);

            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionPrice.text = slotItem.itemSellPrice.ToString();
            inspectionDesctiption.text = slotItem.itemDescription;

            inspectWindow.SetActive(true);
        }
    }

    void CloseWindow()
    {
        inspectWindow.SetActive(false);
        closeButton.onClick.RemoveListener(CloseWindow);
        closeButton.onClick.RemoveListener(DeleteItem);
    }

    void DeleteItem()
    {
        InfiniteInventoryManager.Instance.items.Remove(slotItem);
        CloseWindow();
        Destroy(gameObject);
    }
}
