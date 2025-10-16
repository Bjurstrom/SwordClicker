using UnityEngine;

public class AudioHandlerScript : MonoBehaviour
{
    [SerializeField] AudioClip backroundMusic;
    [SerializeField] AudioClip ClickSFX;

    [Header("AnvilHitSound")]
    [SerializeField] AudioClip[] MetalHitSound;
    

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

    public void PlayClickSound()
    {
        audioSource.PlayOneShot(ClickSFX);
    }

    public void PlayAnvilSound()
    {
        audioSource.PlayOneShot(MetalHitSound[Random.Range(1,MetalHitSound.Length)]);
    }
}
