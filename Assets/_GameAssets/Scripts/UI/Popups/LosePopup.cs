using MaskTransitions;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePopup : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private Button _tryAgainButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private TimerUI _timerUI;
    private void OnEnable()
    {
        AudioManager.Instance.Play(SoundType.LoseSound);
        BackgroundMusic.Instance.PlayBackgroundMusic(false);
        _timerText.text = _timerUI.GetFinalTime();

        _tryAgainButton.onClick.AddListener(OneTryAgainButtonClicked);

        _mainMenuButton.onClick.AddListener(() =>
        {
            AudioManager.Instance.Play(SoundType.TransitionSound);
             TransitionManager.Instance.LoadLevel(Consts.SceneNames.MENU_SCENE);
         });
    }

    private void OneTryAgainButtonClicked()
    {
        AudioManager.Instance.Play(SoundType.TransitionSound);
        TransitionManager.Instance.LoadLevel(Consts.SceneNames.GAME_SCENE);

    }
}
