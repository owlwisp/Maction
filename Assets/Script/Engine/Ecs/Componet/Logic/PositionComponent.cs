#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：TransformComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/13 13:1:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Base;

namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// 坐标组件
    /// </summary>
    public class PositionComponent : BaseComponent
    {
        #region <属性>
        // 坐标
        public float x ;
        // 缩放
        public float y ;
        // 旋转
        public float z ;
        
        #endregion <属性>

        #region <方法>
        public PositionComponent(int id , int entityId):base(id, entityId){
            
        }
        public new string GetType(){
            return "PositionComponent";
        }
        #endregion <方法>

    }
}
