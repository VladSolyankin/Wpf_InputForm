using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_InputForm.Applications.UserControls
{
    /// <summary>
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : UserControl
    {
        public Form()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Form));

        public string Number
        {
            get
            {
                return (string)GetValue(NumberProperty);
            }
            set
            {
                SetValue(NumberProperty, value);
            }
        }

        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(string), typeof(Form));

        public bool IsActive
        {
            get
            {
                return (bool)GetValue(IsActiveProperty);
            }
            set
            {
                SetValue(IsActiveProperty, value);
            }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(Form));

        public string Description
        {
            get
            {
                return (string)GetValue(DescriptionProperty);
            }
            set
            {
                SetValue(DescriptionProperty, value);
            }
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(Form));
    }
}
