﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DewUserControls.DewFloatButtonPresentation
{
    namespace Types
    {
        /// <summary>
        /// Close after selected enum
        /// </summary>
        public enum CloseAfterSelected
        {
            Yes,
            No
        }
        /// <summary>
        /// Evidence selected enum
        /// </summary>
        public enum SelectedEvidenceEnum
        {
            Yes,
            No
        }
        /// <summary>
        /// Float button selected handler
        /// </summary>
        public delegate void FloatButtonSelectedHandler(object sender, SelectionChangedEventArgs e);
        /// <summary>
        /// Flyout default item
        /// </summary>
        public sealed class DewFloatButtonItem
        {
            /// <summary>
            /// Glyph, image, icon, textbox, choose whatever you want
            /// </summary>
            public Object Icon { get; set; }
            /// <summary>
            /// Listitem label
            /// </summary>
            public string Text { get; set; }
            /// <summary>
            /// Event occurs when this item is selected
            /// </summary>
           

            public event FloatButtonSelectedHandler OnSelected = null;
            /// <summary>
            /// Invoke the selected events
            /// </summary>
            public void Selected(object sender, SelectionChangedEventArgs e)
            {
                this.OnSelected?.Invoke(sender, e);
            }
            /// <summary>
            /// Standard constructor
            /// </summary>
            public DewFloatButtonItem() { }
            /// <summary>
            /// Constructor with text
            /// </summary>
            /// <param name="text">The text</param>
            public DewFloatButtonItem(string text)
            {
                this.Text = text;
            }
        }
    }
    
}
