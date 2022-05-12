#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Timer
 * 文件名：MTimer
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/4/24 15:23:59
 * 描述：定时器类
 *
 * ---------------------------------------------------------------*/

#endregion << 版 本 注 释 >>



using Assets.Script.Core.Base;
using Assets.Script.Core.Pool;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Engine.Timer
{
    /// <summary>
    /// MTimer 的摘要说明
    /// </summary>
    public class MTimer : MSingleton<MTimer>
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private float _deltaTime;
        private float _lastTime;

        // 当前最近时间
        private float _nextTime;

        LinkedList<MTimerData> _timerLink = new LinkedList<MTimerData>(); 
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        public MTimer()
        {

        }

        ~MTimer()
        {

        }

        
        #endregion <构造方法和析构方法>

        #region <方法>
        // delay为0 的时候为每一帧都执行一次
        public void Once(float delay, Action<float> func ){
            var data = MPool<MTimerData>.Instance.Get();
            data.Init(delay, func);
            _timerLink.AddFirst(data);
        }

        // delay为0 的时候为每一帧都执行一次
        public void Repeat(float delay, Action<float> func , int Count = -1){
            var data = MPool<MTimerData>.Instance.Get();
            data.Init(delay, func, Count);
            _timerLink.AddFirst(data);
        }

        public void Update()
        {
            float deltaTime = Time.deltaTime;
            // 遍历_timerLink 判断时间是否到达

            LinkedListNode<MTimerData> node = _timerLink.First;
            while (node != null)
            {
                MTimerData data = node.Value;
                if (data.Time <= deltaTime)
                {
                    data.Callback(deltaTime);
                   if(data.Count == 0)
                    {
                        MPool<MTimerData>.Instance.Recycle(data);
                        _timerLink.Remove(node);
                    }
                    else
                    {
                        data.Time = data.Time - deltaTime + data.TimeDelay;
                        if (data.Count > 0)
                        {
                            data.Count--;
                        }
                    }
                }
                else
                {
                    data.Time -=  deltaTime;
                }
                node = node.Next;
            }
        }
        // 清除所有定时器
        public void Clear(){
            _timerLink.Clear();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
