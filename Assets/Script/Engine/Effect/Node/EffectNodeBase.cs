#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect.Node
 * 文件名：EffectNodeBase
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 14:32:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Code.Tree;
using Assets.Script.Engine.Internal;
using static Assets.Script.Code.Tree.DeepTree;

namespace Assets.Script.Engine.Effect.Node
{
    /// <summary>
    /// effect 执行结点基类
    /// </summary>
    public class EffectNodeBase : INode , IDeepTreeNode
    {
        #region <属性>
        // 类型
        public EffectNodeType Type { get; set; }
        // 执行次数
        int Count { get; set; }
        // 延迟时间
        int Delay { get; set; }

        // 当前次数
        int _currentCount;
        // 当前时间
        int _currentDelay ;
        // 是否开启时间遍历
        bool _isTick;

        // 结束
        bool _isFinish;
        // 完成回调函数
        DeepTreeCompleteDelegate _completeDelegate;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){

            _isTick = Count != 0;
            Type = EffectNodeType.kNone;
        }

        // 获取类型
        public new EffectNodeType GetType()
        {
            return Type;
        }

        // 设置完成回调函数
        public void SetCompleteDelegate(DeepTreeCompleteDelegate completeDelegate)
        {
            _completeDelegate = completeDelegate;
        }
        public virtual void Execute(IDeepTreeAgent owner)
        {
            _currentCount = Count;
            _currentDelay = Delay;
            _isFinish = false;
        }
        // 中断
        public virtual void Interrupt(IDeepTreeAgent owner)
        {
            Finish();
        }

        public virtual void DoAction(IDeepTreeAgent owner)
        {

        }

        public virtual bool IsTick()
        {
            return _isTick;
        }
        public virtual void Tick(IDeepTreeAgent owner)
        {
            if ( _currentCount > 0 || _currentCount == -1)
            {
                _currentDelay -= 1;

                if ( _currentDelay <= 0)
                {
                    DoAction(owner);
                    _currentDelay = Delay;
                    if( _currentCount > 1 ){
                        if( _currentCount == 1){
                            // 设置结点结束
                            Finish();
                        }
                        _currentCount -= 1;
                    }
             
                }
            }
        }

        // 结束结点
        public virtual void Finish()
        {
            _currentCount = 0;
            _currentDelay = 0;
            _isFinish = true;
            _completeDelegate();
        }
            

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
