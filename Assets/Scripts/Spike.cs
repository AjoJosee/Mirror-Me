
using UnityEngine;

public class Spike : MonoBehaviour
{
  public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            GameManager.instance.RestartLevel();
        }
    }
}

