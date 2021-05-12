using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PATHFinding;
using StatsTypes;
using Stats;

public class QueryManager : MonoBehaviour
{
    public static QueryManager instance;
    private static AdjacentRouteStats routeStats = new AdjacentRouteStats();

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        
    }

    public void QueryPath(NavigationPoint start,NavigationPoint end,int flag)
    {
        int[] path = PathFinding.GetPath(start.building.index, end.building.index, flag);
        route[] routes = new route[path.Length-1];
        for (int i = 0; i < path.Length-1; i++)
        {
            routes[i] = routeStats.GetRoute(path[i], path[i + 1]);
        }
        DrawManager.instance.DrawRoute(routes);
    }
}
