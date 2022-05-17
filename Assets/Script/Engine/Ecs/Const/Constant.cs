#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Formula
 * 文件名：Constants
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 16:49:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Const
{
    /// <summary>
    /// system 类型
    /// </summary>
    public enum SystemType 
    {
        #region <属性>
        kNone = 0,
        // 输入事件系统
        kGameInputSystem = 1,

        #endregion <属性>
    }
    /// <summary>
    /// system 类型
    /// </summary>
    public enum BattleResultType 
    {
        #region <属性>
        kNone = 0,
        // 成功
        kSuccess = 1,

        // 失败
        kFail = 2,


        #endregion <属性>
    }


    /// <summary>
    /// 战斗状态枚举
    /// </summary>
    public enum BattleStatus{
            // 默认状态
            kNone = 0,
            // 战斗状态
            kBattle,
            // 等待渲染状态
            kWaitRender,
            // 战斗结果状态
            kBattleResult,
            // 战斗完成状态
            kFinish
        }
}
