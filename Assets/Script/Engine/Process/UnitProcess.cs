#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Process
 * 文件名：UnitProcess
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 17:1:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Core.Base;
using Assets.Script.Core.Container;
using Assets.Script.Core.Pool;
using Assets.Script.Engine.Agent;
using Assets.Script.Engine.Effect;
using Assets.Script.Engine.Formula;

namespace Assets.Script.Engine.Process
{
    /// <summary>
    /// 统一创建入口
    /// </summary>
    public static class UnitProcess 
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        public static void OnInit(){
            // 这个可能需要更细致的划分
            MPool<EffectBase>.Instance.Init(24);
            MPool<DamageData>.Instance.Init(12);
            MPool<AgentProperty>.Instance.Init(48);
            
            MSingleton<EffectManager>.Instance.Init();
            Container<EffectBase>.Instance.Init();
        }

        // 清理
        public static void OnClear(){
            MPool<EffectBase>.Instance.Clear();
            MPool<DamageData>.Instance.Clear();
            MPool<AgentProperty>.Instance.Clear();

            Container<EffectBase>.Instance.Release();
            MSingleton<EffectManager>.Instance.Release();
        }
        
        public static void OnDestroy(){

            MPool<EffectBase>.Instance.Destroy();
            MPool<DamageData>.Instance.Destroy();
            MPool<AgentProperty>.Instance.Destroy();
            Container<EffectBase>.Instance.Destroy();
            MSingleton<EffectManager>.Instance.Destroy(); 
        }
        
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
