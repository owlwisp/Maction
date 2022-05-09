#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Editor.Maction.Config
 * 文件名：ConfigManager
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/9 10:17:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Core.Base;

namespace Assets.Script.Editor.Maction.Config
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class ConfigManager : MSingleton<ConfigManager>
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        public string ExportFolder = "Assets/";

        public void LoadConfig()
        {
        }

        public void SaveConfig()
        {
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
