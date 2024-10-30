using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ParentOnContact : MonoBehaviour
{
    private Transform originalParent;

    private void Start()
    {
        originalParent = transform.parent;
    }


    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("Slot"))
        {
            transform.SetParent(args.interactorObject.transform);
        }
    }

    public void OnSelectExited(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("Slot"))
        {
            transform.SetParent(originalParent);
        }
    }
}
