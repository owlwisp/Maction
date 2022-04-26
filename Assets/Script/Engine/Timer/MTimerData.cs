#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Timer
 * 文件名：MTimerData
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/4/25 17:41:39
 * 描述：时间函数数据
 *
 * ---------------------------------------------------------------*/

#endregion << 版 本 注 释 >>



using Assets.Script.Core.Pool;
using System;

namespace Assets.Script.Engine.Timer
{
    /// <summary>
    /// MTimerData 的摘要说明
    /// </summary>
    internal class MTimerData : IObject
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        public float Time;
        public Action<float> Callback;

        // 可执行次数  -1为无限次
        public int Count ;
        // 时间
        public float TimeDelay;
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        public MTimerData()
        {

        }

        ~MTimerData()
        {

        }

        public void Init(float delay , Action<float> callback , int count = 0)
        {
            Time = delay;
            Callback = callback;
            Count = count;
            TimeDelay = delay;
        }


        #endregion <构造方法和析构方法>

        #region <方法>
        public void OnDisable()
        {
            throw new System.NotImplementedException();
        }

        public void OnEnable()
        {
            throw new System.NotImplementedException();
        }

        public void OnInit()
        {
            throw new System.NotImplementedException();
        }

        public void OnRecycle()
        {
            throw new System.NotImplementedException();
        }

        public void OnReset()
        {
            throw new System.NotImplementedException();
        }

        string IObject.GetType()
        {
            throw new System.NotImplementedException();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
