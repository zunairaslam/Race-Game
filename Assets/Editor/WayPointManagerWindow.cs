using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WayPointManagerWindow : EditorWindow
{
    [MenuItem("Waypoint/Waypoint Editor Tools")]
    public static void GetWindow()
    {
        GetWindow<WayPointManagerWindow>("Waypoint Editor Tools");
    }
    public Transform waypointorigin;
    private void OnGUI()
    {
        SerializedObject obj = new SerializedObject(this);
        EditorGUILayout.PropertyField(obj.FindProperty("waypointorigin"));

         if (waypointorigin == null)
        {
            EditorGUILayout.HelpBox("Please Assign a Waypoint Origin", MessageType.Warning);
        }else
        {
            EditorGUILayout.BeginVertical("box");
            CreateButtons();
            EditorGUILayout.EndVertical();
        }
        obj.ApplyModifiedProperties();
    }
    void CreateButtons()
    {
        if(GUILayout.Button("Create Waypoint"))
        {
            CreateWaypoint();
        }
    }

    void CreateWaypoint()
    {
        GameObject wayPointObject = new GameObject("Waypoint " + waypointorigin.childCount, typeof(Waypoint));
        wayPointObject.transform.SetParent(waypointorigin, false);

        Waypoint waypoint = wayPointObject.GetComponent<Waypoint>();

        if (waypointorigin.childCount > 1)
        {
            waypoint.previousWaypoint = waypointorigin.GetChild(waypointorigin.childCount - 2).GetComponent<Waypoint>();
            waypoint.previousWaypoint.nextWaypoint = waypoint;

            waypoint.transform.position = waypoint.previousWaypoint.transform.position;
            waypoint.transform.forward = waypoint.previousWaypoint.transform.forward;

        }

        Selection.activeGameObject = waypoint.gameObject;
    }

}
