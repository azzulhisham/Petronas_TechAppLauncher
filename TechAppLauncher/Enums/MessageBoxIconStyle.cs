using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAppLauncher.Enums
{
    public class MessageBoxStyle
    {
        public enum IconStyle
        {
            Success,
            Error,
            Info,
            Warning
        }

        public enum ButtonStyle
        {
            Ok,
            YesNo
        }

        public enum ButtonResult
        {
            Closed,
            Ok,
            Yes,
            No
        }

        public enum DefaultButton
        {
            Button1,
            Button2
        }
    }
}
