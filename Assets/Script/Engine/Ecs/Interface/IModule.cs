#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Interface
 * 文件名：IModule
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:38:21
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Engine.Ecs.Core.Module;

namespace Assets.Script.Engine.Ecs.Interface
{
    /// <summary>
    /// 组件接口
    /// </summary>
    public interface IModule
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init();
        // 销毁
        public void Dispose();
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
