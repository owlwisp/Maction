#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Node.Base
 * 文件名：AttackEffectNode
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 16:18:29
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Code.Tree;
using Assets.Script.Core.Pool;
using Assets.Script.Engine.Agent;
using Assets.Script.Engine.Formula;

namespace Assets.Script.Engine.Effect.Node.Base
{
    /// <summary>
    /// effect 攻击结点
    /// </summary>
    public class AttackEffectNode : EffectNodeBase
    {
        #region <属性>
        // 按照百分比算
        public int Rate { get; set; }
        private int m_attack;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit()
        {
            Type = EffectNodeType.kAttack;
        }

        public override void Execute(IDeepTreeAgent owner)
        {
            base.Execute(owner);

            var effect = owner as EffectBase;
            var agent = Container<AgentBase>.Instance.Get(effect.OwnerId);
            if (owner == null)
            {
                return;
            }
            var property = agent.GetProperty(AgentPropertyType.kAttack);
            m_attack = property.Value * Rate;
        }
        public override void DoAction(IDeepTreeAgent owner)
        {
            var effect = owner as EffectBase;
            var target = Container<AgentBase>.Instance.Get(effect.TargetId);
            if (target == null)
            {
                return;
            }

            var defenderData = target.GetDamageDataForDefender();
            var attackerData = MPool<DamageData>.Instance.Get();
            attackerData.AddProperty(AgentPropertyType.kAttack,m_attack);
            
            // todo:这里有待商榷
            var damage = DamageFormula.Calculations( attackerData, defenderData);
            target.AddProperty(AgentPropertyType.kHp, -damage);
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
