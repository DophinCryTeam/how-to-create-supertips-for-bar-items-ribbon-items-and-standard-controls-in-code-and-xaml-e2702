﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace SuperTipDemo {
    /// <summary>
    /// Interaction logic for SuperTipFromCodeForStandardControls.xaml
    /// </summary>
    public partial class SuperTipFromCodeForStandardControls : DXWindow {
        public SuperTipFromCodeForStandardControls() {
            InitializeComponent();

            SuperTip tip = new SuperTip();
            SuperTipControl tipControl = new SuperTipControl();
            tipControl.SuperTip = tip;
            SuperTipHeaderItem header = new SuperTipHeaderItem();
            header.Content = "New";
            SuperTipItem item = new SuperTipItem();
            item.Content = "Create a new document";

            SuperTipItem item2 = new SuperTipItem();
            item2.Content = "Opens a new document in a new tab";

            tip.Items.Add(header);
            tip.Items.Add(item);
            tip.Items.Add(new SuperTipItemSeparator());
            tip.Items.Add(item2);

            bt.ToolTip = tipControl;
        }
    }
}
