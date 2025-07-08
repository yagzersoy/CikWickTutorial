using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [Header("References")]
    [SerializeField] private EggCounterUI _eggCounterUI;


    [Header("Settings")]
    [SerializeField] private int _maxEggCount = 5;

    private int _currentEggCount;

    void Awake()
    {
        Instance = this;
    }
    public void OneEggCollected()
    {

        _currentEggCount++;

        _eggCounterUI.SetEggCounterText(_currentEggCount, _maxEggCount);

        if (_currentEggCount == _maxEggCount)
        {
            //WİN
            Debug.Log("Game Win");
            _eggCounterUI.SetEggCompleted();

        }
        Debug.Log("Egg Count: " + _currentEggCount);
    }
}
