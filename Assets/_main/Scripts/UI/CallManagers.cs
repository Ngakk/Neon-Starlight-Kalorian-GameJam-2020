﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Managers;

public class CallManagers : MonoBehaviour
{
    public void GoBackToMenu(int _index)
    {
        SceneManager.LoadScene(_index);
    }
}
