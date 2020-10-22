using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SOSpecie))]
public class EditorSOSpecie : Editor
{
    private SerializedProperty propertyIsAnimals;
    private SerializedProperty propertyIsPlant;
    private SerializedProperty propertyNameSpecie;
    private SerializedProperty propertyIconContentModel;
    private SerializedProperty propertyIconMoreInfo;
    private SerializedProperty propertyDescriptionSpecie;
    private SerializedProperty propertyIsOtherSpecies;
    private SerializedProperty propertyOtherSpecie;


    private SerializedProperty propertyClassAnimals;
    private SerializedProperty propertyClassPlants;

    private GUISkin skinTitleGeneral;
    private GUISkin skinTitleAnimals;
    private GUISkin skinTitlePlants;

    private void OnEnable()
    {
        skinTitleGeneral = Resources.Load<GUISkin>("GuiSkin/TextGeneral");
        skinTitleAnimals = Resources.Load<GUISkin>("GuiSkin/TextAnimals");
        skinTitlePlants = Resources.Load<GUISkin>("GuiSkin/TextPlants");

        propertyIsAnimals = serializedObject.FindProperty("isAnimals");
        propertyIsPlant = serializedObject.FindProperty("isPlant");
        propertyNameSpecie = serializedObject.FindProperty("nameSpecie");
        propertyIconContentModel = serializedObject.FindProperty("iconContentModel");
        propertyIconMoreInfo = serializedObject.FindProperty("iconMoreInfo");
        propertyDescriptionSpecie = serializedObject.FindProperty("descriptionSpecie");
        propertyIsOtherSpecies = serializedObject.FindProperty("isOtherSpecies");
        propertyOtherSpecie = serializedObject.FindProperty("otherSpecie");


        propertyClassAnimals = serializedObject.FindProperty("animals");
        propertyClassPlants = serializedObject.FindProperty("plants");
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
        EditorGUILayout.PropertyField(property: propertyClassAnimals, includeChildren: true);
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
        EditorGUILayout.PropertyField(property: propertyClassPlants, includeChildren: true);
        serializedObject.ApplyModifiedProperties();


    }
}
