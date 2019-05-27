using UnityEngine;

public class GridTile : MonoBehaviour
{
    public int x;
    public int y;
    public bool moveable = true;

    public void Enter()
    {
        moveable = false;
    }

    public void Exit()
    {
        moveable = true;
    }
}
