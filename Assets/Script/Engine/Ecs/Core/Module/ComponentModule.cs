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
        private int _extraSize = 0;
  
        // 当前注册的基础组件
        private Dictionary< string, List<BaseComponent>> _componentsGroup;
        private Dictionary<int, List<BaseComponent>> _components;
        #endregion <属性>

        #region <方法>
        //设置容器大小
        public void SetSize(int size, int extraSize = 2)
        {
            _baseSize = size;
            _extraSize = extraSize;
        }
        // 初始化
        public void Init()
        {
            _components = new Dictionary<int, List<BaseComponent>>();
            _componentsGroup = new Dictionary<string, List<BaseComponent>>();
        }

        // 获取所有组件组
        public Dictionary<string, List<BaseComponent>> GetComponentsGroup()
        {
            return _componentsGroup;
        }
        // 增加基础组件
        public void AddComponent(BaseComponent component)
        {
            if (!_components.ContainsKey(component.EntityId))
            {
                _components.Add(component.EntityId, new List<BaseComponent>());
            }
            _components[component.EntityId].Add(component);


            if (!_componentsGroup.ContainsKey(component.GetType()))
            {
                _componentsGroup.Add(component.GetType(), new List<BaseComponent>());
            }
            
            _componentsGroup[component.GetType()].Add(component);

        }

        // 设置某个人的组件是否激活
        public void SetActive(int entityId, bool active)
        {
            if (_components.ContainsKey(entityId))
            {
                foreach (var component in _components[entityId])
                {
                    component.IsActive = active;
                }
            }
        }

        // 清除组件
        public void Clear()
        {
            _components.Clear();
            _componentsGroup.Clear();
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
