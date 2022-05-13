#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Component.Logic
 * 文件名：AudioComponent
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
    /// 音效相关组件
    /// </summary>
    public class AudioComponent : BaseComponent
    {
        #region <属性>

        
        #endregion <属性>

        #region <方法>
        public AudioComponent(int id , int entityId):base(id, entityId){
            
        }
        public new string GetType(){
            return "AudioComponent";
        }
        #endregion <方法>

    }
}
