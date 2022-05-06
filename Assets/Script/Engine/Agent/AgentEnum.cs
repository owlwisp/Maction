#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Agent
 * 文件名：EffectEnum
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 14:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Agent
{
    /// <summary>
    /// agent 阵营
    /// </summary>
    #region <AgentCampType>
    public enum AgentCampType
    {
        // 己方
        kSelf = 0,
        // 敌方
        kEnemy = 1,
        // 中立
        kNeutral = 2,
        
    }
    #endregion <AgentCampType>

    /// <summary>
    /// agent 状态
    /// </summary>
    #region <AgentStateType>
    public enum AgentStateType
    {
        // 死亡
        kDead = 0,
        // 活着
        kAlive = 1,
        // 临死
        kDying = 2,
        // 未知
        kUnknow = 3,
        
    }
    #endregion <AgentStateType>


    /// <summary>
    /// agent 属性 id
    /// </summary>
    #region <AgentPropertyType>
    public enum AgentPropertyType
    {
        // 生命
        kHp = 1,
        // 最大生命
        kHpMax = 2,
        // 攻击
        kAttack = 3,
        // 防御
        kDefence = 4,
        // 攻击速度
        kAttackSpeed = 5,
        // 魔法
        kMagic = 6,
        // 最大魔法
        kMagicMax = 7,
        // 暴击率
        kCrit = 8,
        // 暴击倍率
        kCritMultiple = 9,
        // 移动速度
        kMoveSpeed = 10,




       
        
    }
    #endregion <AgentPropertyType>
    


}
