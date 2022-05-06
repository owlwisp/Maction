#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Internal
 * 文件名：AgentBase
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 13:57:24
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Agent
{
    /// <summary>
    /// 人物代理类
    /// </summary>
    public class AgentBase : IAgent
    {
        #region <属性>
        // 全局唯一id
        public int Id { get; set; }
        // 阵营
        public AgentCampType Camp { get; set; }
        
        // 当前状态
        public AgentStateType State { get; set; }

        // 属性系统
        public AgentPropertySystem PropertySystem { get; set; }

        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit(){
            // 初始化属性系统
            PropertySystem = new AgentPropertySystem();
            PropertySystem.OnInit();
        }
        // 增加属性
        public void AddProperty(AgentPropertyType propertyType, int value){
            PropertySystem.AddProperty(propertyType, value);
        }
        // 是否活着
        public bool IsAlive(){
            return State == AgentStateType.Alive;
        }
  
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
