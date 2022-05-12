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


        // 实体模块
        private EntityModule _entityModule;
        // 组件模块
        private ComponentModule _componentModule;
        // 系统模块
        private SystemModule _systemModule;
        // 统一处理模块
        private UnitilyModule _unitilyModule;
        
        // 是否开启时间更新
        bool _isUpdate = false;



        
        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init()
        {
            _entityModule = new EntityModule();
            _componentModule = new ComponentModule();
            _systemModule = new SystemModule();
            _unitilyModule = new UnitilyModule();

            _entityModule.Init();
            _componentModule.Init();
            _systemModule.Init();
            _unitilyModule.Init();

        }

        // 释放
        public void Dispose()
        {
            _entityModule.Dispose();
            _componentModule.Dispose();
            _systemModule.Dispose();
            _unitilyModule.Dispose();

            _entityModule = null;
            _componentModule = null;
            _systemModule = null;
            _unitilyModule = null;
        }

        // 更新函数
        public void Update()
        {
            // 更新系统
            if (_isUpdate)
            {
                // for (int i = 0; i < _count; i++)
                // {
                //     _entities[i].Update();
                // }
            }
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
