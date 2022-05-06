#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Formula
 * 文件名：DamageData
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 16:31:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System.Collections.Generic;
using Assets.Script.Core.Pool;
using Assets.Script.Engine.Agent;

namespace Assets.Script.Engine.Formula
{
    /// <summary>
    /// 伤害数据
    /// </summary>
    public class DamageData : IObject
    {
        #region <属性>
        //属性字典
        public Dictionary<AgentPropertyType, int> PropertyDict;
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            PropertyDict = new Dictionary<AgentPropertyType, int>();
        }
        //进入缓存池调用函数
        public void OnEnable(){
            PropertyDict.Clear();
        }
        //退出缓冲池 调用函数
        public void OnDisable(){
            PropertyDict.Clear();
            PropertyDict = null;
        }

        //  重置数据调用函数
        public void OnReset(){
            PropertyDict.Clear();
        }
        // 回收的时候调用函数
        public void OnRecycle(){
            PropertyDict.Clear();
        }

        // 获取对象类型
        public string GetType(){
            return "DamageData";
        }

        // 增加属性
        public void AddProperty(AgentPropertyType type, int value){
            if (PropertyDict.ContainsKey(type))
            {
                PropertyDict[type] += value;
            }
            else
            {
                PropertyDict.Add(type, value);
            }
        }
        
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
