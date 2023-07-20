using System;
using UnityEngine;

public class LifeStats : MonoBehaviour
{
    private int _balance;
    private float _charge;
    
    public enum Moods
    {
        EndedWithGirl,
        Sigma,
        VoicesInHead,
        Good,
        HappyButNot
    }
    
    public int Balance
    {
        get
        {
            return _balance;
        }
        set
        {
            if (value > 0)
                _balance = value;
            else
                throw new ArgumentException("Balance must be greater then zero.");
        }
    }
    public float Charge
    {
        get
        {
            return _charge;
        }
        set
        {
            if (value > 0)
                _charge = value;
            else
                throw new ArgumentException("Charge must be greater then zero.");
        }
    }
}
