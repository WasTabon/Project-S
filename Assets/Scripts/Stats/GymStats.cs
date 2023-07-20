using System;
using UnityEngine;

public class GymStats : MonoBehaviour
{
    private int _bench;
    private int _squat;
    private int _deadLift;
    
    public int Bench
    {
        get
        {
            return _bench;
        }
        set
        {
            if (value > 0)
                _bench = value;
            else
                throw new ArgumentException("Bench must be greater then zero.");
        }
    }
    public int Squat
    {
        get
        {
            return _squat;
        }
        set
        {
            if (value > 0)
                _squat = value;
            else
                throw new ArgumentException("Squat must be greater then zero.");
        }
    }
    public int DeadLift
    {
        get
        {
            return _deadLift;
        }
        set
        {
            if (value > 0)
                _squat = value;
            else
                throw new ArgumentException("Deadlift must be greater then zero.");
        }
    }
}
