using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] internal ManagerUI managerUI;
    [SerializeField] internal ChangeTemaApp changeTemaApp;

    private void Awake()
    {
        if (!instance)
            instance = FindObjectOfType<GameManager>();

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

