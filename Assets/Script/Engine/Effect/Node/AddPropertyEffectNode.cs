#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Node
 * 文件名：EAddPropertyEffectNode
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 11:32:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Effect.Node
{
    /// <summary>
    /// effect 执行结点基类
    /// </summary>
    public class AddPropertyEffectNode : EffectNodeBase
    {
        #region <属性>
        
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            Type = EffectNpcType.AddProperty;

        }
  
        public void DoAction(IDeepTreeAgent owner)
        {
            var target = Container<ActionBase>.Instance.Get(owner.TargetId);
            if (target == null)
            {
                return;
            }

            
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
