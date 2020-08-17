using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{
    public void PlaneTracking()
    {
        SceneManager.LoadScene(1);
    }
    public void ImageTracking()
    {
        SceneManager.LoadScene(2);
    }    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void FaceTracking()
    {
        SceneManager.LoadScene(3);
    }

}
