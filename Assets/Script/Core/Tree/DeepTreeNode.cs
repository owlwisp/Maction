#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Code.Tree
 * 文件名：DeepTreeNode
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 17:39:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System.Collections.Generic;

namespace Assets.Script.Code.Tree
{
 /// <summary>
    /// 深度树结点
    /// </summary>
    public class DeepTreeNode
    {
        #region <属性>
        // 是否是条件节点
        public bool IsConditionNode { get; set; }

        IDeepTreeNode m_node;
        IDeepTreeCondition m_condition;
        List<DeepTreeNode> m_children;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            IsConditionNode = false;
        }

        // 增加子结点   
        public void AddChild(DeepTreeNode node){
            
            if(m_children == null){
                m_children = new List<DeepTreeNode>();
            }
            m_children.Add(node);
            IsConditionNode = true;
        }

        // 执行结点
        public void Execute(IDeepTreeAgent owner)
        {
            if (IsConditionNode)
            {
                if (m_condition.IsTrue(owner))
                {
                    foreach (var child in m_children)
                    {
                        child.Execute(owner);
                    }
                }
            }
            else
            {
                m_node.Execute(owner);
            }
        }

        // 中断结点
        public void Interrupt(IDeepTreeAgent owner)
        {
            if (IsConditionNode)
            {
                foreach (var child in m_children)
                {
                    child.Interrupt(owner);
                }
            }
            else
            {
                m_node.Interrupt(owner);
            }
        }

        // 遍历结点
        public void Tick(IDeepTreeAgent owner)
        {
            if (IsConditionNode)
            {
                if (m_condition.IsTrue(owner))
                {
                    foreach (var child in m_children)
                    {
                        child.Tick(owner);
                    }
                }
            }
            else{
                if (m_node.IsTick())
                {
                    m_node.Tick(owner);
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
