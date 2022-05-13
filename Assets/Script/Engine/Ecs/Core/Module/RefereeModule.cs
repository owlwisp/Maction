#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core.Module
 * 文件名：RefereeModule
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:9:46
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Const;
using Assets.Script.Engine.Ecs.Interface;

namespace Assets.Script.Engine.Ecs.Core.Module
{
    /// <summary>
    /// 结果校验模块
    /// </summary>
    public class RefereeModule : IModule
    {
        #region <属性>
        // 战斗结果
        private BattleResultType _result;
        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init(ComponentModule _componentModule)
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

        // 获取结果
        public BattleResultType GetResult()
        {
            return _result;
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
