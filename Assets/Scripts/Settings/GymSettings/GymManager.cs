using UnityEngine;

public class GymManager : ObservableLogger
{
    private int _generalStats;
    private int _selfEsteem;

    public int GeneralStats
    {
        get => _generalStats;
        set
        {
            _generalStats = value;
        }
    }
    public int SelfEsteem
    {
        get => _selfEsteem;
        set
        {
            _selfEsteem = value;
        }
    }

    private void Start()
    {
        AddObservable(GymStats.Instance.Bench);
        AddObservable(GymStats.Instance.Squat);
        AddObservable(GymStats.Instance.DeadLift);
    }

    private void UpdateGymStats()
    {
        GeneralStats = (GymStats.Instance.Bench.Value + GymStats.Instance.Squat.Value);
        SelfEsteem = GymStats.Instance.DeadLift.Value;
    }
    protected override void OnChanged(object obj)
    {
        Debug.Log($"New GymStats - {GeneralStats}, SelfEsteem - {_selfEsteem}");
        UpdateGymStats();
    }
}
