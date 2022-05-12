#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.System
 * 文件名：BaseSystem
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 16:57:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Const;
using Assets.Script.Engine.Ecs.Interface;

namespace Assets.Script.Engine.Ecs.System
{
    /// <summary>
    /// 系统 基类
    /// </summary>
    public class BaseSystem : ISystem
    {
        #region <属性>

        // 系统类型
        SystemType Type{ get; set; }
        // 顺序
        public int Order { get; set; }

        #endregion <属性>

        #region <方法>
        // 处理action
        public virtual void HandleAction()
        {

        }
        
        //// 处理消息
        //public virtual void HandleMessage(Message message)
        //{
            
        //}

        //// 处理帧事件
        //public virtual void HandleFrame(FrameEvent frameEvent)
        //{
            
        //}

        // 更新
        public virtual void Tick(float dt)
        {
            
        }

        public void Excute()
        {
            throw new global::System.NotImplementedException();
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
