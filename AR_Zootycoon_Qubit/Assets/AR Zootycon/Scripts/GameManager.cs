using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
