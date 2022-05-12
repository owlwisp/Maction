#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect
 * 文件名：ICondition
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/7 11:0:13
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System.Collections.Generic;
using Assets.Script.Core.Base;
using Assets.Script.Core.Container;
using Assets.Script.Core.Pool;
using Assets.Script.Engine.Internal;

namespace Assets.Script.Engine.Effect
{
    /// <summary>
    /// effect 基类
    /// </summary>
    public class EffectManager : MSingleton<EffectManager> , IManager
    {
        #region <属性>
        // 按人物id存储的effect数组字典
        private Dictionary<int, List<EffectBase>> _effectDic;
        // 将要移除的buff列表
        private List<EffectBase> _removeList;
        
        #endregion <属性>

        #region <方法>
        public void Init(){
            _effectDic = new Dictionary<int, List<EffectBase>>();
            _removeList = new List<EffectBase>();
        }

        public void Release(){ 
            _effectDic.Clear();
            _removeList.Clear();
        }

        public void Destroy(){
            _effectDic = null;
            _removeList = null;
        }

        // 按优先级排序
        private int SortByPriority(EffectBase effect1, EffectBase effect2)
        {
            return effect1.Priority - effect2.Priority;
        }
        // 给某人添加buff
        public void AddEffect(int id, EffectBase effect)
        {
            if ( _effectDic.ContainsKey(id))
            {
                // 遍历检查 _effectDic[id] 中是否有buff可以merge
                for (int i = 0; i < _effectDic[id].Count; i++)
                {
                    if ( _effectDic[id][i].Merge(effect))
                    {
                        return;
                    }
                    else if ( _effectDic[id][i].IsExclusive(effect))
                    {
                        // 互斥的直接返回
                        return ;
                    }
                    else if ( _effectDic[id][i].IsReplace(effect))
                    {
                        //TODO: 这里需要看触发情况的 Interrupt 怎么处理
                        RemoveEffect(id, _effectDic[id][i]);
                    }
                }
    
                _effectDic[id].Add(effect);
                // 按照buff的优先级排序
                _effectDic[id].Sort(SortByPriority);

            }
            else
            {
                List<EffectBase> list = new List<EffectBase>();
                list.Add(effect);
                _effectDic.Add(id, list);
            }
            // TODO: 检查这里需要处理buff的merge等相关逻辑
            Container<EffectBase>.Instance.Add(effect);
        }

        // 给某人移除buff
        public void RemoveEffect(int id, EffectBase effect)
        {
            if ( _effectDic.ContainsKey(id))
            {
                _effectDic[id].Remove(effect);
            }
            _removeList.Add(effect);
            
        }

        // 移除某人所有buff
        public void RemoveAllEffect(int id)
        {
            if ( _effectDic.ContainsKey(id))
            {
                foreach (var effect in _effectDic[id])
                {
                    _removeList.Add(effect);
                }
                _effectDic[id].Clear();
            }
        }

        // 更新buff
        public void Tick()
        {
            // 更新buff
            foreach (var kv in _effectDic)
            {
                foreach (var effect in kv.Value)
                {
                    effect.Tick();
                }
            }
            // 移除buff
            foreach (var effect in _removeList)
            {
                effect.Interrupt();
                MPool<EffectBase>.Instance.Recycle(effect);
                Container<EffectBase>.Instance.Remove(effect);
            }
            _removeList.Clear();
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
