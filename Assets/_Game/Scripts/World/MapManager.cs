using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : Singleton<MapManager>
{
    [SerializeField]
    GridMap[] gridMaps;

    [System.NonSerialized]
    public GridMap currentMap;

    void Start()
    {
        //Random Map
        int mapToLoad = Random.Range(0, gridMaps.Length);
        LoadMap(mapToLoad);
    }

    void LoadMap(int mapIndex)
    {
        GameObject map = (GameObject)Instantiate(gridMaps[mapIndex].gameObject);
        currentMap = map.GetComponent<GridMap>();
    }
}
