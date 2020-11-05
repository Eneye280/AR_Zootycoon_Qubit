using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    [SerializeField] internal ManagerUI managerUI;
    [SerializeField] internal bool isSound;
    [Space(15)]
    [SerializeField] internal AudioSource audioButton;
    [SerializeField] internal AudioClip audioClipButton;

    public void GetSound()
    {
        audioButton.clip = audioClipButton;
        audioButton.Play();
    }   
    
    public void OnOffSound()
    {
        isSound = !isSound;

        if(isSound)
        {
            managerUI.iconSound.sprite = managerUI.spriteSound[0];
            audioButton.enabled = true;
        }
        else
        {
            managerUI.iconSound.sprite = managerUI.spriteSound[1];
            audioButton.enabled = false;
        }
    }

}
