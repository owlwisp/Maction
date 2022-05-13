#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：AiComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/13 16:44:14
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// ai相关组件
    /// </summary>
    public class AiComponent : BaseComponent
    {
        #region <属性>

        
        #endregion <属性>

        #region <方法>
        // 构造函数
        public AiComponent(int id , int entityId):base(id, entityId){

        }
   
        public new string GetType(){
            return "AiComponent";
        }
        #endregion <方法>

    }
}
