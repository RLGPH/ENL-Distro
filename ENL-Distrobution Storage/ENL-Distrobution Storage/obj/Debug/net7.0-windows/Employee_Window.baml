   M S B A M L   `   `   `  ����S  OENL-Distrobution Storage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ENL_Distrobution_StorageENL_Distrobution_Storage  5   	   .    (ENL_Distrobution_Storage.Employee_Window   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ENL_Distrobution_Storage     5   	     � Title$  Employee_Window��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DTG_Employee��5
      $��	0,0,0,143q�6T   $��Center=�6g   $	��780��6�      AutoGenerateColumns$ False��6�   $	��281��6�   $��Bottom=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
WorkerID+  5      $ 
First Name��6%    69   �� *	FirstName+  5      $ 	Last Name��6%    68   �� *
LastName+  5      $ 	Job tital��6%    68   �� *
Jobtitel+  5      $	 TLF��6%    62   �� *Tlf+  5      $
 Mail��6%    63   �� *Email+  5      $ Amount Of Orders��6%    6?   �� *Amount+  5      $ Status��6%    65   �� *Status+5      �� 5   
   -   5         ��Name$ BTN_close_window��5      $��close��6+   $��Right=�6;   $��
0,0,691,82q�6W   $��Bottom=�6k   $��32��6�   $��64��6�   6�   �� 5   
   -   5        $ BTN_add��5      $	��ADD��6"   $��Right=�60   $��
0,0,565,82q�6L   $��Bottom=�6`   $��32��6{   $��64��6�   6�   �� 5   
   -   5        $ 
BTN_remove��5      $��REMOVE��6%   $��Right=�66   $��
0,0,444,82q�6R   $��Bottom=�6f   $��32��6�   $��64��6�   6�   �� 5   
   -   5        $ BTN_edit��5      $
��Edit��6#   $��Right=�62   $��
0,0,565,45q�6N   $��Bottom=�6b   $��32��6}   $��64��6�   6�   �� 5   
   -   5         ��Name$ TB_ID_Select��5      $
��Left=�6(   $��23��6C   $��572,320,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $��52��6�   
���   �
����������	#FF8989896�   �� 5   
   $��Use ID to select��6   $
��Left=�6+   $��475,318,0,0q�6F   $	��Top=�6[   5      5      