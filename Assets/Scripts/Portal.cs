
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform destinationPortal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            other.transform.position = destinationPortal.position;
        }
    }
}

