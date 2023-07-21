using System;
using UnityEngine;

public class GymStats : MonoBehaviour
{
    public ObservableVariable<int> Bench { get; private set; }
    public ObservableVariable<int> Squat { get; private set; }
    public ObservableVariable<int> DeadLift { get; private set; }
    
    public static GymStats Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        
        Destroy(gameObject);
    }
}
