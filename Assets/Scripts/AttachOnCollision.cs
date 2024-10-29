using UnityEngine;

public class AttachOnCollision : MonoBehaviour
{
    [SerializeField] private string targetTag = "Item";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            collision.transform.SetParent(transform);
            collision.transform.localPosition = Vector3.zero;
            collision.transform.localRotation = Quaternion.identity;
        }
    }
}
