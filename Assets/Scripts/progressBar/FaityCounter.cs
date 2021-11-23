using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FaityCounter
{
    public static int counter;
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
    public static void RestartCounter() => counter = 0;

    public static void AddOne()
    {
        counter++;
    }
}
