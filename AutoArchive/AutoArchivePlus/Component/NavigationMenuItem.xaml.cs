﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace AutoArchivePlus.Component
{
    /// <summary>
    /// NavigationMenuItem.xaml 的交互逻辑
    /// </summary>
    public partial class NavigationMenuItem : UserControl
    {
        #region Properties

        public static readonly DependencyProperty TypeNameProperty;

        public static readonly DependencyProperty ItemNameProperty;

        public static readonly DependencyProperty ItemIconProperty;

        public static readonly DependencyProperty ItemIconWidthProperty;

        public static readonly DependencyProperty ItemIconHeightProperty;

        public static readonly DependencyProperty ItemIconMarginProperty;

        public static readonly DependencyProperty IsSelectProperty;

        public static readonly DependencyProperty ItemClickedCommandProperty;

        #endregion

        static NavigationMenuItem()
        {
            TypeNameProperty = DependencyProperty.Register("TypeName", typeof(string), typeof(NavigationMenuItem));
            ItemNameProperty = DependencyProperty.Register("ItemName", typeof(string), typeof(NavigationMenuItem));
            ItemIconProperty = DependencyProperty.Register("ItemIcon", typeof(ImageSource), typeof(NavigationMenuItem));
            ItemIconWidthProperty = DependencyProperty.Register("ItemIconWidth", typeof(double), typeof(NavigationMenuItem));
            ItemIconHeightProperty = DependencyProperty.Register("ItemIconHeight", typeof(double), typeof(NavigationMenuItem));
            ItemIconMarginProperty = DependencyProperty.Register(" ItemIconMargin", typeof(Thickness), typeof(NavigationMenuItem), new PropertyMetadata(new Thickness(7, 0, 0, 0)));
            IsSelectProperty = DependencyProperty.Register("IsSelect", typeof(bool), typeof(NavigationMenuItem));
            ItemClickedCommandProperty = DependencyProperty.Register("ItemClickedCommand", typeof(ICommand), typeof(NavigationMenuItem));
        }

        public NavigationMenuItem()
        {
            InitializeComponent();
        }

        public string TypeName
        {
            get
            {
                return (string)GetValue(TypeNameProperty);
            }
            set
            {
                SetValue(TypeNameProperty, value);
            }
        }

        public string ItemName
        {
            get
            {
                return (string)GetValue(ItemNameProperty);
            }
            set
            {
                SetValue(ItemNameProperty, value);
            }
        }

        public ImageSource ItemIcon
        {
            get
            {
                return (ImageSource)GetValue(ItemIconProperty);
            }
            set
            {
                SetValue(ItemIconProperty, value);
            }
        }

        public double ItemIconWidth
        {
            get
            {
                return (double)GetValue(ItemIconWidthProperty);
            }
            set
            {
                SetValue(ItemIconWidthProperty, value);
            }
        }

        public double ItemIconHeight
        {
            get
            {
                return (double)GetValue(ItemIconHeightProperty);
            }
            set
            {
                SetValue(ItemIconHeightProperty, value);
            }
        }

        public Thickness ItemIconMargin
        {
            get
            {
                return (Thickness)GetValue(ItemIconMarginProperty);
            }
            set
            {
                SetValue(ItemIconMarginProperty, value);
            }
        }

        public bool IsSelect
        {
            get
            {
                return (bool)GetValue(IsSelectProperty);
            }
            set
            {
                SetValue(IsSelectProperty, value);
            }
        }

        public ICommand ItemClickedCommand
        {
            get
            {
                return (ICommand)GetValue(ItemClickedCommandProperty);
            }
            set
            {
                SetValue(ItemClickedCommandProperty, value);
            }
        }
    }
}
