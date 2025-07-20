using UnityEngine;

public class CatAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _catAnimator;
    private CatStateController _catStateController;

    private void Awake()
    {
        _catStateController = GetComponent<CatStateController>();
    }

    private void Update()
    {
        SetCatAnimations();
        if (GameManager.Instance.GetCurrentGameState() != GameState.Play &&
        GameManager.Instance.GetCurrentGameState() != GameState.Resume
        &&GameManager.Instance.GetCurrentGameState()!=GameState.CutScene
        &&GameManager.Instance.GetCurrentGameState()!=GameState.GameOver)
        {
            _catAnimator.enabled = false;
            return;
        }
    }

    private void SetCatAnimations()
    {
        _catAnimator.enabled = true;
        var currentCatState = _catStateController.GetCurrentState();

        switch (currentCatState)
        {
            case CatState.Idle:
                _catAnimator.SetBool(Consts.CatAnimations.IS_IDLING, true);
                _catAnimator.SetBool(Consts.CatAnimations.IS_WALKING, false);
                _catAnimator.SetBool(Consts.CatAnimations.IS_RUNNING, false);
                break;
            case CatState.Walking:
                _catAnimator.SetBool(Consts.CatAnimations.IS_IDLING, false);
                _catAnimator.SetBool(Consts.CatAnimations.IS_WALKING, true);
                _catAnimator.SetBool(Consts.CatAnimations.IS_RUNNING, false);
                break;
            case CatState.Running:
                _catAnimator.SetBool(Consts.CatAnimations.IS_RUNNING, true);
                break;
                case CatState.Attacking:
                _catAnimator.SetBool(Consts.CatAnimations.IS_ATTACKING, true);
                break;
                
        }
    }
}
