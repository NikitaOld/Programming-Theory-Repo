using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MainManager : MonoBehaviour
{
    //Fields for display the player info
    public Text CurrentPlayerName;

    private string m_PlayerName;
    
    // Start is called before the first frame update
    void Start()
    {
        m_PlayerName = PlayerDataHandle.instance.PlayerName;
        CurrentPlayerName.text = $"Current name - {m_PlayerName}";
    }
}
