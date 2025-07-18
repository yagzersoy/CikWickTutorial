using UnityEngine;
using UnityEngine.UI;

public class RottenWheatCollectectible : MonoBehaviour,ICollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
 [SerializeField] private PlayerController _playerController;
  
  [SerializeField] private PlayerStateUI _playerStateUI;

private RectTransform _playerBoosterTransform;
    private Image _playerBoosterImage;

    void Awake()
    {
        _playerBoosterTransform = _playerStateUI.GetBoosterSlowTransform;
        _playerBoosterImage = _playerBoosterTransform.GetComponent<Image>();
    }
    

    public void Collect()
    {
        CameraShake.Instance.ShakeCamera(0.5f, 0.5f);
        _playerController.SetMovementSpeed(_wheatDesignSO.IncreaseDecreaseMultipler, _wheatDesignSO.ResetBoostDuration);
        _playerStateUI.PlayerBoosterUIAnimations(_playerBoosterTransform, _playerBoosterImage,
                 _playerStateUI.GetRottenBoosterWheatImage, _wheatDesignSO.ActiveSprite, _wheatDesignSO.PassiveSprite,
                 _wheatDesignSO.ActiveWheatSprite, _wheatDesignSO.PassiveWheatSprite, _wheatDesignSO.ResetBoostDuration);

        Destroy(gameObject);
    }
}
