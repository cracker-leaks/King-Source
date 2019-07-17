using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace King.Properties
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00002BCF File Offset: 0x00000DCF
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00015E68 File Offset: 0x00014068
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("King.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00015EA8 File Offset: 0x000140A8
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002BD7 File Offset: 0x00000DD7
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00015EBC File Offset: 0x000140BC
		internal static Bitmap Fixed_thBNTCSCKH
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Fixed.thBNTCSCKH", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00015EE8 File Offset: 0x000140E8
		internal static Bitmap thBNTCSCKH_jpg
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("thBNTCSCKH.jpg", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400014D RID: 333
		private static ResourceManager resourceMan;

		// Token: 0x0400014E RID: 334
		private static CultureInfo resourceCulture;
	}
}
