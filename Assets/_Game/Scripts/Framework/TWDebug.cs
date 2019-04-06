using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TWDebug
{
    public static void Log(params object[] list)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == null)
            {
                sb.Append("null");
            }
            else
            {
                sb.Append(list[i].ToString());
            }
            sb.Append(' ');
        }
        Debug.Log(sb.ToString());
    }
}
