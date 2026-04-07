using UnityEngine;

public class Interactableitem : MonoBehaviour
{
    public ScriptableItem item;
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Start()
    {
        //spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter(Collider collision)
    {
        Inventorymanager.Instance.AddItem(item);
        Destroy(gameObject);
    }

   
}
