using System.Windows;
using System.Windows.Controls;

namespace Controls.CustomControls.Buttons
{
    public class DoubleContentButton : Button
    {
        public static readonly DependencyProperty FirstContentProperty =
            DependencyProperty.Register(
                nameof(FirstContent),
                typeof(object),
                typeof(DoubleContentButton),
                new PropertyMetadata(null));

        public static readonly DependencyProperty SecondContentProperty =
            DependencyProperty.Register(
                nameof(SecondContent),
                typeof(object),
                typeof(DoubleContentButton),
                new PropertyMetadata(null));

        static DoubleContentButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(DoubleContentButton),
                new FrameworkPropertyMetadata(typeof(DoubleContentButton)));
        }


        public object FirstContent
        {
            get => (object) this.GetValue(FirstContentProperty);
            set => this.SetValue(FirstContentProperty, value);
        }


        public object SecondContent
        {
            get => (object) this.GetValue(SecondContentProperty);
            set => this.SetValue(SecondContentProperty, value);
        }
    }
}