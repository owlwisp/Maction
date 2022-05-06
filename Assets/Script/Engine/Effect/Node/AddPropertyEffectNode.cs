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
        // 属性
        public AgentPropertyType Property { get; set; }
        public int Value { get; set; }

        // 增加属性次数
        public int m_count ;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit()
        {
            Type = EffectNpcType.AddProperty;
        }

        public override void Execute(IDeepTreeAgent owner)
        {
            base.Execute(owner);
            m_count = 0;
        }
        public override void DoAction(IDeepTreeAgent owner)
        {
            var target = Container<ActionBase>.Instance.Get(owner.TargetId);
            if (target == null)
            {
                return;
            }
            m_count += 1;
            target.AddProperty(Property, Value);
        }

        
        public override Interrupt(IDeepTreeAgent owner)
        {
            base.Interrupt(owner);
            var target = Container<ActionBase>.Instance.Get(owner.TargetId);
            if (target == null)
            {
                return;
            }
            target.AddProperty(Property, -Value * m_count );
            m_count = 0;
        }
        
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
