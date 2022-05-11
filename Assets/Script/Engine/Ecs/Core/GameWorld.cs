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


namespace Assets.Script.Engine.Ecs.Core
{
    /// <summary>
    /// ecs主类
    /// </summary>
    public class GameWorld
    {
        #region <属性>
        // 基础个数
        private int m_count ;
        // 实体对象部分
        NativeArray<IEntity> m_entities;
        // 组件部分
        NativeArray<IComponent> m_componentess;
        // 系统部分
        // NativeArray<Entity> entities;
        List<IEntity> m_entityList;

        // 实体模块
        private EntityModule m_entityModule;
        // 组件模块
        private ComponentModule m_componentModule;
        // 系统模块
        private SystemModule m_systemModule;
        // 统一处理模块
        private UnitilyModule m_unitilyModule;
        
        // 是否开启时间更新
        bool m_isUpdate = false;



        
        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init()
        {
            m_entityModule = new EntityModule();
            m_componentModule = new ComponentModule();
            m_systemModule = new SystemModule();
            m_unitilyModule = new UnitilyModule();

            m_entityModule.Init();
            m_componentModule.Init();
            m_systemModule.Init();
            m_unitilyModule.Init();
            
        }

        // 释放
        public void Dispose()
        {
            m_entityModule.Dispose();
            m_componentModule.Dispose();
            m_systemModule.Dispose();
            m_unitilyModule.Dispose();

            m_entityModule = null;
            m_componentModule = null;
            m_systemModule = null;
            m_unitilyModule = null;
        }

        // 更新函数
        public void Update()
        {
            // 更新系统
            if (m_isUpdate)
            {
                // for (int i = 0; i < m_count; i++)
                // {
                //     m_entities[i].Update();
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
