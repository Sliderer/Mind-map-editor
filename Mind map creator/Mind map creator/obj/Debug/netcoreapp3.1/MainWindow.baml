   M S B A M L   `   `   `  ����K  GMind map creator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Mind_map_creatorMind_map_creator  5   	   !    Mind_map_creator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Mind_map_creator     5   	   :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5         ButtonTemplate �� 
TargetType �� CornerRadius  StackPanelButton �� 
TargetType �� Property �� Value��%�   &	        &	 T     �� 5   
   " ��61   .R�5      �� $ 10��6   
�������5      5      �� 5   
   " ��6)   .�5      ��  � ��$ 1q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   .+�5"   
   �� -   5        $��Canvas��5$      
������� K� ZIndex$ 0��5#      z�5)      V� 5*      .~�5+      �� -   5        	scale��	 �� ScaleX$		 1.0Q�5+   4   
 �� ScaleY$	
 1.0Q�6A   5,      50      � 52   
   $��1��6   $ 1��53      
�������.+�55      �� -   5        $��ScaleSlider��5=      $	��100��55      $��Center=�57      $
��Left=�58      $��10, 0, 0 ,0q�59       � Value$ 0Q�5:       � Minimum$	 -10Q�5;       � Maximum$ 10Q�5<      5@      5E      �� 5G   
   -   5        $��ToolsButton��5N      #��[  5G      $��25��5H      $��25��5I      $ 1��5J      $
��Left=�5K      $	��Top=�5L      $��10, 100, 0, 0q�5M      5Q      �� 5_   
   -   5        $��ToolsBar��5_      $y�Visible=�5`      
�������$	��105��5b      $	��200��5c      $	��Top=�5d      $
��Left=�5e      $��
50,100,0,0q�5f       �� Orientation$ Vertical=�5g      .+�5j      �� $ 
Horizontal=�6   .+�5k      �� -   5        $��Drawpolyline��5m      $��25��5k      $��35��5l      $
��Draw��5o      #��[ 5p      5r      �� 5t      -   5        $��DrawRectangle��5v      $��25��5t      $��65��5u      $��	Rectangle��5x      #��[ 5y      5{      5|      �� 5~      $ 
Horizontal=�6   .+�5      �� -	   5        $��
DrawElipse��5�      $��25��5      $��50��5�      $��Elipse��5�      #��[ 5�      5�      �� 5�      -
   5        $��DrawLine��5�      #��[ 5�      $��25��5�      $��50��5�      $
��Line��5�      5�      5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� -   5         ��Name$ Rubber��5�      $��50��5�      $��25��5�      $
��Wipe��5�      #��[ 5�      5�      �� 5�      -   5        $ ColorPickerButton��5�      $��50��5�      $��25��5�      $��Color��5�      #��[ 5�      5�      5�      �� 5�      5�      �� 5�      $��Thinknes��6   �� 5�      -   5        $��StrokeThicknes��5�   .   $ 1Q�6   $ 10Q�6!   $��10q�6o   5�      5�      5�      