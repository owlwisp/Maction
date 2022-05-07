#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Condition.Base
 * 文件名：LevelEffectCondition
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/6 11:36:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Code.Tree;
using Assets.Script.Core.Container;
using Assets.Script.Engine.Agent;

namespace Assets.Script.Engine.Effect.Condition.Base
{
    /// <summary>
    /// 判断目标等级
    /// </summary>
    public class LevelEffectCondition : EffectConditionBase
    {
        #region <属性>
        // 阵营
        private int m_level;
        
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            Type = EffectConditionType.kLevel;
        }

  
        public bool IsTrue(IDeepTreeAgent owner)
        {
            EffectBase effect = owner as EffectBase;
            AgentBase target = Container<AgentBase>.Instance.Get(effect.TargetId);

            return AgentBase.IsValid(target) && target.Level >= m_level;
        }
        
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
