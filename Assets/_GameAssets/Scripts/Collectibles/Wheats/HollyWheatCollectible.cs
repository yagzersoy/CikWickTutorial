using UnityEngine;
using UnityEngine.UI;

public class HollyWheatCollectible : MonoBehaviour,ICollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
   [SerializeField] private PlayerController _playerController;
   [SerializeField] private PlayerStateUI _playerStateUI;

private RectTransform _playerBoosterTransform;
    private Image _playerBoosterImage;

    void Awake()
    {
        _playerBoosterTransform = _playerStateUI.GetBoosterJumpTransform;
        _playerBoosterImage = _playerBoosterTransform.GetComponent<Image>();
    }
    
    public void Collect()
    {
        _playerController.SetJumpForce(_wheatDesignSO.IncreaseDecreaseMultipler,_wheatDesignSO.ResetBoostDuration);

        CameraShake.Instance.ShakeCamera(0.5f, 0.5f);
     _playerStateUI.PlayerBoosterUIAnimations(_playerBoosterTransform, _playerBoosterImage,
         _playerStateUI.GetHolyBoosterWheatImage, _wheatDesignSO.ActiveSprite, _wheatDesignSO.PassiveSprite,
         _wheatDesignSO.ActiveWheatSprite, _wheatDesignSO.PassiveWheatSprite, _wheatDesignSO.ResetBoostDuration);

        AudioManager.Instance.Play(SoundType.PickupGoodSound);
        Destroy(gameObject);
    }
}
