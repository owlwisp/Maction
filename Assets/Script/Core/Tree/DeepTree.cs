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



using static Assets.Script.Code.Tree.IDeepTreeAgent;

namespace Assets.Script.Code.Tree
{
    /// <summary>
    /// 深度树
    /// </summary>
    public class DeepTree 
    {
        #region <属性>
        public delegate void DeepTreeCompleteDelegate();

        // 拥有者id，这里不想采用闭包的方式，所以用int
        private int _ownerId;

        private bool _tickEnable;
        // 获取目标函数
        public GetDeepTreeAgentDelegate _delegate;
        // 根节点
        private DeepTreeLeaf _root;
        // 结束回调函数
        private DeepTreeCompleteDelegate _completeDelegate;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(IDeepTreeAgent target, DeepTreeCompleteDelegate completeDelegate){
            _tickEnable = false;
            _ownerId = target.GetDeepTreeAgentId();
            _delegate = target.GetDeepTreeAgent();
            _completeDelegate = completeDelegate;
            _root = new DeepTreeLeaf();
            _root.OnInit( _completeDelegate);
        }

        public IDeepTreeAgent GetOwner(){
            return _delegate( _ownerId);
        }

        // 遍历结点
        public void Tick(){
            if(_tickEnable){
                _root.Tick(GetOwner());
            }
        }

        // 执行深度树
        public void Execute(){
            _root.Execute(GetOwner());
            _tickEnable = true;
        }

        // 中断效果
        public void Interrupt(){
            _tickEnable = false;
            _root.Interrupt(GetOwner());
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
