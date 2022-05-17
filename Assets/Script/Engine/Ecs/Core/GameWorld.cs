#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core
 * 文件名：GameWorld
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 16:57:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Const;
using Assets.Script.Engine.Ecs.Core.Module;


namespace Assets.Script.Engine.Ecs.Core
{
    /// <summary>
    /// ecs主类
    /// </summary>
    public class GameWorld
    {
        #region <属性>

        // 逻辑世界
        private LogicWorld _logicWorld;
        // 渲染世界
        private RenderWolrd _renderWorld;

        // 战斗状态
        BattleStatus _battleStatus;

        // 当前帧可执行的最大帧数
        private int _kMaxFrame;
        // 当前帧执行了多少逻辑帧
        private int _kCurrentFrame;

        // 需要执行每一帧的时间
        private float _kFrameTime;
        // 当前帧的时间
        private float _kCurrentFrameTime;
        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init()
        {
            _logicWorld = new LogicWorld();
            _renderWorld = new RenderWolrd();

            _battleStatus = BattleStatus.kNone;
            _kMaxFrame = 10;
            _kCurrentFrame = 0;

            _kFrameTime = 33.33f;
            _kCurrentFrameTime = 0;
        }

        // 释放
        public void Dispose()
        {
            _battleStatus = BattleStatus.kNone;
            _kCurrentFrameTime = 0;
            _kCurrentFrame = 0;
            _logicWorld.Dispose();
            _renderWorld.Dispose();
        }

        // 为logicWorld增加action
        public void AddAction(InputAction action)
        {
            _logicWorld.AddAction(action);
        }

        // 更新函数
        public void Update(float delta)
        {
            // 更新系统
            if (_battleStatus = BattleStatus.kBattle)
            {
                if (BattleResultType.kNone == UpdateLogic(delta)){
                    UpdateRender(delta);
                }
            }
            else if (_battleStatus == BattleStatus.kWaitRender){
                UpdateWait(delta);
            }
            else if (_battleStatus == BattleStatus.kBattleResult){
                UpdateBattleResult(delta);
            }
            else if (_battleStatus == BattleStatus.kFinish){
                UpdateFinish(delta);
            }
        }

        // 更新逻辑
        private BattleResultType UpdateLogic(float delta)
        {
            _kCurrentFrame = 0;
            BattleResultType result = BattleResultType.kNone;

            _kCurrentFrameTime += delta;
            while (_kCurrentFrame < _kMaxFrame && _kCurrentFrameTime >= _kFrameTime)
            {
                _kCurrentFrame++;
                _kCurrentFrameTime -= _kFrameTime;
                BattleResultType result = _logicWorld.Tick(delta);
                if (BattleResultType.kNone != result)
                {
                    _battleStatus = BattleStatus.kWaitRender;
                    return result;
                }
            }
            return result;
        }

        // 更新渲染
        private void UpdateRender(float delta)
        {
            var ret = ProcessFrame();
            _renderWorld.Tick(delta);
            return ret;
        }
        // 处理渲染帧事件
        public bool ProcessFrame(){
            var renderFrame = _renderWorld.GetFrameCount();
            var logicFrame = _logicWorld.GetFrameCount();

            // 显示层更新追赶上逻辑帧时，未处理的逻辑帧处理完成
            if(renderFrame >= logicFrameCount){
                return true;
            }

            var frameData = _logicWorld.GetFrameData(renderFrame);
            _renderWorld.ProcessFrame(frameData);
            return false;
        }
        
        // 等待渲染
        private void UpdateWait(float delta)
        {
            // 更新系统
            if(UpdateRender(delta)){
                _battleStatus = BattleStatus.kBattleResult;
            }
        }

        // 处理战斗结果状态
        private void UpdateBattleResult(float delta)
        {
            // 更新系统
            _renderWorld.Tick(delta);
            // todo:这里需要思考根据什么条件结束战斗，是战斗时间到 还是服务器推送协议到了，是在那里处理这个服务器协议等
        }

        // 处理战斗结束
        private void UpdateFinish(float delta)
        {
            _battleStatus = BattleStatus.kFinish;
        }


        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
