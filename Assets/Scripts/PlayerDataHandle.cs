using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    //Static Class for save the current player data;

    public static PlayerDataHandle instance;

    public string PlayerName;

    public void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        } 
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
