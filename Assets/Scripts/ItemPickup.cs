using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private ToggleInventory inventorySystem;

    void Start()
    {
        inventorySystem = FindObjectOfType<ToggleInventory>();
    }

    public void OnPickup()
    {
        if (inventorySystem != null)
        {
            inventorySystem.AddItemToInventory(gameObject);
        }
        else
        {
            Debug.LogWarning("Inventory system not found!");
        }
    }
}
