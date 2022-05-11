#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core
 * 文件名：SystemModule
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:8:26
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.Core
{
    /// <summary>
    /// 系统 模块
    /// </summary>
    public class SystemModule : IModule
    {
        #region <属性>
    #if UNITY_EDITOR || ENABLE_SYSTEM_RECORD_TIME
        // 时间
        public float Time { get; set; }
    #endif
        #endregion <属性>

        #region <方法>
         // 初始化
        public void Init()
        {

        }
        // 销毁
        public void Dispose()
        {
            
        }

        // 这里需要增加计算时间的处理
    #if UNITY_EDITOR || ENABLE_SYSTEM_RECORD_TIME
        // 记录时间
        public void RecordTime()
        {
            Time = Time.GetTime();
        }
        // 计算时间
        public float CalculateTime()
        {
            return Time.GetTime() - Time;
        }
    #endif

        // 执行system
        public void Excute()
        {
            // RecordTime();

            // CalculateTime();
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
