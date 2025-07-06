using System.IO.Enumeration;
using UnityEngine;
[CreateAssetMenu(fileName = "WheatDesignSO", menuName = "ScriptableObjects/WheatDesignSO")]
public class WheatDesignSO : ScriptableObject
{
    [SerializeField] private float _increaseDecreaseMultipler;
    [SerializeField] private float _resetBoostDuration;

    [SerializeField] private Sprite _activeSprite;
    [SerializeField] private Sprite _passiveSprite;
    [SerializeField] private Sprite _activeWheatSprite;
    [SerializeField] private Sprite _passiveWheatSprite;


    public float IncreaseDecreaseMultipler => _increaseDecreaseMultipler;
    public float ResetBoostDuration => _resetBoostDuration;

    public Sprite ActiveSprite => _activeSprite;
    public Sprite PassiveSprite => _passiveSprite;

    public Sprite ActiveWheatSprite => _activeWheatSprite;
    public Sprite PassiveWheatSprite => _passiveWheatSprite;
}
