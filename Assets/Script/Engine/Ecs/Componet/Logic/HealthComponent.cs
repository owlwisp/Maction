#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：HealthComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 17:59:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// 健康组件
    /// </summary>
    public class HealthComponent : BaseComponent
    {
        #region <属性>
        // 血量
        public int Health ;
        
        #endregion <属性>
        #region <方法>
        public string GetType(){
            return "HealthComponent";
        }
        #endregion <方法>
    }
}
