﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public void BUTTON_ACTION_reloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
