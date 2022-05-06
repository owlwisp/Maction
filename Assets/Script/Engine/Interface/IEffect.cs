#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Internal
 * 文件名：ICondition
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 13:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Internal
{
    /// <summary>
    /// effect接口
    /// </summary>
    public interface IEffect
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
 
        public void Execute();
        // 启用
        public void OnEnable();
        // 禁用
        public void OnDisable();
        // 中断处理
        public void Interrupt();
        // 按帧更新
        public void Tick();
  
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
