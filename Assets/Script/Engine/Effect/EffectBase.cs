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



namespace Assets.Script.Engine.Effect
{
    /// <summary>
    /// effect 基类
    /// </summary>
    public class EffectBase : IEffect ,IDeepTreeAgent
    {
        #region <属性>
        // 全局id
        public int Id { get; set; }
        // 类型
        EffectType Type { get; set; }
        // 来源类型
        EffectSourceType SourceType { get; set; }
        // 合并方式
        EffectMergeType MergeType { get; set; }
        // 优先级
        int Priority { get; set; }
        //  拥有者id
        int OwnerId { get; set; }
        // 音效id 链表
        List<int> SoundIds { get; set; }
        // 特效id 链表
        List<int> EffectIds { get; set; }

        // 效果标签
        List<string> Tags { get; set; }

        // 广度树 ScopeTree
        DeepTree Tree { get; set; }

        // 目标id
        int TargetId { get; set; }

        // 拥有者id
        int OwnerId { get; set; }

        // 这块还需要在多考虑下
        // 目标互斥列表
        List<string> TargetExclusiveIds { get; set; }
        // 目标替代列表
        List<string> TargetReplaceIds { get; set; }
        // 同一目标id是否重置
        bool TargetReset { get; set; }

        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){

        }

        public int GetDeepTreeAgentId()
        {
            return Id;
        }

        public IDeepTreeAgent GetDeepTreeAgent()
        {
            return delegate(int id)
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
        public void Merge(EffectBase effect)
        {
            // 合并属性
            switch (effect.MergeType)
            {
                case EffectMergeType.kReset:
                    // 重置
                    ResetEffect(effect);
                    break;
                case EffectMergeType.kAdd:
                    // 加
                    AddEffect(effect);
                    break;
                case EffectMergeType.kExclusive:
                    // 互斥
                    ExclusiveEffect(effect);
                    break;
           
                default:
                    break;
            }
        }

        // 重置
        void ResetEffect(EffectBase effect)
        {
            // 重置
        }

        // 加
        void AddEffect(EffectBase effect)
        {
            // 加
        }

        // 互斥
        void ExclusiveEffect(EffectBase effect)
        {
            // 互斥
            // 判断标签tags是否互斥


        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
