using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LeaveButton : MonoBehaviour
{
    
    public void Leave()
    {
        LoadSchoolMap();
    }
   
    private void LoadSchoolMap()
    {
        SceneManager.LoadScene(0);

        
    }
}
