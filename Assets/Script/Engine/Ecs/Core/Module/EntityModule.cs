#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core.Module
 * 文件名：EntityModule
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 18:9:46
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Interface;

namespace Assets.Script.Engine.Ecs.Core.Module
{
    /// <summary>
    /// 实体模块
    /// </summary>
    public class EntityModule : IModule
    {
        #region <属性>
        // 实体list
        private List<BaseEntity> _entityList;

        // 额外的实体list
        private List<BaseEntity> _extraEntityList;

        #endregion <属性>

        #region <方法>
        // 初始化
        public void Init()
        {
            _entityList = new List<BaseEntity>();
            _extraEntityList = new List<BaseEntity>();
        }
        // 增加实体
        public void AddEntity(BaseEntity entity)
        {
            _entityList.Add(entity);
        }

        // 增加额外实体
        public void AddExtraEntity(BaseEntity entity)
        {
            _extraEntityList.Add(entity);
        }

        // 移除额外实体
        public void RemoveExtraEntity(BaseEntity entity)
        {
            _extraEntityList.Remove(entity);
        }
        // 销毁
        public void Dispose()
        {
            _entityList.Clear();
            _extraEntityList.Clear();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
