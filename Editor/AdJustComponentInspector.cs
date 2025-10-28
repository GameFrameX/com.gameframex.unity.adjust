// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using GameFrameX.AdJust.Runtime;
using GameFrameX.Editor;
using UnityEditor;

namespace GameFrameX.AdJust.Editor
{
    [CustomEditor(typeof(AdJustComponent))]
    internal sealed class AdJustComponentInspector : ComponentTypeComponentInspector
    {
        private SerializedProperty m_appToken = null;
        private SerializedProperty m_logLevel = null;
        private SerializedProperty m_environment = null;
        private SerializedProperty m_debug = null;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            serializedObject.Update();
            EditorGUI.BeginDisabledGroup(EditorApplication.isPlayingOrWillChangePlaymode);
            {
                EditorGUILayout.HelpBox("请将 Adjust 配置好并初始化.只有Adjust配置为手动初始化,以下参数才能正常工作.", MessageType.Warning);
                EditorGUILayout.PropertyField(m_debug);
                EditorGUILayout.PropertyField(m_appToken);
                EditorGUILayout.PropertyField(m_logLevel);
                EditorGUILayout.PropertyField(m_environment);
            }
            EditorGUI.EndDisabledGroup();

            serializedObject.ApplyModifiedProperties();

            Repaint();
        }

        protected override void OnCompileComplete()
        {
            base.OnCompileComplete();

            RefreshTypeNames();
        }

        protected override void Enable()
        {
            m_debug = serializedObject.FindProperty("m_debug");
            m_appToken = serializedObject.FindProperty("m_appToken");
            m_logLevel = serializedObject.FindProperty("m_logLevel");
            m_environment = serializedObject.FindProperty("m_environment");
            RefreshTypeNames();
        }

        protected override void RefreshTypeNames()
        {
            RefreshComponentTypeNames(typeof(IAdJustManager));
        }
    }
}