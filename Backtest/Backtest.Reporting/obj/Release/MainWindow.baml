   M S B A M L   `   `   `  ���� M  IBacktest.Reporting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Backtest.ReportingBacktest.Reporting  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections #    Backtest.Reporting.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     2local clr-namespace:Backtest.Reporting     a ]DevExpress.Xpf.Core.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  c _DevExpress.Xpf.Ribbon.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon  <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  Fdxbh;http://schemas.devexpress.com/winfx/2008/xaml/bars/internal  ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  d `DevExpress.Xpf.Docking.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxd5http://schemas.devexpress.com/winfx/2008/xaml/docking  f	 bDevExpress.Xpf.Grid.v13.1.Core, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa
 ]DevExpress.Xpf.Grid.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid 	 
 Fcollections2clr-namespace:System.Collections;assembly=mscorlib 	 
 c _DevExpress.Xpf.NavBar.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxnb4http://schemas.devexpress.com/winfx/2008/xaml/navbar  c _DevExpress.Xpf.Charts.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxc4http://schemas.devexpress.com/winfx/2008/xaml/charts    � Title$  Backtest Reporting��$	��700��$
��1100�� J� SnapsToDevicePixels .  � UseLayoutRounding . &   DevExpress.Xpf.Core.ThemeManager   	ThemeName0  *DevExpress.Xpf.Core.ThemeNameTypeConverter$ MetropolisDark  � 	Resources ��%    .��$  DevExpress.Xpf.Bars.BarManager  -     Name$ 
barManager��=  7DevExpress.Xpf.Bars.Helpers.BlendHelperForBarsAndRibbon   IsDesignControl .    Items '  !DevExpress.Xpf.Bars.BarButtonItem  -     Name$ bHelp��!  DevExpress.Xpf.Bars.BarItem	   Content)  #DevExpress.Xpf.Core.ObjectConverter$
	 Help 
   Glyph$"
 Images/Icons/index-16x16.png��   
LargeGlyph$" Images/Icons/index-32x32.png��  -   $ bCopy��$
	 Copy $!
 Images/Icons/copy-16x16.png��$! Images/Icons/copy-32x32.png��  -   $ bPaste��$	 Paste $"
 Images/Icons/paste-16x16.png��$" Images/Icons/paste-32x32.png��  -   $
 bNew��$		 New $ 
 Images/Icons/new-16x16.png��$  Images/Icons/New-32x32.png��  -   $ bPrint��$	 Print $"
 Images/Icons/print-16x16.png��$" Images/Icons/print-32x32.png��  -   $ bOpen��$	 	Live Open $!
 Images/Icons/open-16x16.png��$! Images/Icons/open-32x32.png��  -   $ backOpen��$	 BenchMark Open $!
 Images/Icons/open-16x16.png��$! Images/Icons/open-32x32.png��$  DevExpress.Xpf.Bars.BarSubItem  -	     Name$ mmFile��$
	 File $!
 Images/Icons/zoom-16x16.png��$! Images/Icons/zoom-32x32.png��   	ItemLinks +	  %DevExpress.Xpf.Bars.BarButtonItemLink	  %
  DevExpress.Xpf.Bars.BarItemLink 
  BarItemName$
 bNew��	  $ bOpen��._�]� .+�.  (DevExpress.Xpf.Docking.DockLayoutManager  -
     Name$ dockLayoutManager��   
LayoutRoot. (  "DevExpress.Xpf.Docking.LayoutGroup     Items. *  $DevExpress.Xpf.Docking.DocumentGroup  -     Name$ 	documents��   Orientation$ Vertical=�+  %DevExpress.Xpf.Docking.BaseLayoutItem   	ItemWidth$ 4* �