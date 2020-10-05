using UnityEngine;


[CreateAssetMenu(fileName = "Animal", menuName = "SOAnimals")]
public class SOAnimals : ScriptableObject
{
    [SerializeField] internal Sprite iconAnimal;
    
    [TextArea(0,500)]
    [SerializeField] internal string descriptionAnimal;

    [SerializeField] internal bool isOtherColor;
    [SerializeField] internal Color[] colorAnimal;

    [SerializeField] internal string habitAnimal;
    [SerializeField] internal Sprite[] otherSpecieAnimal;
}
