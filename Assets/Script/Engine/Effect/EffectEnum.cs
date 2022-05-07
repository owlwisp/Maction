#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect
 * 文件名：EffectEnum
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 14:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Effect
{
    /// <summary>
    /// effect 来源类型
    /// </summary>
    #region <EffectSourceType>
    public enum EffectSourceType
    {

        kNone = 0,
        kNpc = 1,
        kPlayer = 2,
        
    }
    #endregion <EffectSourceType>

    #region <EffectType>
    /// <summary>
    /// effect 类型
    /// </summary>
    public enum EffectType
    {
        kBuff = 0,
        kDebuff = 1,
        kStatic = 2,
        
    }
    #endregion <EffectType>


    #region <EffectResetType>
    /// <summary>
    /// effect 相同模版id处理方式
    /// </summary>
    public enum EffectResetType
    {
        kNone = 0,
        // 重置
        kReset = 1,
        // 叠加
        kAppend = 2,
    }   
    #endregion <EffectResetType>

    #region <EffectMergeType>
    /// <summary>
    /// effect 合并方式
    /// </summary>
    public enum EffectMergeType
    {
        kNone = 0,
        // 重置
        kReset = 1,
        // 叠加
        kAdd = 2,
        // 互斥
        kExclusive = 3,
    }   
    #endregion <EffectMergeType>


    #region <EffectConditionType>
    /// <summary>
    /// effect condition 类型
    /// </summary>
    public enum EffectConditionType
    {
        kNone = 0,
        // 相同阵营
        kSelfCamp = 1,
        // 等级
        kLevel = 2,

  
    }   
    #endregion <EffectConditionType>

    #region <EffectNodeType>
    /// <summary>
    /// effect 执行结点类型
    /// </summary>
    public enum EffectNodeType
    {
        kNone = 0,
        // 增加属性
        kAddProperty = 1,
        // 造成攻击伤害
        kAttack = 2,
        // 嘲讽
        kTaunt = 3,

    }   
    #endregion <EffectNodeType>
    
}
