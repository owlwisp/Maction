#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Condition
 * 文件名：SelfCampEffectCondition
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/6 11:36:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Effect.Condition
{
    /// <summary>
    /// 判断是否是自己阵营的
    /// </summary>
    public class SelfCampEffectCondition : EffectConditionBase
    {
        #region <属性>
        // 阵营
        private CampType m_campType;
        
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            Type = EffectConditionType.SelfCamp;
            var owner = Container<ActionBase>.Instance.Get(owner.OwnerId);
            if (owner != null)
            {
                m_campType = owner.CampType;
            }
        }
  
        public bool IsTrue(IDeepTreeAgent owner)
        {
            var target = Container<ActionBase>.Instance.Get(owner.TargetId);

            return AgentBase.IsValid(target) && target.IsSameCamp(m_campType);
        }
        
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
