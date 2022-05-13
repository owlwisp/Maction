#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.System.Logic
 * 文件名：TargetSystem
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:2:3
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Core;

namespace Assets.Script.Engine.Ecs.System.Logic
{
    /// <summary>
    /// 目标系统
    /// </summary>
    public class TargetSystem : BaseSystem
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 处理游戏输入
        public void ProcessAction(InputAction action){
            
        }

        public string GetType()
        {
            return "TargetSystem";
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
