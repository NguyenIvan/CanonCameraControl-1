﻿#pragma checksum "..\..\..\..\windows\LiveViewWnd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2E3329D8D60042D50E11934B0776B1B57C7F2A02"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CameraControl.Controls;
using CameraControl.Core;
using CameraControl.Core.Translation;
using CameraControl.Devices;
using CameraControl.windows;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace CameraControl.windows {
    
    
    /// <summary>
    /// LiveViewWnd
    /// </summary>
    public partial class LiveViewWnd : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_help;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_preview;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_rec;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button2;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_focusm;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_focusp;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_focusmm;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_focuspp;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_focusmmm;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_focusppp;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_movea;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_moveb;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider focus_slider;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_takephoto;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_preview;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_stop;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CameraControl.Controls.Controler controler1;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_zoom;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox1;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider_transparent;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chk_top;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chk_motiondetect;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chk_tiggeronmotion;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown upd_threshold;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown upd_movewait;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_motion;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chk_autofocus;
        
        #line default
        #line hidden
        
        
        #line 265 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_record;
        
        #line default
        #line hidden
        
        
        #line 266 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas_image;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle small_focus_rect;
        
        #line default
        #line hidden
        
        
        #line 272 "..\..\..\..\windows\LiveViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_wait;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CameraControl;component/windows/liveviewwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\windows\LiveViewWnd.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 3 "..\..\..\..\windows\LiveViewWnd.xaml"
            ((CameraControl.windows.LiveViewWnd)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 3 "..\..\..\..\windows\LiveViewWnd.xaml"
            ((CameraControl.windows.LiveViewWnd)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 3 "..\..\..\..\windows\LiveViewWnd.xaml"
            ((CameraControl.windows.LiveViewWnd)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\windows\LiveViewWnd.xaml"
            ((CameraControl.windows.LiveViewWnd)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MetroWindow_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_help = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_help.Click += new System.Windows.RoutedEventHandler(this.btn_help_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.img_preview = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.image1 = ((System.Windows.Controls.Image)(target));
            
            #line 48 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.image1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.image1_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 49 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.canvas.SizeChanged += new System.Windows.SizeChangedEventHandler(this.canvas_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbl_rec = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button2 = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.button2.Click += new System.Windows.RoutedEventHandler(this.button2_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_focusm = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_focusm.Click += new System.Windows.RoutedEventHandler(this.btn_focusm_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_focusp = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_focusp.Click += new System.Windows.RoutedEventHandler(this.btn_focusp_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_focusmm = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_focusmm.Click += new System.Windows.RoutedEventHandler(this.btn_focusmm_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_focuspp = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_focuspp.Click += new System.Windows.RoutedEventHandler(this.btn_focuspp_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_focusmmm = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_focusmmm.Click += new System.Windows.RoutedEventHandler(this.btn_focusmmm_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btn_focusppp = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_focusppp.Click += new System.Windows.RoutedEventHandler(this.btn_focusppp_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btn_movea = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_movea.Click += new System.Windows.RoutedEventHandler(this.btn_movea_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btn_moveb = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_moveb.Click += new System.Windows.RoutedEventHandler(this.btn_moveb_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.focus_slider = ((System.Windows.Controls.Slider)(target));
            
            #line 143 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.focus_slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.btn_takephoto = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_takephoto.Click += new System.Windows.RoutedEventHandler(this.btn_takephoto_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.btn_preview = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_preview.Click += new System.Windows.RoutedEventHandler(this.btn_preview_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.btn_stop = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_stop.Click += new System.Windows.RoutedEventHandler(this.btn_stop_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 22:
            this.controler1 = ((CameraControl.Controls.Controler)(target));
            return;
            case 23:
            this.cmb_zoom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 24:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.checkBox1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 26:
            this.slider_transparent = ((System.Windows.Controls.Slider)(target));
            
            #line 219 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.slider_transparent.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider_transparent_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 27:
            this.chk_top = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 28:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.chk_motiondetect = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 30:
            this.chk_tiggeronmotion = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 31:
            this.upd_threshold = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 32:
            this.upd_movewait = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 33:
            this.lbl_motion = ((System.Windows.Controls.Label)(target));
            return;
            case 34:
            this.chk_autofocus = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 35:
            
            #line 264 "..\..\..\..\windows\LiveViewWnd.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.ToggleButton_Checked);
            
            #line default
            #line hidden
            return;
            case 36:
            this.btn_record = ((System.Windows.Controls.Button)(target));
            
            #line 265 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.btn_record.Click += new System.Windows.RoutedEventHandler(this.btn_record_Click);
            
            #line default
            #line hidden
            return;
            case 37:
            this.canvas_image = ((System.Windows.Controls.Canvas)(target));
            
            #line 266 "..\..\..\..\windows\LiveViewWnd.xaml"
            this.canvas_image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.canvas_image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 38:
            this.small_focus_rect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 39:
            this.grid_wait = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

