using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    // Método para reiniciar el juego
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
