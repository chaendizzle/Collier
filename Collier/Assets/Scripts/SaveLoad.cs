﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    static bool loaded = false;
    public static Dictionary<string, int> levelUnlocked = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Awake()
    {
        if (!loaded)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string key = $"Level_{i}_{j}";
                    if (!PlayerPrefs.HasKey(key))
                    {
                        PlayerPrefs.SetInt(key, Random.Range(-1, 4));
                    }
                    levelUnlocked[key] = PlayerPrefs.GetInt(key);
                }
            }
            loaded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string key = $"Level_{i}_{j}";
                    PlayerPrefs.DeleteKey(key);
                }
            }
            loaded = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            levelUnlocked["Level_1_1"] = ((levelUnlocked["Level_1_1"] + 2) % 5) - 1;
        }
    }
}
