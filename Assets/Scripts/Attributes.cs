using UnityEngine;
using UnityEngine.SceneManagement;
public class Attributes : MonoBehaviour
{
    [SerializeField] float health = 50f;
    [SerializeField]
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
