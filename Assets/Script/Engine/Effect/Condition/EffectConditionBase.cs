#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Condition
 * 文件名：EffectConditionBase
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 16:3:21
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Code.Tree;
using Assets.Script.Engine.Internal;

namespace Assets.Script.Engine.Effect.Condition
{
    /// <summary>
    /// effect 执行条件基类
    /// </summary>
    public class EffectConditionBase : ICondition , IDeepTreeCondition
    {
        #region <属性>
        // 类型
        public EffectConditionType Type { get; set; }
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            Type = EffectConditionType.kNone;
        }

        public void Execute(IDeepTreeAgent owner)
        {

        }

        // 获取类型
        public EffectConditionType GetType()
        {
            return Type;
        }
    
        public bool IsTrue(IDeepTreeAgent owner)
        {
            return false;
        }



        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
