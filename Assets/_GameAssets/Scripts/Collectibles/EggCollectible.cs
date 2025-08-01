using UnityEngine;

public class EggCollectible : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        CameraShake.Instance.ShakeCamera(0.5f, 0.5f);
        GameManager.Instance.OneEggCollected();
        AudioManager.Instance.Play(SoundType.PickupGoodSound);
        Destroy(gameObject);
    }
}
