using UnityEngine;
using UnityEngine.UI;

public class AddToFavorite : MonoBehaviour
{
    [SerializeField] internal DeleteFavorite deleteFavorite;

    [SerializeField] internal Transform parent;

    [Space(15)]
    [SerializeField] internal GameObject buttonFavorite;

    [Header("UI")]
    [SerializeField] internal Image iconFavorite;
    [SerializeField] internal Sprite notFavotire;
    [SerializeField] internal Sprite favoriteAdd;
    
    [Space(15)]
    private int count;
    internal Transform newInstance;

    public void AddFavorite()
    {
        count += 1;

        if(count == 1)
        {
            iconFavorite.sprite = favoriteAdd;
            iconFavorite.color = Color.white;

            newInstance = Instantiate(parent);
            newInstance.parent = GameManager.instance.managerUI.positionAddFavorite;
            newInstance.localScale = new Vector3(1,1,1);

            newInstance.GetComponent<AddToFavorite>().buttonFavorite.SetActive(false);
            newInstance.GetComponent<AddToFavorite>().newInstance = newInstance;
        }

        if(count == 2)
        {
            iconFavorite.sprite = notFavotire;

            if (!GameManager.instance.changeTemaApp.isModeBlack)
            {
                iconFavorite.color = GameManager.instance.changeTemaApp.colorBlack;
            }

            count = 0;
            deleteFavorite.DeleteOfFavorite();
        }

    }
}
