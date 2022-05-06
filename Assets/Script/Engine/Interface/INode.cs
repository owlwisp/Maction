#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Internal
 * 文件名：INode
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 13:27:20
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Code.Tree;
using Assets.Script.Engine.Effect;

namespace Assets.Script.Engine.Internal
{
    /// <summary>
    /// 行动结点
    /// </summary>
    public interface INode
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 获取类型
        public EffectNodeType GetType();
        public void DoAction(IDeepTreeAgent owner);
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
