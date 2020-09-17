using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivatePause : MonoBehaviour
{
    public GameObject g;
    public void ActivateObject()
    {
        if(g.activeInHierarchy)
        {
            g.SetActive(false);
        }
        else
        {
            g.SetActive(true);
        }
        
    }

   public void LoadScene(int x)
   {
        SceneManager.LoadScene(x);
   }
}
