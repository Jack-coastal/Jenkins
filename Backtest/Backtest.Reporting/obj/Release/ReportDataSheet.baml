   M S B A M L   `   `   `  ����   Backtest.Reporting(    "Backtest.Reporting.ReportDataSheet   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     f bDevExpress.Xpf.Grid.v13.1.Core, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   .��� .+�%  DevExpress.Xpf.Grid.GridControl  -   $��grid1��)  #DevExpress.Xpf.Grid.DataControlBase    AutoPopulateColumns  .    ItemsSource �� *
ReportData+   View #  DevExpress.Xpf.Grid.TableView  &   DevExpress.Xpf.Grid.GridViewBase   ShowGroupPanel .  "   VerticalScrollbarVisibility$
 Auto=�   	AutoWidth . &   DevExpress.Xpf.Grid.DataViewBase   NavigationStyle$	 Row=�   DetailHeaderContent$
 Data��#   IsDetailButtonVisibleBinding Z� 	   Bands	 )  #DevExpress.Xpf.Grid.GridControlBand  
   Columns.
 $  DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$ Symbol��  $	  DevExpress.Xpf.Grid.BaseColumn 	  Headera ]DevExpress.Xpf.Core.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a)
  #DevExpress.Xpf.Core.ObjectConverter$
 Side
 .
   $ LiveSide��$
 Live
   $ BenchMarkSide��$ 	Back Test
   $ AveEntry
 .
   $ LiveAveEntry��$
 Live
   $ BenchMarkAveEntry��$ 	Back Test
   $ AveExit
 .
   $ LiveAveExit��$
 Live
   $ BenchMarkAveExit��$ 	Back Test
   $
 Size
 .
   $ LiveSize��$
 Live
   $ BenchMarkSize��$ 	Back Test
   .
   $	 PnL��$	 PnL
   .
   $ Slippage��