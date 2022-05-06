#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Code.Tree
 * 文件名：IDeepTreeAgent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/6 11:39:33
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System;

namespace Assets.Script.Code.Tree
{
    
    /// <summary>
    /// 深度树之行节点
    /// </summary>
    public interface IDeepTreeAgent
    {
        #region <属性>
        public delegate IDeepTreeAgent GetDeepTreeAgentDelegate(int id);
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public int GetDeepTreeAgentId();
        public GetDeepTreeAgentDelegate GetDeepTreeAgent();
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
