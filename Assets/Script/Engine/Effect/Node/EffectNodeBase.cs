#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Node
 * 文件名：EffectNodeBase
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 14:32:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Effect.Node
{
    /// <summary>
    /// effect 执行结点基类
    /// </summary>
    public class EffectNodeBase : INode , IDeepTreeNode
    {
        #region <属性>
        // 类型
        public EffectNodeType Type { get; set; }
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit();

        // 获取类型
        public EffectNodeType GetType()
        {
            return Type;
        }
        public void DoAction(IDeepTreeAgent owner)
        {

        }

        public void Tick(IDeepTreeAgent owner){

        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
