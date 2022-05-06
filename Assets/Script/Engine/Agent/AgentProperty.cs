#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Agent
 * 文件名：AgentProperty
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
    /// 人物属性
    /// </summary>
    public class AgentProperty
    {
        #region <属性>
        // 属性名称
        public string Name { get; set; }
        // 属性值
        public int Value { get; set; }
        // 比例
        public int Rate { get; set; }
        // 属性类型
        public AgentPropertyType Type { get; set; }
        // 属性描述
        public string Description { get; set; }
        // 属性值上限
        public int MaxValue { get; set; }
        // 属性值下限
        public int MinValue { get; set; }
        

        #endregion <属性>

        #region <方法>
        // 增加属性
        public void Add(int value)
        {
            Value += value;
            if (Value > MaxValue)
            {
                Value = MaxValue;
            }
            else if (Value < MinValue)
            {
                Value = MinValue;
            }
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
