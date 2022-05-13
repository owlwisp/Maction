#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：AnimationComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/13 15:13:14
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// 动画相关组件
    /// </summary>
    public class AnimationComponent : BaseComponent
    {
        #region <属性>

        
        #endregion <属性>

        #region <方法>
        public AnimationComponent(int id , int entityId):base(id, entityId){
            
        }
        public new string GetType(){
            return "AnimationComponent";
        }
        #endregion <方法>

    }
}
