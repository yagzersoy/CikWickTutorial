using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.XR;

public class CatStateController : MonoBehaviour
{
    [SerializeField] private CatState _currentCatState = CatState.Walking;

    void Start()
    {
        ChangeState(CatState.Walking);
    }

    public void ChangeState(CatState newState)
    {
        if (_currentCatState == newState) { return; }
        _currentCatState = newState;
    }
    public CatState GetCurrentState()
    {
        return _currentCatState;
    }
}
