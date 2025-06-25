
using UnityEngine;
using System.Collections;

public class TimedPlatform : MonoBehaviour
{
    public float activeTime = 2f;
    public float inactiveTime = 2f;

    private Renderer platformRenderer;
    private Collider2D platformCollider;

    void Start()
    {
        platformRenderer = GetComponent<Renderer>();
        platformCollider = GetComponent<Collider2D>();
        StartCoroutine(TogglePlatform());
    }

    IEnumerator TogglePlatform()
    {
        while (true)
        {
            // Activate platform
            platformRenderer.enabled = true;
            platformCollider.enabled = true;
            yield return new WaitForSeconds(activeTime);

            // Deactivate platform
            platformRenderer.enabled = false;
            platformCollider.enabled = false;
            yield return new WaitForSeconds(inactiveTime);
        }
    }
}

