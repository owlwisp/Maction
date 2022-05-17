#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core.Module.Logic
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
using Assets.Script.Engine.Ecs.Component;
using Assets.Script.Engine.Ecs.Const;
using Assets.Script.Engine.Ecs.Interface;
using Assets.Script.Engine.Ecs.System;

namespace Assets.Script.Engine.Ecs.Core.Module.Logic
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
        private List<BaseSystem> _systemList;
        // 字典
        private Dictionary<SystemType, BaseSystem> _systemDict;


    
        #endregion <属性>

        #region <方法>
         // 初始化
        public void Init()
        {
            _systemList = new List<BaseSystem>();
            _systemDict = new Dictionary<SystemType, BaseSystem>();
        }
        // 销毁
        public void Dispose()
        {
            ClearSystem();
        }

        // 添加系统
        public void AddSystem(BaseSystem system)
        {
            _systemList.Add(system);
            _systemDict[system.Type] =  system;
        }
        // 清除所有系统
        public void ClearSystem()
        {
            _systemList.Clear();
            _systemDict.Clear();
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

        // 这里是否考虑加入inputaction 对应system的处理来节省效率
        // 处理出入事件
        public void ProcessAction(InputAction action)
        {
            // 这里处理输入事件
            if(_systemDict.ContainsKey(action.Type))
            {
                _systemDict[action.Type].ProcessAction(action);
            }
        }

        // 时间更新
        public void Tick(float delta, Dictionary<string, List<BaseComponent>> components)
        {
            // 这里处理时间更新
            Excute( delta, components);
        }

        // 执行system
        public void Excute(float delta, Dictionary< string, List<BaseComponent>> components)
        {
            // RecordTime();
            // 遍历执行systemList
            foreach (var system in _systemList)
            {
                system.Excute(delta, components);
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
