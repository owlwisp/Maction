#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Interface
 * 文件名：IComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 17:17:20
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Ecs.Interface
{
    /// <summary>
    /// 组件接口
    /// </summary>
    public interface IComponent
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 这可以考虑增加内存映射接口
        public string GetType();
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
