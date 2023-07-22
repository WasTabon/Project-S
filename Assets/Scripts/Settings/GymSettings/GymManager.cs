using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymManager : ObservableLogger
{
    private void Start()
    {
        AddObservable(GymStats.Instance.Bench);
        AddObservable(GymStats.Instance.Squat);
        AddObservable(GymStats.Instance.DeadLift);
    }
}
