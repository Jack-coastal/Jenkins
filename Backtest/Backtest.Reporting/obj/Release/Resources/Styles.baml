   M S B A M L   `   `   `  ���� M  IBacktest.Reporting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CoastalClientWPF.ConvertersCoastalClientWPF.Converters  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089f bDevExpress.Xpf.Grid.v13.1.Core, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Core.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a6   0DevExpress.Xpf.Editors.Settings.TextEditSettings6  0DevExpress.Xpf.Editors.Settings.BaseEditSettings    DisplayFormat   currencyFormatSetting  signedNumberFormatSetting  numberFormatSetting7   1CoastalClientWPF.Converters.ValueCompareConverter  compareWithZeroConverter   ReferenceValue2  ,DevExpress.Xpf.Grid.GridCellContentPresenter �� 
TargetType  coastalGridCellStyleBase �� BasedOn9  3DevExpress.Xpf.Grid.Themes.GridRowThemeKeyExtension�  �DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionInternalBase`1[[DevExpress.Xpf.Grid.Themes.GridRowThemeKeys, DevExpress.Xpf.Grid.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a]]   ResourceKey  greenRedBackgroundStyle �� Triggers �� Binding �� 	Converter �� ConverterParameter	 �� Value
 �� Property �� Value  	boldStyle  greenRedForegroundStyle�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     >dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Gdxgt<http://schemas.devexpress.com/winfx/2008/xaml/grid/themekeys  8
converters)clr-namespace:CoastalClientWPF.Converters  ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  %�  &	        &	      &	       &	 7     &	 D     0�� *  $ 	CellStyle=�+1&	 U     7  7  7  &	 W    7  &	 �    7  7     $  C��   $  -#;+#;0��   $  ###,###,##0��  $ 0Q��� "   2  �� "  8    ��  �� *Value+8  $ GreaterThan��	 true.a��� 
 � ��
 �2�2��� 
 � ��
 �   ���  �� *Value+8  $ LessThan��	 true.a��� 
 � ��
 �  ���� 
 � ��
 �������� 
 � ��$
 Bold"��� "  8   ��� 
 � ��$
 Bold"��� "   ��  �� *Value+8   $ GreaterThan��	 true.a��� 
 � ��
 � � ���  �� *Value+8  $ LessThan��	 true.a��� 
 � ��
 �  ����� 
 � ��$
 Bold"�