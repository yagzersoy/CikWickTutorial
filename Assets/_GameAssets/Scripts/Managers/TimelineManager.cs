using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private PlayableDirector _playableDirector;
    private void Awake()
    {
        _playableDirector = GetComponent<PlayableDirector>();

    }

    private void OnEnable()
    {
        _playableDirector.Play();

        _playableDirector.stopped += OnTimeLineFinished;
    }

    private void OnTimeLineFinished(PlayableDirector director)
    {
        _gameManager.ChangeGameState(GameState.Play);
    }
}
