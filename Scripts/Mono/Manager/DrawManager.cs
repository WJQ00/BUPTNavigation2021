using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StatsTypes;

public class DrawManager : MonoBehaviour
{
    public static DrawManager instance;
    public GameObject map;
    public Material routeLineMaterial;
    private NavigationPoint[] navigationPoints;
    private TurningPoint[] turningPoints;
    private LineRenderer routeLine;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this.gameObject);
    }
    void Start()
    {
        navigationPoints = map.GetComponentsInChildren<NavigationPoint>();
        turningPoints = map.GetComponentsInChildren<TurningPoint>();
    }
    void Update()
    {
        
    }
    public void DrawRoute(route[] routes)
    {
        foreach (var route in routes)
        {
            List<Vector3> vertices = new List<Vector3>();
            vertices.Add(navigationPoints[route.startNavigationPointIndex].transform.position);
            foreach (var vertex in route.routeTurningPoints)
            {
                vertices.Add(turningPoints[vertex].transform.position);
            }
            vertices.Add(navigationPoints[route.endNavigationPointIndex].transform.position);
            DrawLine(vertices.ToArray());
        }

    }
    private void DrawLine(Vector3[] vertices)
    {
        GameObject go = new GameObject("RouteLine");
        routeLine = go.AddComponent<LineRenderer>();
        routeLine.startColor = Color.green;
        routeLine.startColor = Color.green;
        routeLine.startWidth = 0.15f;
        routeLine.endWidth = 0.15f;
        routeLine.material = routeLineMaterial;
        routeLine.numCornerVertices = 90;
        routeLine.SetPositions(vertices);
    }
}
