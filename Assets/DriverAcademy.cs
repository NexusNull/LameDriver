using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class DriverAcademy : Academy
{
    // Start is called before the first frame update
    void Start()
    {

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 300;
        Time.timeScale = 20;
        
    }

    // Update is called once per frame
    void Update()
    {


    }
}
