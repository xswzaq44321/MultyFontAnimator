using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multyFontAnimator
{
	class Setting
	{
		public Setting()
		{
		}

		public string message;
		public string[] fontNames
		{
			get
			{
				if (fonts_list == null)
					return null;
				string[] bar = new string[fonts_list.Count()];
				for(int i = 0; i < bar.Count(); ++i)
				{
					bar[i] = fonts_list[i].Name;
				}
				return bar;
			}
			set
			{
				List<FontFamily> bar = new List<FontFamily>();
				for (int i = 0; i < value.Count(); ++i)
				{
					bar.Add(FontFamily.Families.First((a) => { return a.Name == value[i]; }));
				}
				fonts_list = bar.ToArray();
			}
		}
		public bool transparent;
		public Size size;
		public int msPerFrame;
		public FontStyle style;
		public float fontSize;
		public float fixedSize;
		private FontFamily[] fonts_list;

		public FontFamily[] getFontFamilies()
		{
			return fonts_list;
		}
		public void setFontFamilies(FontFamily[] bar)
		{
			this.fonts_list = bar;
		}
	}
}
