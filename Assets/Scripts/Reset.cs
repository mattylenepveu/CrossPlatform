using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Reset : MonoBehaviour
{
    //-----------------------------------------------------------------
    // Resets the game when called so it returns player back to game
    //-----------------------------------------------------------------
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
