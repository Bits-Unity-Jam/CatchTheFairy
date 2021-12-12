using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FairyCounter
{
    public static int FairyCount { get; private set;}



    #region Непотріб
    public static float time = 0;

    public static float OldCollisionTime(float newCollisionTime)
    {
        time = newCollisionTime;
        return time;
    }
    public static float OldCollisionTime()
    {
        return time;
    } 
    #endregion


    public static void RestartCounter() => FairyCount = 0;

    public static void AddOne()
    {
        FairyCount++;
    }
}
