#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Interface
 * 文件名：ISystem
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 17:18:29
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Ecs.Interface
{
    /// <summary>
    /// 组件接口
    /// </summary>
    public interface ISystem
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        public  void HandleAction();
        
        //// 处理消息
        //public  void HandleMessage(Message message);
        //// 处理帧事件
        //public void HandleFrame(FrameEvent frameEvent);
        // 更新
        public void Tick(float dt);
        // 执行
        public void Excute();
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}