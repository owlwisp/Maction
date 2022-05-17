#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core.Module.Logic
 * 文件名：FrameModule
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/16 18:39:6
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Const;
using Assets.Script.Engine.Ecs.Interface;

namespace Assets.Script.Engine.Ecs.Core.Module.Logic
{
    /// <summary>
    /// 帧事件模块
    /// </summary>
    public class FrameModule : IModule
    {
        #region <属性>
        // 战斗结果
        private int _frameCount;

        // 当前处理帧
        private int _currentFrame;
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

        // 时间更新
        public void Tick(float delta)
        {
        }
        // 获取帧事件
        public int GetFrameCount()
        {
            return _frameCount;
        }

        // 获取当前帧数据
        public int GetCurrentFrame()
        {
            return _currentFrame;
        }
 
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
