using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MethodBox.QRMS.Controls
{
    public class SideButton : Button
    {
        static SideButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SideButton), new FrameworkPropertyMetadata(typeof(SideButton)));
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // DependencyProperty for corner radius of button
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(SideButton));

        public string Capital
        {
            get { return (string)GetValue(CapitalProperty); }
            set { SetValue(CapitalProperty, value); }
        }

        // DependencyProperty to display capital of current function
        public static readonly DependencyProperty CapitalProperty =
            DependencyProperty.Register(nameof(Capital), typeof(string), typeof(SideButton));

        public string Detail
        {
            get { return (string)GetValue(DetailProperty); }
            set { SetValue(DetailProperty, value); }
        }

        // DependencyProperty to display a short detail of current function
        public static readonly DependencyProperty DetailProperty =
            DependencyProperty.Register(nameof(Detail), typeof(string), typeof(SideButton));



        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(SideButton));


    }
}
