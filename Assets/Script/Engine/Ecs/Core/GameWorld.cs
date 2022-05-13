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
        // 基础个数
        private int _count ;



        // 逻辑世界
        private LogicWorld _logicWorld;
        // 渲染世界
        private RenderWolrd _renderWorld;
        
        // 是否开启时间更新
        bool _isUpdate = false;

        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init()
        {
            _logicWorld = new LogicWorld();
            _renderWorld = new RenderWolrd();

        }

        // 释放
        public void Dispose()
        {
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
            if (_isUpdate)
            {
                if (BattleResultType.kNone == UpdateLogic(delta)){
                    UpdateRender(delta);
                }
            }
        }

        // 更新逻辑
        public BattleResultType UpdateLogic(float delta)
        {
            return _logicWorld.Tick(delta);
        }

        // 更新渲染
        public void UpdateRender(float delta)
        {
            _logicWorld.Tick(delta);
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
