using UnityEngine;

public class StateController : MonoBehaviour
{
    
    void Start()
    {
        ChangeState(PlayerState.Idle);
    }
    private PlayerState _currentPlayerState = PlayerState.Idle;

    public void ChangeState(PlayerState newPlayerState)
    {
        if (_currentPlayerState == newPlayerState) { return; }
        _currentPlayerState = newPlayerState;
    }
    public PlayerState GetCurrentState()
    {
        return _currentPlayerState;
    }

}
