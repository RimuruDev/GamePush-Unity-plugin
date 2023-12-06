using GamePush;
using UnityEditor;

namespace Plugins.GamePush.Editor
{
    [FilePath("UserSettings/GP_SettingsWrap.asset",
        FilePathAttribute.Location.ProjectFolder)]
    public sealed class GP_SettingsWrap : ScriptableSingleton<GP_SettingsWrap>
    {
        public GP_Settings settings;
        
        private void OnDisable() => Save();
        public void Save() => Save(true);
    }
}