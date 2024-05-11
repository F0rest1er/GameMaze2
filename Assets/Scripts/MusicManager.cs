using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance = null;

    public static MusicManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayMusic(AudioClip music)
    {
        GetComponent<AudioSource>().clip = music;
        GetComponent<AudioSource>().Play();
    }

    public void StopMusic()
    {
        GetComponent<AudioSource>().Stop();
    }
}
