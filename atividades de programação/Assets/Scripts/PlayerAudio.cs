using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip coinSound;
    public AudioClip jumpSound;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySFX(AudioClip sfx)
    {
        audioSource.PlayOneShot(sfx);
    }
}
