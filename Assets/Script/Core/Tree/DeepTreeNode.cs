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

        DeepTree m_tree;
        IDeepTreeNode m_node;
        IDeepTreeCondition m_condition;
        List<DeepTreeNode> m_children;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(DeepTree tree){
            m_tree = tree;
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
        public void Execute(){
            if (IsConditionNode)
            {
                if (m_condition.IsTrue(m_tree.GetOwner()))
                {
                    foreach (var child in m_children)
                    {
                        child.Execute(m_tree.GetOwner());
                    }
                }
            }
            else
            {
                m_node.Execute(m_tree.GetOwner());
            }
        }

        // 中断结点
        public void Interrupt(){
            if (IsConditionNode)
            {
                foreach (var child in m_children)
                {
                    child.Interrupt(m_tree.GetOwner());
                }
            }
            else
            {
                m_node.Interrupt(m_tree.GetOwner());
            }
        }

        // 遍历结点
        public void Tick(){
            if (IsConditionNode)
            {
                if (m_condition.IsTrue(m_tree.GetOwner()))
                {
                    foreach (var child in m_children)
                    {
                        if (child.IsTick())
                        {
                            child.Tick(m_tree.GetOwner());
                        }
                    }
                }
            }
            else{
                if (m_node.IsTick())
                {
                    m_node.Tick(m_tree.GetOwner());
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
