using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactorySample
{
    class AutumnSkinFactory : SkinFactory
    {
        public Button CreateButton()
        {
            return new AutumnButton();
        }
        public ComboBox CreateComboBox()
        {
            return new AutumnComboBox();
        }
        public TextField CreateTextField()
        {
            return new AutumnTextField();
        }
    }
}
