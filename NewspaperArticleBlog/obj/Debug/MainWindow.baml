   M S B A M L   `   `   `  ����O  KNewspaperArticleBlog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:NewspaperArticleBlogNewspaperArticleBlog  5   	   %    NewspaperArticleBlog.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4local"clr-namespace:NewspaperArticleBlog     5   	     � Title$  Newspaper Blog��5   	   $	��650��6    $
��1000��6-    � 
ResizeMode$ CanMinimize=�5   	   .��5      � $��12(�6    � RowDefinitions 5	   
   �� 5
      $��80 �6   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��4��6   ��5      �� 5       �� ImageSource$ /Images/header.png��6    j� Stretch$ UniformToFill=�6>   5      ]� 5   
   $��3��6   $��2��6%   $��1��69   .+�5      "   NewspaperArticleBlog.Toolbar  -   5          Name$ toolBar��5      $	��Top=�5   "   �� 5       $��Bottom=�6   .@�5!      �� -   5         ��Name$ status��5!      5"          NewspaperArticleBlog.Image  5#      -   5          Name$ image��5#      $��Bottom=�5$   "   �� 5%      -   5        	 ��Name$
	 body��5%      
 �� 	IsEnabled
 .  �� AcceptsReturn .  �� 
AcceptsTab . $��0 2 0 0q�5)      ��. $
��Auto=�5+      5,      �� 5.   
   $��1��6   $��3��5/      $��1��50      $��2��51      
������� �� ResizeBehavior$ PreviousAndNext=�53       �� ResizeDirection$ Columns=�54      � 56   
   $��2��6   $��2��6   $��3��63   $��1��6D   .+�57      &    NewspaperArticleBlog.BlogControl  -   5          Name$
 Blog��57       58      59      5:      