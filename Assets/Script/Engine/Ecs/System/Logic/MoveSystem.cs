#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.System.Logic
 * 文件名：MoveSystem
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/13 14:7:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


namespace Assets.Script.Engine.Ecs.System.Logic
{
    /// <summary>
    /// 移动系统
    /// </summary>
    public class MoveSystem : BaseSystem
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 执行
        //public override void Execute()
        //{
        //    // 循环遍历所有的移动组件
        //    // foreach (var entity in EntityManager.GetEntities<MoveComponent>())
        //    // {
        //    //     // 获取移
        //    //     var move = entity.GetComponent<MoveComponent>();
        //    //     // 获取位置
        //    //     var position = entity.GetComponent<PositionComponent>();
        //    //     // 获取速度
        //    //     var velocity = entity.GetComponent<VelocityComponent>();

        //    // }
        //}

    
        public string GetType()
        {
            return "MoveSystem";
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
