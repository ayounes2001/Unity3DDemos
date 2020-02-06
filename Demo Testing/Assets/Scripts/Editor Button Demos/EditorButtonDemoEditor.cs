using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(EditorButtonDemo))]
public class EditorButtonDemoEditor : Editor
{
   public override void OnInspectorGUI()
   {
      DrawDefaultInspector();
      EditorButtonDemo myScript = (EditorButtonDemo) target;

      if (GUILayout.Button("Attacking"))
      {
         myScript.Attacking();
      }
      if (GUILayout.Button("Defending"))
      {
         myScript.Defending();
      }
      if (GUILayout.Button("Walking"))
      {
         myScript.Walking();
      }
      if (GUILayout.Button("Defending"))
      {
         myScript.Defending();
      }
   }
}
