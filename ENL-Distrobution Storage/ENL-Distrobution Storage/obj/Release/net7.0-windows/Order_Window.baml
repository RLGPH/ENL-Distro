   M S B A M L   `   `   `  ����   ENL-Distrobution Storage+    %ENL_Distrobution_Storage.Order_Window   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Order_Window��$	��450��$	��800��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ 
DTG_Orders��$��	0,0,0,143q�$��Center=�$	��780��   AutoGenerateColumns$ False��$	��281��$��Bottom=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
OrdersID+  $ 
Produkt ID�� �� *	ProduktID+  $ Produkt Name�� �� *
NProduct+  $ 	Worker ID�� �� *
WorkerID+  $ worker Name�� �� *	NWorker+  $ status�� �� *	OStatus+  $ Amount�� �� *OrderAmount+�� -    ��Name$ 	BTN_close��$��close��$��Right=�$��
0,0,691,82q�$��Bottom=�$��32��$��64���� -   $ 	BTN_Order��$��Order��$��Right=�$��
0,0,565,82q�$��Bottom=�$��32��$��64���� -   $ 
BTN_remove��$��REMOVE��$��Right=�$��
0,0,444,82q�$��Bottom=�$��32��$��64���� -   $ BTN_edit_Order��$
��Edit��$��Right=�$��
0,0,565,45q�$��Bottom=�$��32��$��64���� -    ��Name$ TB_ID_Select��$
��Left=�$��23��$��572,320,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$��52��
���   �
����������	#FF898989�� $��Use ID to select��$
��Left=�$��475,318,0,0q�$	��Top=�