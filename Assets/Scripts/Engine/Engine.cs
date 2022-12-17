using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Engine
{
   

    #region 場景管理
    public static string NextLevelName;

    public static void LoadingSceneAsync(string nextSceneName)
    {
        NextLevelName = nextSceneName;
        SceneManager.LoadScene("AsyncLoader");
    }

    
    public static void LoadingScene(string nextSceneName)
    {
        NextLevelName = nextSceneName;
        SceneManager.LoadScene(nextSceneName);
    }
    
    #endregion


   
}