#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Interface
 * 文件名：ISharedComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:21:24
 * 描述：
 *  此接口多用于存储材质，网格数据,AI数据等通用的数据，比如大量一模一样的丧尸，但是大量模型一样，颜色不一样的丧尸却不行，因为材质数据不一样。
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Ecs.Interface
{
    /// <summary>
    /// 共享数据组件接口
    /// </summary>
    public interface ISharedComponent
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 这可以考虑增加内存映射接口
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
