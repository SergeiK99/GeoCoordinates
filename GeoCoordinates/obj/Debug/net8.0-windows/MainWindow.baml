   M S B A M L   `   `   `  ����c  _GMap.NET.WindowsPresentation, Version=2.1.7.0, Culture=neutral, PublicKeyToken=b85b9027b614afefqPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentationGMap.NET.WindowsPresentation  5   	   I EGeoCoordinates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GeoCoordinatesGeoCoordinates 5   	      GeoCoordinates.MainWindow   5   	   ZgmapsPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentation  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GeoCoordinates     5   	     � Title$  GeoCoordinates��5	   	   $	��555��6    $	��620��6-    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�  '��       '�� o     �� 5   
   " ��6   .�5      ��  � ��$ Arial)�6+   �� 5       � ��$ 16(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ Arial)�6+   �� 5       � ��$ 16(�6)   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5      #��z��5      $ 5��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      5       5!      .��5"      � $��10q�6    � RowDefinitions 5#   
   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $��* �6   .+�5*   
   �� $=��7Получение координат по адресу��6   $��0��68   $
��Bold"�5+      $��Center=�6"   $��18(�6@   �� 5-   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��0,10,0,0q�6;   .+�5.      �� $ ��Введите адрес:��6   �� 5/      -   5        	 ��Name$	 tbAdress��5/      $��Center=�6(   $	��5,0q�6J   $��Адрес...��50      
 �� TextWrapping$

 Wrap=�6%   $	��454��51      52      �� 54   
   -   5        $��
btGetCoord��54      $+��%Получить координаты��6#   $��2��6A   $��0,10,0,0q�6N   $	��180��6`   6l   �� 55   
   -   5        $��
lbGeoCoord��55      $�� ��6"   $��3��6-   $��Center=�6:   $��Center=�56      $��0,10,0,0q�64   $	��Top=�6F   .   (GMap.NET.WindowsPresentation.GMapControl  57   
   -   5          Name$
 gMap��57      $��4��6*   $��0,10,0,0q�67   58      59      