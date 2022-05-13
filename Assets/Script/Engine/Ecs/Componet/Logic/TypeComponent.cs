#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：TransformComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/12 14:59:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// 类型组件
    /// </summary>
    public class TypeComponent : BaseComponent
    {
        #region <属性>

        #endregion <属性>

        #region <方法>
        public TypeComponent(int id, int entityId) : base(id, entityId)
        {
        }
        public new string GetType(){
            return "TypeComponent";
        }
        #endregion <方法>

    }
}
