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
        // 1～100 固有属性
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



        // 100～200 技能属性 人物状态增益等
        // 当前生命增益
        kHpBuff = 100,
        // 当前生命减益
        kHpReduce = 101,
        // 恢复增益
        kRecoverBuff = 102,
        // 恢复减益
        kRecoveryReduce = 103,
        // 攻击增益
        kAttackBuff = 104,
        // 攻击减益
        kAttackReduce = 105,
        // 防御增益
        kDefenceBuff = 106,
        // 防御减益
        kDefenceReduce = 107,
        // 暴击增益
        kCritBuff = 108,
        // 暴击减益
        kCritReduce = 109,
        // 暴击倍率增益
        kCritMultipleBuff = 110,
        // 暴击倍率减益
        kCritMultipleReduce = 111,
        // 攻击速度增益
        kAttackSpeedBuff = 112,
        // 攻击速度减益
        kAttackSpeedReduce = 113,
        // 移动速度增益
        kMoveSpeedBuff = 114,
        // 移动速度减益
        kMoveSpeedReduce = 115,
        // 技能冷却增益
        kSkillCoolDownBuff = 116,
        // 技能冷却减益
        kSkillCoolDownReduce = 117,
        // 伤害减免
        kDamageReduce = 118,
        // 伤害增益


        // 200 ～ 300 单一状态，没有程度好坏
        kDamageBuff = 200,
        // 不可选中
        kUnselectable = 201,
        // 不可攻击
        kUnattackable = 202,
        // 禁止释放技能
        kForbidSkill = 203,
        // 眩晕
        kDizzy = 204,
  
    }
    #endregion <AgentPropertyType>
    


}
