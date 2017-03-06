using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Parent))]
public class ParentEditor : Editor 
{
    private SerializedProperty _nested;

    private void OnEnable()
    {
        _nested = serializedObject.FindProperty("nestedObject");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(_nested);

        CreateEditor(_nested.objectReferenceValue).OnInspectorGUI();

        serializedObject.ApplyModifiedProperties();
    }
	
}
