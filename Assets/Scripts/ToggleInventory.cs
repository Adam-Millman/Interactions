using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleInventory : MonoBehaviour
{
    [SerializeField] private InputActionReference inventoryButton;
    [SerializeField] private GameObject inventoryObject;

    private bool isInventoryVisible = false;

    void Start()
    {
        inventoryButton.action.performed += InventoryToggle;
        inventoryObject.SetActive(isInventoryVisible);
    }

    private void InventoryToggle(InputAction.CallbackContext context)
    {
        isInventoryVisible = !isInventoryVisible;
        inventoryObject.SetActive(isInventoryVisible);
    }

    public void AddItemToInventory(GameObject item)
    {
        if (inventoryObject != null)
        {
            item.transform.SetParent(inventoryObject.transform, worldPositionStays: false);
            item.SetActive(isInventoryVisible);
            Debug.Log($"{item.name} added to inventory and parented to {inventoryObject.name}");
        }
        else
        {
            Debug.LogWarning("No inventory object set up!");
        }
    }

    private void OnDestroy()
    {
        inventoryButton.action.performed -= InventoryToggle;
    }
}
