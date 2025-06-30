
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip footstepSound;
    public AudioClip spikeSound;
    public AudioClip successSound;

    private AudioSource audioSource;

  public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void PlayFootstepSound()
    {
        audioSource.PlayOneShot(footstepSound);
    }

    public void PlaySpikeSound()
    {
        audioSource.PlayOneShot(spikeSound);
    }

    public void PlaySuccessSound()
    {
        audioSource.PlayOneShot(successSound);
    }
}

