using UnityEngine;

public class RottenWheatCollectectible : MonoBehaviour,ICollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
 [SerializeField] private PlayerController _playerController;


    public void Collect()
    {
        _playerController.SetMovementSpeed(_wheatDesignSO.IncreaseDecreaseMultipler, _wheatDesignSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
