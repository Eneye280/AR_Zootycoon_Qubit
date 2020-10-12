using UnityEngine;


[CreateAssetMenu(fileName = "Animal", menuName = "SOAnimals")]
public class SOAnimals : ScriptableObject
{
    [SerializeField] internal Sprite iconAnimal;
    
    [Space(15)]
    [TextArea(0,800)]
    [SerializeField] internal string descriptionAnimal;

    [Space(15)]
    [SerializeField] internal Sprite stateConservation;

    [Space(15)]
    [TextArea(0, 20)]
    [SerializeField] internal string habitAnimal;
    [TextArea(0,20)]
    [SerializeField] internal string longevity;

    [Space(15)]
    [SerializeField] internal bool isOtherColor;
    [SerializeField] internal Color[] colorAnimal;

    [Space(15)]
    [SerializeField] internal bool isOtherSpecies;
    [SerializeField] internal Sprite[] otherSpecieAnimal;

    [Space(15)]
    [SerializeField] internal AudioClip soundAnimal;
}
