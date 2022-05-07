#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Effect
 * 文件名：ICondition
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 14:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System.Collections.Generic;
using Assets.Script.Code.Tree;
using Assets.Script.Engine.Base;
using Assets.Script.Engine.Internal;

namespace Assets.Script.Engine.Effect
{
    /// <summary>
    /// effect 基类
    /// </summary>
    public class EffectBase : IEffect , IDeepTreeAgent
    {
        #region <属性>
        // 全局id
        public int Id { get; set; }
        // 模版id
        public int TemplateId { get; set; }
        // 类型
        EffectType Type { get; set; }
        // 来源类型
        EffectSourceType SourceType { get; set; }
        // 相同模版id是重置还是追加
        EffectResetType ResetType { get; set; }
        // 优先级
        public int Priority { get; set; }
        //  拥有者id
        public int OwnerId { get; set; }
        // 音效id 链表
        List<int> SoundIds { get; set; }
        // 特效id 链表
        List<int> EffectIds { get; set; }

        // 效果标签
        List<string> Tags { get; set; }

        // 广度树 ScopeTree
        DeepTree Tree { get; set; }

        // 第一目标id
        public int TargetId { get; set; }

        // 目标互斥列表
        List<string> TargetExclusiveIds { get; set; }
        // 可以被替代的模版列表
        List<string> TargetReplaceIds { get; set; }

        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){

        }

        public int GetDeepTreeAgentId()
        {
            return Id;
        }



        public IDeepTreeAgent.GetDeepTreeAgentDelegate GetDeepTreeAgent()
        {
            return delegate (int id)
            {
                return Container<EffectBase>.Instance.Get(id);
            };
        }

        //播放音乐
        public void PlaySound()
        {
            // 播放音乐
            // SoundIds
        }
    
        //播放特效
        public void PlayEffect()
        {
            // 播放特效
            // EffectIds
        }

        //执行effect
        public void Execute()
        {
            // 执行
            Tree.Execute();
        }

        // 启用
        public void OnEnable()
        {
            // 启用
        }

        // 禁用
        public void OnDisable()
        {
            // 关闭
        }
        // 中断处理
        public void Interrupt()
        {
            // 中断处理
            Tree.Interrupt();
        }
        // 按帧更新
        public void Tick()
        {
            // 更新深度树
            Tree.Tick();
            

        }

        // 合并effect
        public bool Merge(EffectBase effect)
        {
            // 如果模版id相同则判断是否重置
            if (TemplateId == effect.TemplateId)
            {
                switch (ResetType)
                {
                    case EffectResetType.Reset:
                        // 重置
                        EffectMergeReset(effect);
                        break;
                    case EffectResetType.Append:
                        // 追加
                        EffectMergeAppend(effect);
                        break;
                }
                return true;
            }
     
            return false;
        }



        // 重置
        void EffectMergeReset(EffectBase effect)
        {
            // 重置
       
        }

        // 加
        void EffectMergeAppend(EffectBase effect)
        {
            // 加
        }

        // 是否互斥
        public bool IsExclusive(EffectBase effect)
        {
            // 是否互斥
            return TargetExclusiveIds.Contains(effect.TemplateId);
        }

        // 是否可以被替代
        public bool IsReplace(EffectBase effect)
        {
            // 是否可以被替代
            return TargetReplaceIds.Contains(effect.TemplateId);
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
