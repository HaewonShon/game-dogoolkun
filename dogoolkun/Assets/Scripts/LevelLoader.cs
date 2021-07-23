using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(GameManager.Instance.GetCurrentLevel() < 2)
        {
            // random level
            SceneManager.LoadScene(GameManager.Instance.GetRandomSceneName());
        }
        else
        {
            // final level
            SceneManager.LoadScene("BossLevel");
        }
    }
}
