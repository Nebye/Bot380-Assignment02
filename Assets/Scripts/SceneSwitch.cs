﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string newScene;
    public void SwtichTo()
    {
        SceneManager.LoadScene(sceneName: newScene);
    }
}
