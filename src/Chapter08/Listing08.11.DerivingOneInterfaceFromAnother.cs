namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_11;

using Listing08_09;

#region INCLUDE
interface IDistributedSettingsProvider : ISettingsProvider
{
    /// <summary>
    /// 获取特定URI的设置
    /// </summary>
    /// <param name="uri">
    /// 和设置关联的URI名称</param>
    /// <param name="name">设置名称</param>
    /// <param name="defaultValue">
    /// 在设置未找到的前提下返回的值</param>
    /// <returns>指定的设置</returns>
    string GetSetting(
        string uri, string name, string defaultValue);

    /// <summary>
    /// 为特定URI进行设置
    /// </summary>
    /// <param name="uri">
    /// 和设置关联的URI名称</param>
    /// <param name="name">设置名称</param>
    /// <param name="value">要持久化存储的值</param>
    /// <returns>指定的设置</returns>
    void SetSetting(
        string uri, string name, string value);
}
#endregion INCLUDE
