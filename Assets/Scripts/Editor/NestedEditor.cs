using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Nested))]
public class NestedEditor : Editor 
{

    private SerializedProperty _characterName;
    private SerializedProperty _level;
    private SerializedProperty _life;

	private void OnEnable()
    {
        _characterName = serializedObject.FindProperty("characterName");
        _level = serializedObject.FindProperty("level");
        _life = serializedObject.FindProperty("life");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(_characterName);
        EditorGUILayout.PropertyField(_level);

        EditorGUILayout.Space();
        _life.intValue = EditorGUILayout.IntSlider("Life: ", _life.intValue, 0, 100);

        serializedObject.ApplyModifiedProperties();
    }
}
