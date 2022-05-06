#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Internal
 * 文件名：ICondition
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 15:23:10
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Code.Tree;
using Assets.Script.Engine.Effect;

namespace Assets.Script.Engine.Internal
{
    /// <summary>
    /// 条件接口
    /// </summary>
    public interface ICondition
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
 
        public bool IsTrue(IDeepTreeAgent owner);

        public void Execute(IDeepTreeAgent owner);
        // 获取类型
        public EffectConditionType GetType();
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
