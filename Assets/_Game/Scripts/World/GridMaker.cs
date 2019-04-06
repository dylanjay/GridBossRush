using UnityEngine;

public class GridMaker : MonoBehaviour
{
    [SerializeField] Vector2 gridSize;
    [SerializeField] Vector2 cellSize;
    [SerializeField] Vector2 cellGap;

    void Start()
    {
        MakeGrid();
    }

    void MakeGrid()
    {
        for (int i = (int)-gridSize.x / 2; i < gridSize.x / 2; i++)
        {
            for (int j = (int)-gridSize.y / 2; j < gridSize.y / 2; j++)
            {
                Transform cube = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
                cube.localScale = new Vector3(cellSize.x, 1f, cellSize.y);
                //cube.localPosition = 
            }
        }
    }
}
