using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] internal ManagerUI managerUI;

    private void Awake()
    {
        managerUI.GeTAwake();
    }

    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}

