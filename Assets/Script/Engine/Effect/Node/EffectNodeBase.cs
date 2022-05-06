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
        // 执行次数
        int Count { get; set; }
        // 延迟时间
        int Delay { get; set; }

        // 当前次数
        int m_currentCount;
        // 当前时间
        int m_currentDelay ;

        bool m_isTick;
        // 是否开启时间遍历

        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){


            m_tick = Count != 0;
            Type = EffectNodeType.kNone;
        }

        // 获取类型
        public EffectNodeType GetType()
        {
            return Type;
        }

        public virtual void Execute(IDeepTreeAgent owner)
        {
            m_currentCount = Count;
            m_currentDelay = Delay;
        }
        // 中断
        public virtual void Interrupt(IDeepTreeAgent owner)
        {
            m_currentCount = 0;
            m_currentDelay = 0;
        }

        public virtual void DoAction(IDeepTreeAgent owner)
        {

        }

        public virtual bool IsTick()
        {
            return m_tick;
        }
        public virtual void Tick(IDeepTreeAgent owner)
        {
            if (m_currentCount > 0 || m_currentCount == -1)
            {
                m_currentDelay -= 1;

                if (m_currentDelay <= 0)
                {
                    DoAction(owner);
                    m_currentDelay = Delay;
                    if(m_currentCount > 0 ){
                        m_currentCount -= 1;
                    }
                }
            }
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
