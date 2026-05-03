using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMode : MonoBehaviour
{
   public void level()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
