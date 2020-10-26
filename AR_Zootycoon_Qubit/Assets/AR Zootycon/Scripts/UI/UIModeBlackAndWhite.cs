using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIModeBlackAndWhite : MonoBehaviour
{
    [SerializeField] internal bool isModeBlack;

    [Space(15)]
    [SerializeField] internal Color colorOrange;
    [SerializeField] internal Color colorWhite;
    [SerializeField] internal Color colorBlack;

    [Space(15)]
    [SerializeField] internal Color colorBlackDark;
    [SerializeField] internal Color colorBlackSure;

    [Space(15)]
    [SerializeField] internal Image[] imageDark;
    [SerializeField] internal Image[] imageSure;
    [SerializeField] internal Image[] imageOfBlackToWhite;
    [SerializeField] internal TextMeshProUGUI[] textAppChangeToWhite;
    [SerializeField] internal TextMeshProUGUI[] textOrangeToWhite;

    [Header("SETTINGS BUTTONS GET EVENT")]
    [SerializeField] internal TextMeshProUGUI titleButton;
    [SerializeField] internal string titleInModeBlack;
    [SerializeField] internal string titleInModeWhite;

    public void GetTema()
    {
        isModeBlack = !isModeBlack;

        if (isModeBlack)
        {
            titleButton.text = titleInModeBlack;

            for (int i = 0; i < imageDark.Length; i++)
            {
                imageDark[i].color = colorBlackDark;
            }
            for (int i = 0; i < imageSure.Length; i++)
            {
                imageSure[i].color = colorBlackSure;
            }
            for (int i = 0; i < imageOfBlackToWhite.Length; i++)
            {
                imageOfBlackToWhite[i].color = colorWhite;
            }


            for (int i = 0; i < textAppChangeToWhite.Length; i++)
            {
                textAppChangeToWhite[i].color = colorWhite;
            }
            for (int i = 0; i < textOrangeToWhite.Length; i++)
            {
                textOrangeToWhite[i].color = colorWhite;
            }
        }
        else if(!isModeBlack)
        {
            titleButton.text = titleInModeWhite;

            for (int i = 0; i < imageDark.Length; i++)
            {
                imageDark[i].color = colorWhite;
            }
            for (int i = 0; i < imageSure.Length; i++)
            {
                imageSure[i].color = colorWhite;
            }
            for (int i = 0; i < imageOfBlackToWhite.Length; i++)
            {
                imageOfBlackToWhite[i].color = colorBlack;
            }


            for (int i = 0; i < textAppChangeToWhite.Length; i++)
            {
                textAppChangeToWhite[i].color = colorBlack;
            }
            for (int i = 0; i < textOrangeToWhite.Length; i++)
            {
                textOrangeToWhite[i].color = colorOrange;
            }
        }
    }
}
