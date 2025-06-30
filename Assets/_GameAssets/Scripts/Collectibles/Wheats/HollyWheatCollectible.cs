using UnityEngine;

public class HollyWheatCollectible : MonoBehaviour,ICollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
   [SerializeField] private PlayerController _playerController;

    
    public void Collect()
    {
        _playerController.SetJumpForce(_wheatDesignSO.IncreaseDecreaseMultipler,_wheatDesignSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
