using System.Diagnostics;
using Microsoft.Win32;

public class SAMP
{
    private string fpath = null;

    public SAMP()
    {
        fpath = Registry.CurrentUser.OpenSubKey("Software\\\\SAMP").GetValue("gta_sa_exe").ToString();
        fpath = fpath.Substring(0, fpath.LastIndexOf("\\") + 1);
    }

    public string GetPath()
    {
        return fpath;
    }

    public bool IsStarted()
    {
        Process[] proc = Process.GetProcessesByName("gta_sa");
        return (proc.Length > 0);
    }

    public int Init(string ip, string playername, string serverpass = "")
    {

        if (string.IsNullOrEmpty(GetPath())) return 1;
        if (string.IsNullOrEmpty(ip)) return 2;
        if (IsStarted()) return 3;

        try
        {
            Registry.CurrentUser.OpenSubKey("Software\\SAMP", writable: true).SetValue("PlayerName", playername);
            Process.Start(GetPath() + "samp.exe", ip + " " + serverpass);
            return 0;
        }
        catch
        {
            return 4;
        }
    }

    public bool Exit()
    {
        Process[] proc = Process.GetProcessesByName("gta_sa");
        if (proc.Length > 0)
        {
            proc[0].Kill();
            return true;
        }
        return false;
    }
}