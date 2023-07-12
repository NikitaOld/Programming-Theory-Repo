using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackOnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void SetPlayerName()
    {
        PlayerDataHandle.instance.PlayerName = PlayerNameInput.text;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    
}
