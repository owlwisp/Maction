#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：StatusComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 15:9:4
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// 状态组件
    /// </summary>
    public class StatusComponent : BaseComponent
    {
        #region <属性>
        // 血量
        
        #endregion <属性>
        #region <方法>
        public new string GetType(){
            return "StatusComponent";
        }
        #endregion <方法>
    }
}
