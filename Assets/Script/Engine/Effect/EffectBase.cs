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
    public class EffectBase : IEffect
    {
        #region <属性>
        // 全局id
        public int Id { get; set; }
        // 类型
        EffectType Type { get; set; }
        // 执行次数
        int Count { get; set; }
        // 延迟时间
        float Delay { get; set; }
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

        // 广度树 ScopeTree
        ScopeTree ScopeTree { get; set; }

        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit();
  
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
