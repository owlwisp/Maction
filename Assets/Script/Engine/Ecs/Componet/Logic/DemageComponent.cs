#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：DemageComponent
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:1:1
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Component.Logic
{
    /// <summary>
    /// 伤害 相关组件
    /// </summary>
    public class DemageComponent : BaseComponent
    {
        #region <属性>

        
        #endregion <属性>

        #region <方法>
        public DemageComponent(int id , int entityId):base(id, entityId){
            
        }
        public new string GetType(){
            return "DemageComponent";
        }
        #endregion <方法>

    }
}
