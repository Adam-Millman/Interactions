using UnityEngine;
using UnityEngine.XR;

public class InventoryActivator : MonoBehaviour
{
    public GameObject inventoryUI;
    public float twistThreshold = 30f;
    private Quaternion lastRotation;
    private InputDevice leftHandDevice;

    void Start()
    {
        inventoryUI.SetActive(false);

        leftHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        lastRotation = Quaternion.identity;
    }

    void Update()
    {
        if (leftHandDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion currentRotation))
        {
            float twistAmount = Quaternion.Angle(lastRotation, currentRotation);
            
            if (twistAmount > twistThreshold)
            {
                inventoryUI.SetActive(!inventoryUI.activeSelf);
            }

            lastRotation = currentRotation;
        }
    }
}
