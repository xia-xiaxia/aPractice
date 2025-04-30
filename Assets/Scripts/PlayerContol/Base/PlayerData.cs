using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance; // 单例实例

    public float health = 100f; // 玩家生命值
    public float speed = 5f; // 玩家移动速度


    void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject); 

    }

    void Update()
    {
        
    }
}
