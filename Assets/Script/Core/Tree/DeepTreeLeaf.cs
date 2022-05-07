#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Code.Tree
 * 文件名：DeepTreeLeaf
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 17:39:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System.Collections.Generic;
using static Assets.Script.Code.Tree.DeepTree;

namespace Assets.Script.Code.Tree
{
 /// <summary>
    /// 深度树叶子
    /// </summary>
    public class DeepTreeLeaf
    {
        #region <属性>
        // 是否是条件节点
        public bool IsConditionNode { get; set; }
   
        IDeepTreeNode m_node;

        IDeepTreeCondition m_condition;
        List<DeepTreeLeaf> m_children;
        //已经完成的结点个数
        int m_completeCount;

        // 结束回调
        DeepTreeCompleteDelegate m_completeDelegate;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(DeepTreeCompleteDelegate completeDelegate = null){
            IsConditionNode = false;
            m_completeDelegate = completeDelegate;
        }

        // 增加子结点   
        public void AddChild(DeepTreeLeaf node){
            m_children.Add(node);
            node.SetCompleteDelegate(delegate {
                m_completeCount += 1;
                if(m_completeCount == m_children.Count){
                    m_completeDelegate();
                }
            });
            IsConditionNode = true;
        }

        // 设置条件
        public void SetCondition(IDeepTreeCondition condition){
            m_condition = condition;
            IsConditionNode = true;

            if(m_children == null){
                m_children = new List<DeepTreeLeaf>();
            }
        }
        // 设置结点
        public void SetNode(IDeepTreeNode node){
            m_node = node;
            IsConditionNode = false;
            m_children.Clear();
            m_children = null ;
            
            m_node.SetCompleteDelegate(m_completeDelegate);
        }
        // 设置完成回调函数
        public void SetCompleteDelegate(DeepTreeCompleteDelegate completeDelegate){
            m_completeDelegate = completeDelegate;
        }
 
        // 执行结点
        public void Execute(IDeepTreeAgent owner)
        {
            m_completeCount = 0;
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

        public void Complete(){
            if (IsConditionNode)
            {
                m_completeDelegate();
            }
            else{
                if (m_completeDelegate != null)
                {
                    m_completeDelegate();
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
