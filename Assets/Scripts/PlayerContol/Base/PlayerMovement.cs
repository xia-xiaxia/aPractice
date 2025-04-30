using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMovement : MonoBehaviour
{

    public float speed; // 玩家移动速度
    private DashSkill dashSkill; // 冲刺技能引用
    public Vector3 moveDirection; // 玩家移动方向

    void Start()
    {
        if (PlayerData.instance != null)
        {
            speed = PlayerData.instance.speed;
        }
        else
        {
            Debug.LogError("PlayerData.instance is null. Please ensure it is initialized.");
        }

        dashSkill = GetComponent<DashSkill>();
    }

    void Update()
    {
        MovePlayer();
        HandleDashInput();
    }

    void MovePlayer()
    {
        // 获取水平和垂直方向的输入
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 计算移动方向
        Vector3 movement = new Vector3(horizontal, vertical, 0f);

        moveDirection = new Vector3(horizontal, vertical, 0f).normalized; 

        // 根据速度调整移动量，并将其应用到玩家位置
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    // 冲刺技能的调用
    void HandleDashInput()
    {
        // 检测玩家是否按下冲刺键（例如左Shift键）
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }
    }

    public void Dash()
    {
        if (dashSkill != null && dashSkill.CanCast())
        {
            dashSkill.GetDir(moveDirection);
            dashSkill.TryCast(this); 
        }
    }


}
