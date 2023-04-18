using System.Diagnostics;

namespace ProjCoopControleFinanceiro.Util
{
    internal static class Functions
    {
        public static void OpenArchiveTextNotepad(string archive)
        {
            var p = new Process();
            p.StartInfo.FileName = "notepad.exe";
            p.StartInfo.Arguments = archive;
            p.Start();
        }

    }
}
