
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
