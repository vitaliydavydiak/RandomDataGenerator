﻿using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Gui.UserControls;

namespace RandomDataGenerator.Gui.UserControlsFields
{
    public partial class UserControlIPv4Address : UserControlIPv4AddressDesignable
    {
        public UserControlIPv4Address()
        {
            InitializeComponent();

            base.OnOptionsChanged(EventArgs.Empty);
        }
    }

    // Workaround http://stackoverflow.com/questions/677609/generic-base-class-for-winform-usercontrol
    public class UserControlIPv4AddressDesignable : BaseUserControl<FieldOptionsIPv4Address>
    {
    }
}