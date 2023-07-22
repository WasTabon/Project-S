using System.Collections.Generic;
using UnityEngine;

public abstract class ObservableLogger : MonoBehaviour, IObserver
{
    private List<IObservable> _observables = new();

    public void AddObservable(IObservable observable)
    {
        if (_observables.Contains(observable))
            return;

        _observables.Add(observable);
        observable.OnChanged += OnChanged;
    }
    
    public void Dispose()
    {
        foreach (IObservable observable in _observables)
        {
            observable.OnChanged -= OnChanged;
        }
    }
    
    protected virtual void OnChanged(object obj)
    {
        
    }
}
