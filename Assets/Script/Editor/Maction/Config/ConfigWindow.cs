#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Editor.Maction.Config
 * 文件名：ConfigWindow
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/9 10:6:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>

using Assets.Script.Core.Base;

using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Assets.Script.Editor.Maction.Constant;
using UnityEngine;

namespace Assets.Script.Editor.Maction.Config
{
    /// <summary>
    /// 配置文件处理窗口
    /// </summary>

    [InfoBox("通过下面配置可以自定一些组件，并需要点击Save And Close 进行保存和执行！")]
    public class ConfigWindow : OdinEditorWindow
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        [FolderPath(RequireExistingPath = true), ShowInInspector,EnableGUI, OnValueChanged("OnValueChanged")]
        public string ExportPath
        {
            get
            {
                if (_ExportPath == null )
                {
                    return MSingleton<ConfigManager>.Instance.ExportFolder;
                }
                return _ExportPath;
            }
            set
            {
                
                _ExportPath = value;
            }
        }
        private string _ExportPath;


        [Button(ButtonSizes.Large), GUIColor(1, 0, 0), PropertyOrder(Constants.kPropertyOrder)]
        private void SaveAndClose()
        {
            Debug.Log("这里保存执行配置文件");
            MSingleton<ConfigManager>.Instance.SaveConfig();
            
            Close();
        }

        private void OnValueChanged()
        {
            
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
