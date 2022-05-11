#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component
 * 文件名：BaseComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 16:57:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Component
{
    /// <summary>
    /// 组件基类
    /// </summary>
    public struct BaseComponent : IComponent
    {
        #region <属性>
        //唯一id
        public int Id { get; set; }
        // 归属的entity的id
        public int EntityId { get; set; }
        
        #endregion <属性>

        #region <方法>
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
