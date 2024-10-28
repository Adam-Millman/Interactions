using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleInventory : MonoBehaviour
{
    [SerializeField] private InputActionReference inventoryButton;
    [SerializeField] private GameObject[] inventoryPanels; 

    private bool isInventoryVisible = false;

    void Start()
    {
        inventoryButton.action.performed += InventoryToggle;

        foreach (GameObject panel in inventoryPanels)
        {
            panel.SetActive(isInventoryVisible);
        }
    }

    private void InventoryToggle(InputAction.CallbackContext context)
    {
        isInventoryVisible = !isInventoryVisible;

        foreach (GameObject panel in inventoryPanels)
        {
            panel.SetActive(isInventoryVisible);

            foreach (Transform child in panel.transform)
            {
                child.gameObject.SetActive(isInventoryVisible);
            }
        }
    }

    public void AddItemToInventory(GameObject item)
    {
        if (inventoryPanels.Length > 0)
        {
            item.transform.SetParent(inventoryPanels[0].transform, worldPositionStays: false);
            item.SetActive(isInventoryVisible); 

            Debug.Log($"{item.name} added to inventory and parented to {inventoryPanels[0].name}");
        }
        else
        {
            Debug.LogWarning("No inventory panels set up!");
        }
    }

    private void OnDestroy()
    {
        inventoryButton.action.performed -= InventoryToggle;
    }
}
