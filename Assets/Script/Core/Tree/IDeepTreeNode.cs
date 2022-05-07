#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Code.Tree
 * 文件名：IDeepTreeNode
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 17:39:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using static Assets.Script.Code.Tree.DeepTree;

namespace Assets.Script.Code.Tree
{
 /// <summary>
    /// 深度树之行节点
    /// </summary>
    public interface IDeepTreeNode
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void Execute(IDeepTreeAgent owner);
        // 是否需要tick
        public bool IsTick();
        // 遍历结点
        public  void Tick(IDeepTreeAgent owner);
        // 中断技能
        public void Interrupt(IDeepTreeAgent owner);

        // 设置完成回调函数
        public void SetCompleteDelegate(DeepTreeCompleteDelegate completeDelegate);
  
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
