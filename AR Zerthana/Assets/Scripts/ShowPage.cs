using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowPage : MonoBehaviour
{
    public void Goback ()
    {
    	SceneManager.LoadScene(0);
    }
}
