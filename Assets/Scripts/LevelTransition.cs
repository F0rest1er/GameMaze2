using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] private string targetLevelName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadTargetLevel();
        }
    }

    private void LoadTargetLevel()
    {
        SceneManager.LoadScene(targetLevelName);
    }
}
