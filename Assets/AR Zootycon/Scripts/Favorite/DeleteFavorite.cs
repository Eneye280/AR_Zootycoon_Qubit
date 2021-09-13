using UnityEngine;

public class DeleteFavorite : MonoBehaviour
{
    [SerializeField] AddToFavorite addToFavorite;

    public void DeleteOfFavorite()
    {
        Destroy(addToFavorite.newInstance.gameObject);
    }
}
