using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System.Diagnostics;
using Microsoft.UI.Composition;
using Microsoft.UI.Xaml.Hosting;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Reflection;
using Windows.Networking.NetworkOperators;
using System.Numerics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Windows工具WinUI3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        CompositionPropertySet _props;
        CompositionPropertySet _scrollerPropertySet;
        Compositor _compositor;
        private SpriteVisual _blurredBackgroundImageVisual;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Program Files\Hyper-V\VMCreate.exe";
            m_Process.Start();
        }
        private void myButton_Click2(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Administrative Tools\Hyper-V Manager.lnk";
            m_Process.Start();
        }
        private void myButton_Click3(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\iscsicpl.exe";
            m_Process.Start();
        }
        private void myButton_Click4(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\syswow64\odbcad32.exe";
            m_Process.Start();
        }
        private void myButton_Click5(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\odbcad32.exe";
            m_Process.Start();
        }
        private void myButton_Click6(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Program Files\WindowsApps\Microsoft.PowerAutomateDesktop_1.0.560.0_x64__8wekyb3d8bbwe\PAD.Console.Host.exe";
            m_Process.Start();
        }
        private void myButton_Click7(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Program Files (x86)\Windows Media Player\wmplayer.exe";
            m_Process.Start();
        }
        private void myButton_Click8(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            m_Process.Start();
        }
        private void myButton_Click9(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe";
            m_Process.Start();
        }
        private void myButton_Click10(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell_ise.exe";
            m_Process.Start();
        }
        private void myButton_Click11(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\syswow64\WindowsPowerShell\v1.0\powershell_ise.exe";
            m_Process.Start();
        }
        private void myButton_Click12(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\MdSched.exe";
            m_Process.Start();
        }
        private void myButton_Click13(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\eventvwr.exe";
            m_Process.Start();
        }
        private void myButton_Click14(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\Taskmgr.exe";
            m_Process.Start();
        }
        private void myButton_Click15(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\taskschd.msc";
            m_Process.Start();
        }
        private void myButton_Click16(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Program Files\Windows NT\Accessories\wordpad.exe";
            m_Process.Start();
        }
        private void myButton_Click17(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\cmd.exe";
            m_Process.Start();
        }
        private void myButton_Click18(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\charmap.exe";
            m_Process.Start();
        }
        private void myButton_Click19(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\perfmon.exe";
            m_Process.Start();
        }
        private void myButton_Click20(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\RecoveryDrive.exe";
            m_Process.Start();
        }
        private void myButton_Click21(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\printmanagement.msc";
            m_Process.Start();
        }
        private void myButton_Click22(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\services.msc";
            m_Process.Start();
        }
        private void myButton_Click23(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\secpol.msc";
            m_Process.Start();
        }
        private void myButton_Click24(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\psr.exe";
            m_Process.Start();
        }
        private void myButton_Click25(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\regedit.exe";
            m_Process.Start();
        }
        private void myButton_Click26(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\dfrgui.exe";
            m_Process.Start();
        }
        private void myButton_Click27(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\cleanmgr.exe";
            m_Process.Start();
        }
        private void myButton_Click28(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\msinfo32.exe";
            m_Process.Start();
        }
        private void myButton_Click29(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\msconfig.exe";
            m_Process.Start();
        }
        private void myButton_Click30(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\comexp.msc";
            m_Process.Start();
        }
        private void myButton_Click31(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\compmgmt.msc";
            m_Process.Start();
        }
        private void myButton_Click32(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\perfmon.exe";
            m_Process.Start();
        }
        private void myButton_Click33(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Users\H WX\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\System Tools\Run.lnk";
            m_Process.Start();
        }
        private void myButton_Click34(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\mstsc.exe";
            m_Process.Start();
        }
        private void myButton_Click35(object sender, RoutedEventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Windows\system32\WF.msc";
            m_Process.Start();
        }
    }
}
