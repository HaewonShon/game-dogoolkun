using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    [SerializeField] private string[] sceneNames;
    private Dictionary<string, bool> scenes = new Dictionary<string, bool>(); // scene name, is scene used
    private int currentLevel = 0;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            BuildSceneDictionary();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void BuildSceneDictionary()
    {
        Debug.Log("Built Level Dictionary. Count : " + sceneNames.Length);
        foreach(string sceneName in sceneNames)
        {
            scenes.Add(sceneName, false);
        }
        Debug.Log("Built Level Dictionary. Count : " + scenes.Count);
    }

    public string GetRandomSceneName()
    {
        currentLevel++;
        int levelIndex = Random.Range(0, scenes.Count);
        bool isLevelUsed = scenes[sceneNames[levelIndex]];

        while(isLevelUsed == true)
        {
            levelIndex = Random.Range(0, scenes.Count);
            isLevelUsed = scenes[sceneNames[levelIndex]];
        }

        scenes[sceneNames[levelIndex]] = true;
        return sceneNames[levelIndex];
    }

    public int GetCurrentLevel()
    {
        return currentLevel;
    }
}
