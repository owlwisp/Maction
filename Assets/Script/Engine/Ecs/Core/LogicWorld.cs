#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core
 * 文件名：LogicWorld
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:7:56
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using System.Collections.Generic;
using Assets.Script.Engine.Ecs.Const;
using Assets.Script.Engine.Ecs.Core.Module;

namespace Assets.Script.Engine.Ecs.Core
{
    /// <summary>
    /// 逻辑世界
    /// </summary>
    public class LogicWorld
    {
        #region <属性>

        // 实体模块
        private EntityModule _entityModule;
        // 组件模块
        private ComponentModule _componentModule;
        // 系统模块
        private SystemModule _systemModule;
        // 统一处理模块
        private UnitilyModule _unitilyModule;
        // 检验结果模块
        private RefereeModule _refereeModule;
        // 帧事件模块
        private FrameModule _frameModule;


        // 输入action 的队列
        private Queue<InputAction> _inputActionQueue;

        #endregion <属性>

        #region <方法>
                // 初始化
        public void Init()
        {
            _inputActionQueue = new Queue<InputAction>();

            _entityModule = new EntityModule();
            _componentModule = new ComponentModule();
            _systemModule = new SystemModule();
            _unitilyModule = new UnitilyModule();
            _refereeModule = new RefereeModule();
            _frameModule = new FrameModule();

            
            _componentModule.Init();
            _entityModule.Init();
            _systemModule.Init();
            _unitilyModule.Init();
            _refereeModule.Init();
            _frameModule.Init();

        }

        // 释放
        public void Dispose()
        {
            _inputActionQueue.Clear();

            _entityModule.Dispose();
            _componentModule.Dispose();
            _systemModule.Dispose();
            _unitilyModule.Dispose();
            _refereeModule.Dispose();
            _frameModule.Dispose();

            _entityModule = null;
            _componentModule = null;
            _systemModule = null;
            _unitilyModule = null;
            _refereeModule = null;
            _frameModule = null;
        }

        // 加入输入事件
        public void AddAction(InputAction action)
        {
            _inputActionQueue.Enqueue(action);
        }

        // 时间更新
        public BattleResultType Tick(float delta)
        {
            // 1. 处理输入事件
            ProcessAction();
            // 2. 更新系统
            ProcessSystem(delta);
            // 3. 检测战斗结果
            _refereeModule.Tick(delta);
            // 4. 写入log
            // TODO: 是否要根据frame模块的事件来写入log，用于查找问题，或者生成复盘数据
            
            // 5. 处理给渲染层的帧事件
            _frameModule.Tick(delta);

            // 6. 返回结果
            return _refereeModule.GetResult();
        }

        // 处理输入事件
        private void ProcessAction()
        {
            while (_inputActionQueue.Count > 0)
            {
                InputAction action = _inputActionQueue.Dequeue();
                _systemModule.ProcessAction(action);
            }
        }

        // 更新系统
        private void ProcessSystem(float delta)
        {
            _systemModule.Tick(delta, _componentModule.GetComponentsGroup());
        }

        // 获取当前帧数
        public int GetFrameCount()
        {
            return _frameModule.GetFrameCount();
        }

        // 获取当前帧数据
        public List<FrameData> GetFrameData()
        {
            return _frameModule.GetFrameData();
        }
        // 清理
        public void Clear()
        {
            _inputActionQueue.Clear();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
