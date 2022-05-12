#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core.Module
 * 文件名：ComponentModule
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:11:44
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using System.Collections.Generic;
using Assets.Script.Engine.Ecs.Component;
using Assets.Script.Engine.Ecs.Interface;
using Unity.Collections;

namespace Assets.Script.Engine.Ecs.Core.Module
{
    /// <summary>
    /// 组件模块
    /// </summary>
    public class ComponentModule : IModule
    {
        #region <属性>
        // 基础大小
        private int _baseSize = 0;
  
        // 当前注册的基础组件
        private Dictionary< string, List<BaseComponent>> _components;

        // 当前注册的额外组件
        private Dictionary< string, List<BaseComponent>> _extraComponents;
        
        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init()
        {
            _components = new Dictionary<string, List<BaseComponent>>();
            _extraComponents = new Dictionary<string, List<BaseComponent>>();
        }

        // 增加基础组件
        public void AddComponent(BaseComponent component)
        {
            if (component == null)
            {
                return;
            }
            
            if (!_components.ContainsKey(component.GetType()))
            {
                _components.Add(component.GetType(), new List<BaseComponent>());
            }
            
            _components[component.GetType()].Add(component);
        }
        // 增加额外组件
        public void AddExtraComponent(BaseComponent component)
        {
            if (component == null)
            {
                return;
            }

            if (!_extraComponents.ContainsKey(component.GetType()))
            {
                _extraComponents.Add(component.GetType(), new List<BaseComponent>());
            }
            
            _extraComponents[component.GetType()].Add(component);
        }
        // 移除额外组件
        public void RemoveExtraComponent(BaseComponent component)
        {
            if (component == null)
            {
                return;
            }
            if (_extraComponents.ContainsKey(component.GetType()))
            {
                _extraComponents[component.GetType()].Remove(component);
            }
        }

        // 清除组件
        public void Clear()
        {
            _components.Clear();
        }

        // 销毁
        public void Dispose()
        {
            Clear();
        }
 
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
