   M S B A M L   `   `   `  ����S  OENL-Distrobution Storage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ENL_Distrobution_StorageENL_Distrobution_Storage  5   	   *    $ENL_Distrobution_Storage.Productpage   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ENL_Distrobution_Storage     5   	     � Title$  Productpage��5   	   $	��450��6   $	��800��6*   .��5	      � $	��434��6   $��Center=�6   $��Right=�63   $	��800��6O   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DTG_products��5
      $��
0,0,10,157q�6)   $��Right=�6=   $	��780��6Y      AutoGenerateColumns$ False��6e   $��2��6�   $	��226��6�   $��Bottom=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductID+  5      $
 Name��6%    63   �� *ProductName+  5      $ Amount��6%    65   �� *ProductAmount+  5      $ Location(Row.Shelf)��6%    6B   �� *FormattedLocation+  5      $ Description��6%    6:   �� *ProductDescription+5      �� 5   
   -   5         ��Name$ BTN_close_window��5      $��close��6+   $��Right=�6;   $��
0,0,691,82q�6W   $��Bottom=�6k   $��32��6�   $��64��6�   6�   �� 5   
   -   5        $ BTN_add��5      $	��ADD��6"   $��Right=�60   $��
0,0,565,82q�6L   $��Bottom=�6`   $��32��6{   $��64��6�   6�   �� 5   
   -   5        $ 
BTN_remove��5      $��REMOVE��6%   $��Right=�66   $��
0,0,444,82q�6R   $��Bottom=�6f   $��32��6�   $��64��6�   6�   �� 5   
   -   5        $ BTN_edit��5      $
��Edit��6#   $��Right=�62   $��
0,0,565,45q�6N   $��Bottom=�6b   $��32��6}   $��64��6�   6�   �� 5   
   -   5         ��Name$ TB_ID_Select��5      $
��Left=�6(   $��23��6C   $��572,320,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $��52��6�   
���   �
����������	#FF8989896�   �� 5   
   $��Use ID to select��6   $
��Left=�6+   $��475,318,0,0q�6F   $	��Top=�6[   5      5      