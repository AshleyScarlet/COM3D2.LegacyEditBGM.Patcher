namespace COM3D2.LegacyEditBGM.Patcher
{
    public class LegacyEditBGM
    {
        public static bool PlayBGM(SoundMgr @this, string fileName, float time, bool loop)
        {
            if (fileName == "BGM005.ogg" && UnityEngine.Random.Range(0f, 1f) >= 0.5f)
            {
                @this.PlayBGMLegacy("BGM002.ogg", 5f, true);
                return true;
            }
            return false;
        }
    }
}
