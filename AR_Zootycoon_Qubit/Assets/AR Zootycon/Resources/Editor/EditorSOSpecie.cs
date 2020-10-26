using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScriptableManagerSpecie))]
public class EditorSOSpecie : Editor
{
    //SETTINGS GENERAL
    private SerializedProperty propertyPositionInList;
    private SerializedProperty propertyIsAnimals;
    private SerializedProperty propertyIsPlant;
    private SerializedProperty propertyNameSpecie;
    private SerializedProperty propertyIconContentModel;
    private SerializedProperty propertyIconMoreInfo;
    private SerializedProperty propertyDescriptionSpecie;
    private SerializedProperty propertyIsOtherSpecies;
    private SerializedProperty propertyOtherSpecie;

    //SETTINGS ANIMALS
    private SerializedProperty propertyIsStateConservationAnimals;
    private SerializedProperty propertyStateConservationAnimals;
    private SerializedProperty propertyHabitAnimals;
    private SerializedProperty propertyLongevityAnimals;
    private SerializedProperty propertyIsOtherColorAnimals;
    private SerializedProperty propertyColorRepresentativeAnimals;
    private SerializedProperty propertyIsAudioSpecie;
    private SerializedProperty propertySoundSpecie;

    //SETTINGS PLANTS
    private SerializedProperty propertyHabitSpecie;
    private SerializedProperty propertyLongevitySpecie;
    private SerializedProperty propertyIsOtherColorPlant;
    private SerializedProperty propertyColorRepresentativePlant;

    //FONT
    private GUISkin skinTitleGeneral;
    private GUISkin skinTitleAnimals;
    private GUISkin skinTitlePlants;

    private void OnEnable()
    {
        skinTitleGeneral = Resources.Load<GUISkin>("GuiSkin/TextGeneral");
        skinTitleAnimals = Resources.Load<GUISkin>("GuiSkin/TextAnimals");
        skinTitlePlants = Resources.Load<GUISkin>("GuiSkin/TextPlants");

        //SETTINGS GENERAL
        propertyPositionInList = serializedObject.FindProperty("positionInList");
        propertyIsAnimals = serializedObject.FindProperty("isAnimals");
        propertyIsPlant = serializedObject.FindProperty("isPlant");
        propertyNameSpecie = serializedObject.FindProperty("nameSpecie");
        propertyIconContentModel = serializedObject.FindProperty("iconContentModel");
        propertyIconMoreInfo = serializedObject.FindProperty("iconMoreInfo");
        propertyDescriptionSpecie = serializedObject.FindProperty("descriptionSpecie");
        propertyIsOtherSpecies = serializedObject.FindProperty("isOtherSpecies");
        propertyOtherSpecie = serializedObject.FindProperty("otherSpecie");

        //SETTINGS ANIMALS
        propertyIsStateConservationAnimals = serializedObject.FindProperty("isStateConservationAnimals");
        propertyStateConservationAnimals = serializedObject.FindProperty("stateConservationAnimals");
        propertyHabitAnimals = serializedObject.FindProperty("habitAnimals");
        propertyLongevityAnimals = serializedObject.FindProperty("longevityAnimals");
        propertyIsOtherColorAnimals = serializedObject.FindProperty("isOtherColorAnimals");
        propertyColorRepresentativeAnimals = serializedObject.FindProperty("colorRepresentativeAnimals");
        propertyIsAudioSpecie = serializedObject.FindProperty("isAudioSpecie");
        propertySoundSpecie = serializedObject.FindProperty("soundSpecie");

        //SETTINGS PLANTS
        propertyHabitSpecie = serializedObject.FindProperty("habitSpecie");
        propertyLongevitySpecie = serializedObject.FindProperty("longevitySpecie");
        propertyIsOtherColorPlant = serializedObject.FindProperty("isOtherColor");
        propertyColorRepresentativePlant = serializedObject.FindProperty("colorRepresentative");
    }

    public override void OnInspectorGUI()
    {
        /*___________________________________  SERTTINGS GENERAL  ________________________________________*/

        GUILayout.BeginHorizontal("Box");
        GUILayout.Label("SETTINGS GENERAL", skinTitleGeneral.GetStyle("Header1"));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal("Box");
        GUILayout.Label("General configuration of the species in the project");
        GUILayout.EndHorizontal();

        serializedObject.Update();
        EditorGUILayout.PropertyField(property: propertyPositionInList, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIsAnimals, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIsPlant, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyNameSpecie, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIconContentModel, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIconMoreInfo, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyDescriptionSpecie, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIsOtherSpecies, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyOtherSpecie, includeChildren: true);
        serializedObject.ApplyModifiedProperties();

        /*___________________________________  SERTTINGS ANIMALS  ________________________________________*/

        GUILayout.Space(25);
        GUILayout.BeginHorizontal("Box");
        GUILayout.Label("SETTINGS ANIMALS", skinTitleAnimals.GetStyle("Header1"));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal("Box");
        GUILayout.Label("General configuration of the animals in the project");
        GUILayout.EndHorizontal();

        serializedObject.Update();
        EditorGUILayout.PropertyField(property: propertyIsStateConservationAnimals, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyStateConservationAnimals, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyHabitAnimals, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyLongevityAnimals, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIsOtherColorAnimals, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyColorRepresentativeAnimals, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIsAudioSpecie, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertySoundSpecie, includeChildren: true);
        serializedObject.ApplyModifiedProperties();

        /*___________________________________  SERTTINGS PLANTS  ________________________________________*/

        GUILayout.Space(25);
        GUILayout.BeginHorizontal("Box");
        GUILayout.Label("SETTINGS PLANTS", skinTitlePlants.GetStyle("Header1"));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal("Box");
        GUILayout.Label("General configuration of the plants in the project");
        GUILayout.EndHorizontal();

        serializedObject.Update();
        EditorGUILayout.PropertyField(property: propertyHabitSpecie, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyLongevitySpecie, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyIsOtherColorPlant, includeChildren: true);
        EditorGUILayout.PropertyField(property: propertyColorRepresentativePlant, includeChildren: true);
        serializedObject.ApplyModifiedProperties();


    }
}
