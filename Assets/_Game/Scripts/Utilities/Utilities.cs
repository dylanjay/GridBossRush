using UnityEngine;

public static class Utilities
{
    public static bool LayerCollision(GameObject go, LayerMask mask)
    {
        return (1 << go.layer & mask.value) != 0;
    }
}
