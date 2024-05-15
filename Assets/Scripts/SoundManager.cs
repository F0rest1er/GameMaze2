using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Button soundButton;
    private AudioManager audioManager;

    void Start()
    {
        soundButton.onClick.AddListener(ToggleSound);
        audioManager = AudioManager.Instance; // Получаем экземпляр AudioManager
    }

    void ToggleSound()
    {
        if (audioManager != null)
        {
            audioManager.ToggleSound();
        }
        else
        {
            Debug.LogWarning("AudioManager instance is null. Make sure AudioManager is set up correctly.");
        }
    }
}
