﻿using System.Drawing;
using System.Windows.Forms;

namespace bSoundMute.Controls.Themes
{
  internal class Styled : ThemeBase
  {
    public Styled(Form form)
      : base(form)
    {
    }

    public override Color BackColor
    {
      get { return Color.Transparent; }
    }

    public override Size SystemButtonSize
    {
      get
      {
        if (base.systemButtonSize == Size.Empty)
        {
          if (IsToolbar)
          {
            Size size = base.SystemButtonSize;
            size.Height += 2;
            size.Width -= 1;
            base.systemButtonSize = size;
          }
          else
          {
            Size size = SystemInformation.CaptionButtonSize;
            size.Height -= 2;
            size.Width -= 2;
            base.systemButtonSize = size;
          }
        }
        return base.systemButtonSize;
      }
    }

    public override Size FrameBorder
    {
      get
      {
        if (base.frameBorder == Size.Empty)
        {
          switch (form.FormBorderStyle)
          {
            case FormBorderStyle.SizableToolWindow:
            case FormBorderStyle.Sizable:
              base.frameBorder = new Size(SystemInformation.FrameBorderSize.Width + 1,
                                          SystemInformation.FrameBorderSize.Height + 1);
              break;
            default:
              base.frameBorder = new Size(SystemInformation.Border3DSize.Width + 2,
                                          SystemInformation.Border3DSize.Height + 2);
              break;
          }
        }
        return base.frameBorder;
      }
    }
  }
}
