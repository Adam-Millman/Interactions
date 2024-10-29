using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwistToggle : MonoBehaviour
{
    [SerializeField] private Transform leftWrist;
    [SerializeField] private GameObject[] inventoryPanels; 
    [SerializeField] private float rotationThreshold = 45f;

    private bool isInventoryVisible = false;

    void Start()
    {
        SetInventoryActive(isInventoryVisible);
    }

    void Update()
    {
        ToggleInventoryVisibility();
    }

    private void ToggleInventoryVisibility()
    {
        float currentYRotation = leftWrist.eulerAngles.y;

        if (currentYRotation > rotationThreshold && !isInventoryVisible)
        {
            isInventoryVisible = true;
            SetInventoryActive(isInventoryVisible);
        }
        else if (currentYRotation < rotationThreshold && isInventoryVisible)
        {
            isInventoryVisible = false;
            SetInventoryActive(isInventoryVisible);
        }
    }

    private void SetInventoryActive(bool isActive)
    {
        foreach (GameObject panel in inventoryPanels)
        {
            panel.SetActive(isActive);
        }
    }
}
