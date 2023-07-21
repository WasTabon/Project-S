using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymManager : MonoBehaviour
{
    private ObservableLogger _logger;

    private void Start()
    {
        _logger = new ObservableLogger();
        _logger.AddObservable(GymStats.Instance.Bench); 
        _logger.AddObservable(GymStats.Instance.Squat);
        _logger.AddObservable(GymStats.Instance.DeadLift); 
    }
}
