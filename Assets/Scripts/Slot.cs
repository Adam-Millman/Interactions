using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
//     public GameObject ItemInSlot;
//     public Image slotImage;
//     Color originalColor;
//     [SerializeField] private InputActionReference grabAction;

//     void Start()
//     {
//         slotImage = GetComponentInChildren<Image>();
//         originalColor = slotImage.color;
//     }

//     private void OnTriggerStay(Collider other)
//     {
//         if(ItemInSlot != null) return;
//         GameObject obj = other.gameObject;
//         if(!IsItem(obj)) return;
//         if (grabAction.action.performed != null){
//             InsertItem(obj);
//         }
//     }
   
//     bool IsItem(GameObject obj)
//     {
//         return obj.GetComponent<Item>();
//     }

//     void InsertItem(GameObject obj)
//     {
//         obj.GetComponent<RigidBody>().isKinematic = true;
//         obj.transform.SetParent(transform, true);
//         obj.transform.localPosition = Vector3.zero;
//         obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;
//         obj.GetComponent<Item>().inSlot = true;
//         obj.GetComponent<Item>().currentSlot = true;
//         ItemInSlot = obj;
//         slotImage.color = Color.gray;

//     }
//     public void ResetColor()
//     {
//         slotImage.color = originalColor;
//     }
}
