using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFToggleButton.Controls
{
    public class SimpleToggleButton : ToggleButton
    {
        private static CornerRadius _defaultCornerRadius = new CornerRadius(0.0);
        private static Brush _defaultColorON = Brushes.SkyBlue;
        private static Brush _defaultColorOFF = Brushes.Beige;
        static SimpleToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SimpleToggleButton),
                new FrameworkPropertyMetadata(typeof(SimpleToggleButton)));
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
        public SimpleToggleButton() { }

        //propdp
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(SimpleToggleButton), new PropertyMetadata(_defaultCornerRadius));


        public Brush ColorON
        {
            get { return (Brush)GetValue(ColorONProperty); }
            set { SetValue(ColorONProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ColorON.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorONProperty =
            DependencyProperty.Register("ColorON", typeof(Brush), typeof(SimpleToggleButton), new PropertyMetadata(_defaultColorON));



        public Brush ColorOFF
        {
            get { return (Brush)GetValue(ColorOFFProperty); }
            set { SetValue(ColorOFFProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ColorOFF.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorOFFProperty =
            DependencyProperty.Register("ColorOFF", typeof(Brush), typeof(SimpleToggleButton), new PropertyMetadata(_defaultColorOFF));



        public string LabelON
        {
            get { return (string)GetValue(LabelONProperty); }
            set { SetValue(LabelONProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelON.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelONProperty =
            DependencyProperty.Register("LabelON", typeof(string), typeof(SimpleToggleButton), new PropertyMetadata("ON"));


        public string LabelOFF
        {
            get { return (string)GetValue(LabelOFFProperty); }
            set { SetValue(LabelOFFProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelOFF.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelOFFProperty =
            DependencyProperty.Register("LabelOFF", typeof(string), typeof(SimpleToggleButton), new PropertyMetadata("OFF"));

    }
}
