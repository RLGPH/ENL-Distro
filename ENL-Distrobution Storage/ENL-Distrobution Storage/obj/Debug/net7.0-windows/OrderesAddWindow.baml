   M S B A M L   `   `   `  ����S  OENL-Distrobution Storage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ENL_Distrobution_StorageENL_Distrobution_Storage  5   	   /    )ENL_Distrobution_Storage.OrderesAddWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ENL_Distrobution_Storage     5   	     � Title$  Product_add_window��5   	   $	��400��6$   $	��680��61   .��5	      � -   5         �Name$ CB_product_or_employee��5	       J� RenderTransformOrigin$ 0.501,0.504&�6+   .+�5
   
   �� -   5         ��Name$ BTN_Complete_order��5
      $��Complete Order��6-   $
��Left=�6F   $��356,248,0,0q�6a   $	��Top=�6v   $��38��6�   $	��100��6�   6�   �� 5   
   -   5        $ 
BTN_cancel��5      $��Cancel��6%   $
��Left=�66   $��253,291,0,0q�6Q   $��54��6f   $��37��6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$! DTG_things_to_order_and_who��5      $��	10,52,0,0q�6c   $
��Left=�6v   $	��238��6�   $	��275��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ CB_Products_Employees��5      $
��Left=�62   $��	10,25,0,0q�6M   $	��Top=�6`   $	��120��6x   .@�5      �� $��Products��6   
 � Tag$ 0��6.   �� 5      $��	Employees��6   $ 1��6/   5      �� 5   
   -   5        $ BTN_add��5      $��ADD To Order��6"   $
��Left=�69   $��253,248,0,0q�6T   $	��Top=�6i   $��38��6�   $��88��6�   6�   �� 5   
   -   5         ��Name$ 
TB_nworker��5      $
��Left=�6&   $��
346,56,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $��
Pending...��6i   $	��Top=�6{   $	��120��6�   	 �� 
IsReadOnly$
	 True��6�   
�������6�   �� 5   
   $��Workers Name��6   $
��Left=�6'   $��
253,52,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $ TB_workerID��5      $
��Left=�6'   $��
346,82,0,0q�6B   $
 Wrap=�6V   $��
Pending...��6j   $	��Top=�6|   $	��120��6�   $
	 True��6�   
�������6�   �� 5   
   $��WorkerID��6   $
��Left=�6#   $��
253,77,0,0q�6>   $	��Top=�6R   $��88��6j   �� 5   
   -	   5        $ TB_nproduct��5      $
��Left=�6'   $��346,108,0,0q�6B   $
 Wrap=�6W   $��
Pending...��6k   $	��Top=�6}   $	��120��6�   $
	 True��6�   
�������6�   �� 5   
   $��Product Name��6   $
��Left=�6'   $��253,104,0,0q�6B   $	��Top=�6W   �� 5   
   -
   5        $ TB_productID��5      $
��Left=�6(   $��346,131,0,0q�6C   $
 Wrap=�6X   $��
Pending...��6l   $	��Top=�6~   $	��120��6�   $
	 True��6�   
�������6�   �� 5   
   $��
Product ID��6   $
��Left=�6%   $��258,127,0,0q�6@   $	��Top=�6U   �� 5   
   -   5        $ TB_Order_Status��5      $
��Left=�6+   $��346,192,0,0q�6F   $
 Wrap=�6[   $��
Pending...��6o   $	��Top=�6�   $	��120��6�   $
	 True��6�   
�������6�   �� 5   
   $��Order status��6   $
��Left=�6'   $��258,188,0,0q�6B   $	��Top=�6W   $��81��6o   �� 5   
   -   5        $ 
TB_OrderID��5      $
��Left=�6&   $��346,215,0,0q�6A   $
 Wrap=�6V   $��	New order��6j   $	��Top=�6{   $	��120��6�   $
	 True��6�   
�������6�   �� 5   
   $��Order ID��6   $
��Left=�6#   $��259,211,0,0q�6>   $	��Top=�6S   �� 5   
   $��Quantity��6   $
��Left=�6#   $��261,158,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ TB_Quantity��5      $
��Left=�6'   $��346,162,0,0q�6B   $
 Wrap=�6W   $-��'Please add a quantity                  ��6k   $	��Top=�5       $	��120��6,   �� 5!   
   -   5        $ BTN_save_change��5!      $��Save change��6*   $
��Left=�6@   $��356,291,0,0q�6[   $	��Top=�6p   $��37��6�   $	��100��6�   6�   �� 5"   
   -   5        $ 	CB_Status��5"      $
��Left=�6&   $��486,192,0,0q�6A   $	��Top=�6V   $	��120��6n   .@�5#      �� $��Pending_Work��6   $ 0��62   �� 5$      $��Being_Worked_On��6   $ 1��65   �� 5%      $��Finished��6   $ 2��6.   5&      5'      5(      