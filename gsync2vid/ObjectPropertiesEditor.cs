﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsync2vid
{
    public partial class ObjectPropertiesEditor : Form
    {
        public ObjectPropertiesEditor()
        {
            InitializeComponent();
        }

        public Object Object
        {
            set
            {
                propertyGrid.SelectedObject = value;
            }
        }
    }
}
