using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D player)
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

        // TODO : Set player's position as start position
        player.transform.position = new Vector2(0, 0);
    }
}
