using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObservableExample : ObservableLogger
{
    private ObservableVariable<int> _observableVariableInt;

    private void Start()
    {
        _observableVariableInt = new ObservableVariable<int>(10);
        AddObservable(_observableVariableInt);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            RandomizeInt();
    }

    private void RandomizeInt()
    {
        int randomInt = Random.Range(1, 100);
        _observableVariableInt.Value = randomInt;
    }

    protected override void OnChanged(object obj)
    {
        Debug.Log($"{obj.GetType().Name} - {obj.ToString()}");
    }
}