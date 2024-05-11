using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioSource musicSource;
    public Animator buttonAnimator;
    public Button button;

    private bool isMusicPlaying = true;

    void Start()
    {
        musicSource.Play();
        button.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isMusicPlaying)
        {
            musicSource.Pause();
            buttonAnimator.SetBool("IsSoundPlaying", false);
        }
        else
        {
            musicSource.Play();
            buttonAnimator.SetBool("IsSoundPlaying", true);
        }

        isMusicPlaying = !isMusicPlaying;
    }
}
