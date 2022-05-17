#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core
 * 文件名：RenderWolrd
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:7:44
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using System;

namespace Assets.Script.Engine.Ecs.Core
{
    /// <summary>
    /// 渲染世界
    /// </summary>
    public class RenderWolrd
    {
        #region <属性>
        // 当前帧数
        private int _frameCount;

        // 音乐模块
        private MusicModule _musicModule;
        // 渲染实体模块
        private RenderEntityModule _renderEntityModule;

        // 是否跳过渲染
        private bool _isSkipRender;
        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init()
        {
            _frameCount = 0;
            _musicModule = new MusicModule();
            _renderEntityModule = new RenderEntityModule();
            _musicModule.Init();
            _renderEntityModule.Init();
        }
        // 释放
        public void Dispose()
        {
            _musicModule.Dispose();
            _renderEntityModule.Dispose();

            _musicModule = null;
            _renderEntityModule = null;
        }

        // 获取当前帧数
        public int GetFrameCount()
        {
            return _frameCount;
        }
        // 时间更新
        public void Tick(float delta)
        {
            _renderEntityModule.Tick(delta);
            _musicModule.Tick(delta);

            if (_isSkipRender)
            {
                SkipRender();
            }
        }

        // 跳过渲染
        public void DisableSkipRender()
        {
            _isSkipRender = true;
        }

        // 禁止渲染
        public void SkipRender()
        {
            
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
