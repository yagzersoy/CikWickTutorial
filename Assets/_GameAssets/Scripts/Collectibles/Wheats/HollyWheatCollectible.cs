using UnityEngine;

public class HollyWheatCollectible : MonoBehaviour,ICollectible
{
   [SerializeField] private PlayerController _playerController;

    [SerializeField] private float _forceIncrease;
    [SerializeField] private float _resetBoostDuration;
    public void Collect()
    {
        _playerController.SetJumpForce(_forceIncrease, _resetBoostDuration);
        Destroy(gameObject);
    }
}
