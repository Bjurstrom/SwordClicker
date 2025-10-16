using UnityEngine;
using UnityEngine.Serialization;

public class AudioHandlerScript : MonoBehaviour
{
    [SerializeField] AudioClip backroundMusic;
    [SerializeField] AudioClip ClickSFX;
    [SerializeField] AudioClip Boink;
    [SerializeField] AudioClip Bink;

    AudioSource audioSource;

    int Money;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        PlayBackroundMusic();
    }

    void PlayBackroundMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = (backroundMusic);
            audioSource.Play();
        }

    }

    void PlayClickSound()
    {
        audioSource.PlayOneShot(ClickSFX);
    }
}
