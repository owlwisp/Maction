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
        
        kNpc = 0,
        kPlayer = 1,
        
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


    #region <EffectMergeType>
    /// <summary>
    /// effect 合并方式
    /// </summary>
    public enum EffectMergeType
    {
        // 重置
        kReset = 0,
        // 叠加
        kAdd = 1,
        // 互斥
        kExclusive = 2,
    }   
    #endregion <EffectMergeType>
}
