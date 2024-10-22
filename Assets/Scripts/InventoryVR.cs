using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class InventoryXRI : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Anchor;
    bool UIActive;
    public InputActionReference toggleInventoryAction;

    private void Start()
    {
        Inventory.SetActive(false);
        UIActive = false;

        toggleInventoryAction.action.performed += ToggleInventory;
    }

    private void OnDestroy()
    {
        toggleInventoryAction.action.performed -= ToggleInventory;
    }

    private void ToggleInventory(InputAction.CallbackContext context)
    {
        UIActive = !UIActive;
        Inventory.SetActive(UIActive);
    }

    private void Update()
    {
        if (UIActive)
        {
            Inventory.transform.position = Anchor.transform.position;
            Inventory.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
        }
    }
}
