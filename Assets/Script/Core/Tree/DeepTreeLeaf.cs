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
   
        IDeepTreeNode _node;

        IDeepTreeCondition _condition;
        List<DeepTreeLeaf> _children;
        //已经完成的结点个数
        int _completeCount;

        // 结束回调
        DeepTreeCompleteDelegate _completeDelegate;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(DeepTreeCompleteDelegate completeDelegate = null){
            IsConditionNode = false;
            _completeDelegate = completeDelegate;
        }

        // 增加子结点   
        public void AddChild(DeepTreeLeaf node){
            _children.Add(node);
            node.SetCompleteDelegate(delegate {
                _completeCount += 1;
                if( _completeCount == _children.Count){
                    _completeDelegate();
                }
            });
            IsConditionNode = true;
        }

        // 设置条件
        public void SetCondition(IDeepTreeCondition condition){
            _condition = condition;
            IsConditionNode = true;

            if( _children == null){
                _children = new List<DeepTreeLeaf>();
            }
        }
        // 设置结点
        public void SetNode(IDeepTreeNode node){
            _node = node;
            IsConditionNode = false;
            _children.Clear();
            _children = null ;
            
            _node.SetCompleteDelegate( _completeDelegate);
        }
        // 设置完成回调函数
        public void SetCompleteDelegate(DeepTreeCompleteDelegate completeDelegate){
            _completeDelegate = completeDelegate;
        }
 
        // 执行结点
        public void Execute(IDeepTreeAgent owner)
        {
            _completeCount = 0;
            if (IsConditionNode)
            {
                if ( _condition.IsTrue(owner))
                {
                    foreach (var child in _children)
                    {
                        child.Execute(owner);
                    }
                }
            }
            else
            {
                _node.Execute(owner);
            }
        }

        // 中断结点
        public void Interrupt(IDeepTreeAgent owner)
        {
            if (IsConditionNode)
            {
                foreach (var child in _children)
                {
                    child.Interrupt(owner);
                }
            }
            else
            {
                _node.Interrupt(owner);
            }
        }

        // 遍历结点
        public void Tick(IDeepTreeAgent owner)
        {
            if (IsConditionNode)
            {
                if ( _condition.IsTrue(owner))
                {
                    foreach (var child in _children)
                    {
                        child.Tick(owner);
                    }
                }
            }
            else{
                if ( _node.IsTick())
                {
                    _node.Tick(owner);
                }
            }
        }

        public void Complete(){
            if (IsConditionNode)
            {
                _completeDelegate();
            }
            else{
                if ( _completeDelegate != null)
                {
                    _completeDelegate();
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
