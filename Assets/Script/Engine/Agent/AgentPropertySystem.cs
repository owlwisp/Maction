#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Agent
 * 文件名：AgentPropertySystem
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 13:57:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System.Collections.Generic;
using Assets.Script.Core.Pool;

namespace Assets.Script.Engine.Agent
{
    /// <summary>
    /// 人物属性系统
    /// </summary>
    public class AgentPropertySystem
    {
        #region <属性>
        // 属性字典
        private Dictionary<AgentPropertyType, AgentProperty> m_propertyDict;
     
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            m_propertyDict = new Dictionary<AgentPropertyType, AgentProperty>();
        }
        // 增加属性
        public void AddProperty(AgentPropertyType type, AgentProperty property)
        {
            if (m_propertyDict.ContainsKey(type))
            {
                m_propertyDict[type].Add(property.Value);
            }
            else
            {
                m_propertyDict.Add(type, property);
            }
        }

        // 增加属性
        public void AddProperty(AgentPropertyType type, int value)
        {
            if (m_propertyDict.ContainsKey(type))
            {
                m_propertyDict[type].Add(value);
            }
            else
            {
                //todo 这里需要修改
                var property = new AgentProperty();
                m_propertyDict.Add(type, property);
            }
        }

        // 获取属性
        public AgentProperty GetProperty(AgentPropertyType type)
        {
            if (m_propertyDict.ContainsKey(type))
            {
                return m_propertyDict[type];
            }
            return null;
        }
        
        // 清理
        public void OnClear(){
            // 遍历字典回收属性
            foreach (var property in m_propertyDict.Values)
            {
                MPool<AgentProperty>.Instance.Recycle(property);
            }
            m_propertyDict.Clear();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
