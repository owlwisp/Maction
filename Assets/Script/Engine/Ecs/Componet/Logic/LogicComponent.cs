#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：LogicComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/13 17:11:1
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Base;

namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// 逻辑组件
    /// </summary>
    public class LogicComponent : BaseComponent
    {
        #region <属性>
        
        #endregion <属性>

        #region <方法>
        public LogicComponent(int id , int entityId):base(id, entityId){
            
        }
        public new string GetType(){
            return "LogicComponent";
        }
        #endregion <方法>

    }
}
