#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core.Module
 * 文件名：SystemModule
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:8:26
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using System.Collections.Generic;
using Assets.Script.Engine.Ecs.Interface;
using Assets.Script.Engine.Ecs.System;

namespace Assets.Script.Engine.Ecs.Core.Module
{
    /// <summary>
    /// 系统 模块
    /// </summary>
    public class SystemModule : IModule
    {
        #region <属性>
    #if UNITY_EDITOR || ENABLE_SYSTEM_RECORD_TIME
        // 时间
        public float Time { get; set; }
    #endif
        // 顺序链表
        public List<BaseSystem> _systemList;
        #endregion <属性>

        #region <方法>
         // 初始化
        public void Init()
        {
            _systemList = new List<BaseSystem>();
        }
        // 销毁
        public void Dispose()
        {
            _systemList.Clear();
        }

        // 添加系统
        public void AddSystem(BaseSystem system)
        {
            _systemList.Add(system);
        }
        // 清除所有系统
        public void ClearSystem()
        {
            _systemList.Clear();
        }
        // 对系统使用order排序
        public void SortSystem()
        {
            _systemList.Sort((x, y) => x.Order.CompareTo(y.Order));
        }

        // 这里需要增加计算时间的处理
    #if UNITY_EDITOR || ENABLE_SYSTEM_RECORD_TIME
        // 记录时间
        //public void RecordTime()
        //{
        //    //Time = Time.GetTime();
        //}
        //// 计算时间
        //public float CalculateTime()
        //{
        //    return Time.GetTime() - Time;
        //}
    #endif

        // 执行system
        public void Excute()
        {
            // RecordTime();
            // 遍历执行systemList
            foreach (var system in _systemList)
            {
                system.Excute();
            }

            // CalculateTime();
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
