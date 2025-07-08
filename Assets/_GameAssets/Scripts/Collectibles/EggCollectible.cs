using UnityEngine;

public class EggCollectible : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        GameManager.Instance.OneEggCollected();
        Destroy(gameObject);
    }
}
