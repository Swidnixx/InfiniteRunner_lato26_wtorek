using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public AudioSource music;
    public AudioSource sfx;

    public AudioClip menuMusic;
    public AudioClip gameplayMusic;

    private void Start()
    {
        music.clip = menuMusic;
        music.Play();
    }

    public void PlaySfx(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }
}
