#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Node.Base
 * 文件名：TauntEffectNode
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 18:8:29
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Code.Tree;

namespace Assets.Script.Engine.Effect.Node.Base
{
    /// <summary>
    /// effect 嘲讽
    /// </summary>
    public class TauntEffectNode : EffectNodeBase
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit()
        {
            Type = EffectNodeType.kTaunt;
        }

        public override void Execute(IDeepTreeAgent owner)
        {
            base.Execute(owner);

  
        }
        public override void DoAction(IDeepTreeAgent owner)
        {

        }
        
        public override void Interrupt(IDeepTreeAgent owner)
        {
            base.Interrupt(owner);
        }
        
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
