using System;
using System.Windows.Forms;

namespace King
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00002BB8 File Offset: 0x00000DB8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			Application.Run(new Form1());
		}
	}
}
