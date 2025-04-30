using Unity.VisualScripting;
using UnityEngine;

public abstract class Skill<T> : MonoBehaviour where T : MonoBehaviour
{
    public float coolDown = 1.0f;
    private float lastUsedTime = -Mathf.Infinity;

    public bool CanCast()
    {
        return Time.time >= lastUsedTime + coolDown;
    }

    public void TryCast(T owner)
    {
        if (CanCast())
        {
            lastUsedTime = Time.time;
            OnCast(owner);
        }
        else
            Debug.Log("{GetType().Name} ‘⁄¿‰»¥£¨ £”‡¿‰»¥ ±º‰£∫{Mathf.Ceil(lastUsedTime + coolDown - Time.time)}√Î");
    }

    protected abstract void OnCast(T owner);
}
