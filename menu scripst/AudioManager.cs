using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("Audio Source")]
    [SerializeField] private AudioSource sfxSource;

    [Header("Button SFX")]
    [SerializeField] private AudioClip buttonClickSound;
    [SerializeField] private AudioClip buttonHoverSound;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Scene değişse bile kalıcı
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Buton tıklama sesi
    public void PlayButtonClick()
    {
        if (buttonClickSound != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(buttonClickSound);
        }
    }

    // Buton hover sesi (opsiyonel)
    public void PlayButtonHover()
    {
        if (buttonHoverSound != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(buttonHoverSound);
        }
    }

    // Genel ses çalma
    public void PlaySound(AudioClip clip)
    {
        if (clip != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(clip);
        }
    }
}