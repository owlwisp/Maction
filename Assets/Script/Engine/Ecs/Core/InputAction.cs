#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core
 * 文件名：InputAction
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/13 11:37:44
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Const;

namespace Assets.Script.Engine.Ecs.Core
{
    /// <summary>
    /// 输入action
    /// </summary>
    public class InputAction
    {
        #region <属性>
        // 处理系统  这里不知道是否需要多系统处理， 如果需要可以考虑变成list 活着放到unitily中去处理
        public SystemType Type = SystemType.kGameInputSystem;


        #endregion <属性>

        #region <方法>

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
