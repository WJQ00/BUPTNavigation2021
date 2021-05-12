using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public static UIStats stats = new UIStats();
    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this.gameObject);
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
