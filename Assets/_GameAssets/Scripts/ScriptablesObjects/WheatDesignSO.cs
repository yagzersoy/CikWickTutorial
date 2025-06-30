using System.IO.Enumeration;
using UnityEngine;
[CreateAssetMenu(fileName="WheatDesignSO",menuName="ScriptableObjects/WheatDesignSO")]
public class WheatDesignSO : ScriptableObject
{
    [SerializeField] private float _increaseDecreaseMultipler;
    [SerializeField] private float _resetBoostDuration;

    public float IncreaseDecreaseMultipler => _increaseDecreaseMultipler;
    public float ResetBoostDuration => _resetBoostDuration;
}
