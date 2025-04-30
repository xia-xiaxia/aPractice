using Unity.VisualScripting;
using UnityEngine;

public class DashSkill : Skill<PlayerMovement>
{
    
    // 定义冲刺距离
    public float dashDistance;
    // 定义冲刺速度
    public float dashSpeed;

    private Vector3 dashDirection;

    public void GetDir(Vector3 dir)
    {
        dashDirection = dir;
    }

    // 实现抽象方法 OnCast
    protected override void OnCast(PlayerMovement owner)
    {
        // 获取玩家的 Transform
        Transform playerTransform = owner.transform;

        // 计算冲刺目标位置
        Vector3 dashTarget = playerTransform.position + dashDirection * dashDistance;

        // 更新玩家位置
        playerTransform.position = dashTarget;

        // 可以在这里添加粒子效果或声音效果
        Debug.Log("Dash skill casted!");
    }
}
