   M S B A M L   `   `   `  ����  ENL-Distrobution Storage+    %ENL_Distrobution_Storage.Order_Window   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Order_Window��5   	   $	��450��6   $	��800��6+   .��5      � .+�5	   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DTG_Orders��5	      $��	0,0,0,143q�6R   $��Center=�6e   $	��780��6�      AutoGenerateColumns$ False��6�   $	��281��6�   $��Bottom=�6�      Columns 5
      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
OrdersID+  5      $ 
Produkt ID��6%    69   �� *	ProduktID+  5      $ Produkt Name��6%    6;   �� *
NProduct+  5      $ 	Worker ID��6%    68   �� *
WorkerID+  5      $ worker Name��6%    6:   �� *	NWorker+  5      $ status��6%    65   �� *	OStatus+  5      $ Amount��6%    65   �� *OrderAmount+5      �� 5   
   -   5         ��Name$ 	BTN_close��5      $��close��6$   $��Right=�64   $��
0,0,691,82q�6P   $��Bottom=�6d   $��32��6   $��64��6�   6�   �� 5   
   -   5        $ 	BTN_Order��5      $��Order��6$   $��Right=�64   $��
0,0,565,82q�6P   $��Bottom=�6d   $��32��6   $��64��6�   6�   �� 5   
   -   5        $ 
BTN_remove��5      $��REMOVE��6%   $��Right=�66   $��
0,0,444,82q�6R   $��Bottom=�6f   $��32��6�   $��64��6�   6�   �� 5   
   -   5        $ BTN_edit_Order��5      $
��Edit��6)   $��Right=�68   $��
0,0,565,45q�6T   $��Bottom=�6h   $��32��6�   $��64��6�   6�   �� 5   
   -   5         ��Name$ TB_ID_Select��5      $
��Left=�6(   $��23��6C   $��572,320,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $��52��6�   
���   �
����������	#FF8989896�   �� 5   
   $��Use ID to select��6   $
��Left=�6+   $��475,318,0,0q�6F   $	��Top=�6[   5      5      