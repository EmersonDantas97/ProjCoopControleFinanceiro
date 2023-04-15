using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
