namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_11;

using Listing08_09;

#region INCLUDE
interface IDistributedSettingsProvider : ISettingsProvider
{
    /// <summary>
    /// ��ȡ�ض�URI������
    /// </summary>
    /// <param name="uri">
    /// �����ù�����URI����</param>
    /// <param name="name">��������</param>
    /// <param name="defaultValue">
    /// ������δ�ҵ���ǰ���·��ص�ֵ</param>
    /// <returns>ָ��������</returns>
    string GetSetting(
        string uri, string name, string defaultValue);

    /// <summary>
    /// Ϊ�ض�URI��������
    /// </summary>
    /// <param name="uri">
    /// �����ù�����URI����</param>
    /// <param name="name">��������</param>
    /// <param name="value">Ҫ�־û��洢��ֵ</param>
    /// <returns>ָ��������</returns>
    void SetSetting(
        string uri, string name, string value);
}
#endregion INCLUDE
