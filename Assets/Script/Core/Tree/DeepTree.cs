#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Code.Tree
 * 文件名：DeepTree
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 17:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Code.Tree
{
    /// <summary>
    /// 深度树
    /// </summary>
    public class DeepTree 
    {
        #region <属性>
        // 拥有者id，这里不想采用闭包的方式，所以用int
        private int m_ownerId;

        private bool m_tickEnable;
        // 获取目标函数
        public GetDeepTreeAgentDelegate m_delegate;
        // 根节点
        private DeepTreeNode m_root;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(IDeepTreeAgent target){
            m_tickEnable = false;
            m_ownerId = target.GetDeepTreeAgentId();
            m_delegate = target.GetDeepTreeAgent();
            m_root = new DeepTreeNode();
            m_root.OnInit(this);
        }

        public IDeepTreeAgent GetOwner(){
            return m_delegate(m_ownerId);
        }

        // 遍历结点
        public void Tick(){
            if(m_tickEnable){
                m_root.Tick();
            }
        }

        // 执行深度树
        public void Execute(){
            m_root.Execute();
            m_tickEnable = true;
        }

        // 中断效果
        public void Interrupt(){
            m_tickEnable = false;
            m_root.Interrupt();
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
