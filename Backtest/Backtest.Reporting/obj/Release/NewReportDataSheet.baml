   M S B A M L   `   `   `  ����   Backtest.Reporting+    %Backtest.Reporting.NewReportDataSheet   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     f bDevExpress.Xpf.Grid.v13.1.Core, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Gdxght;http://schemas.devexpress.com/winfx/2008/xaml/grid/internal  Gdxgt<http://schemas.devexpress.com/winfx/2008/xaml/grid/themekeys  .��� .+�%  DevExpress.Xpf.Grid.GridControl  -   $��grid1��)  #DevExpress.Xpf.Grid.DataControlBase    AutoPopulateColumns  .    ItemsSource �� *
ReportData+   View #  DevExpress.Xpf.Grid.TableView  &   DevExpress.Xpf.Grid.GridViewBase   ShowGroupPanel .  "   VerticalScrollbarVisibility$
 Auto=�   	AutoWidth . &   DevExpress.Xpf.Grid.DataViewBase   NavigationStyle$	 Row=�   DetailHeaderContent$
 Data��#   IsDetailButtonVisibleBinding Z� 	   Columns	 $  DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.ColumnBase
   	FieldName$
 
DateMaster��$  DevExpress.Xpf.Grid.BaseColumn   Headera ]DevExpress.Xpf.Core.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a)	  #DevExpress.Xpf.Core.ObjectConverter$
 Date	    VisibleIndex$ 0��  $
 LiveAccount��$ 1��  $
 BenchMarkAccount��$ 2��  $
 LiveSymbolsTraded��$ # Symols Traded (live)	 $ 3��  $
 BenchMarkSymbolsTraded��$" # Symols Traded (Bench Mark)	 $ 4��  $
 	LiveGross��$ Gross Exposure (Live)	 $ 5��   currencyFormatSetting   EditSettings# [     	CellStyle ��   greenRedForegroundStyle �� Source# [   $
 BenchMarkGross��$! Gross Exposure (Bench Mark)	 $ 6��# [   �� # [   $
 LiveExposure��$ Exposure (Live)	 $ 7��# [   �� # [   $
 BenchMarkExposure��$ Exposure (Bench Mark)	 $ 8��# [   �� # [    DetailDescriptor 5
  /DevExpress.Xpf.Grid.DataControlDetailDescriptor
   
  ItemsSourceBinding �� *ReportOrders+ 
  DataControl.   	   $

 Date��  $
 Symbol��  $
 LiveSide�� ��   greenRedBackgroundStyle# [   $
 BenchMarkSide�� �� # [   $
 LiveAveEntry��$ Live Avg Entry	 # [   �� # [   $
 BenchMarkAveEntry��$ BenchMark Avg Entry	 # [   �� # [   $
 LiveAveExit��$ Live Avg Exit	 # [   �� # [   $
 BenchMarkAveExit��$ BenchMark Avg Exit	 # [   �� # [   $
 LiveSize��  $
 BenchMarkSize��  $	
 PnL��$ Live PnL	 # [   �� # [   $
 Slippage��      ShowFixedTotalSummary .   .  