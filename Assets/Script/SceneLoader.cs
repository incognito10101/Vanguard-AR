using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public void LoadARScene()
    {
        SceneManager.LoadScene("ARScene");
    }
}