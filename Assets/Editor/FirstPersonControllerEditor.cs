using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FirstPersonController))]
public class FirstPersonControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        FirstPersonController myFPC = (FirstPersonController)target;
        EditorGUILayout.LabelField("Movement Speed: " + myFPC._moveSpeed);
        myFPC._walkSpeed = EditorGUILayout.Slider("Walk Speed", myFPC._walkSpeed, 5, 10);
        myFPC._runSpeed = EditorGUILayout.Slider("Run Speed", myFPC._runSpeed, myFPC._walkSpeed, myFPC._walkSpeed + 5);
        myFPC._jumpHeight = EditorGUILayout.Slider("Jump Height", myFPC._jumpHeight, 1, 10);
        serializedObject.ApplyModifiedProperties();
    }
}
