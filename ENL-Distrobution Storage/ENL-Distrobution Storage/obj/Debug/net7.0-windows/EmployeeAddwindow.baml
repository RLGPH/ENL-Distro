   M S B A M L   `   `   `  ����S  OENL-Distrobution Storage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ENL_Distrobution_StorageENL_Distrobution_Storage  5   	   0    *ENL_Distrobution_Storage.EmployeeAddwindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ENL_Distrobution_Storage     5   	     � Title$  Product_add_window��5   	   $	��340��6$   $	��440��61   .��5	      � .+�5
   
   �� -   5         ��Name$ TB_First_name��5
      $
��Left=�6)   $��	98,15,0,0q�6D    �� TextWrapping$
 Wrap=�6W   $��
First Name��6k   $	��Top=�6}   $��22��6�   $	��204��6�   �� 5   
   -   5         ��Name$ dev_here_pls_kill_me��5      $��
First Name��6.   $
��Left=�6C   $��	27,10,0,0q�6^   $	��Top=�6q   �� 5   
   -   5        $ TB_Last_Name��5      $
��Left=�6(   $��	98,41,0,0q�6C   $
 Wrap=�6V   $��	Last Name��6j   $	��Top=�6{   $	��204��6�   $��19��6�   �� 5   
   -   5        $ TB_Mail��5      $
��Left=�6#   $��	98,68,0,0q�6>   $
 Wrap=�6Q   $��Exampl@mail.com��6e   $	��Top=�6|   $	��204��6�   $��19��6�   �� 5   
   -   5        $ TB_Tlf_number��5      $
��Left=�6)   $��	98,98,0,0q�6D   $
 Wrap=�6W   $��Example +45 12345678��6k   $	��Top=�6�   $	��204��6�   $��19��6�   �� 5   
   -   5        $ TB_Job_Tital��5      $
��Left=�6(   $��
98,122,0,0q�6C   $
 Wrap=�6W   $��	Job Tital��6k   $	��204��6|   $��19��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ BTN_ADD��5      $��ADD Employee��6"   $
��Left=�69   $��
17,217,0,0q�6T   $	��Top=�6h   $��32��6�   $	��139��6�   6�   �� 5   
   -   5        $ 
BTN_cancel��5      $��Cancel��6%   $
��Left=�66   $��
22,180,0,0q�6Q   $	��Top=�6e   $��32��6}   $��44��6�   6�   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��	33,37,0,0q�6?   $��65��6R   $��26��6]   $	��Top=�6i   �� 5   
   $
��Mail��6   $
��Left=�6   $��	61,67,0,0q�6:   $	��Top=�6M   $��65��6e   �� 5   
   $	��TLF��6   $
��Left=�6   $��	61,91,0,0q�69   $	��Top=�6L   $��65��6d   �� 5   
   $��	Job Tital��6   $��
42,115,0,0q�6$   $	��Top=�68   $
��Left=�6P   $��67��6k   �� 5   
   -	   5         ��Name$ 	CB_Status��5      $
��Left=�6&   $��182,151,0,0q�6A   $	��Top=�6V   $	��120��6n   .@�5      �� $
��Free��6   
 � Tag$ 0��6*   �� 5      $��Working on order��6   $ 1��66   �� 5      $
��Busy��6   $ 2��6*   5      �� 5   
   $��Status��6   $��114,150,0,0q�6!   $��24��66   $	��Top=�6B   $
��Left=�6Z   $��42��6u   �� 5   
   -
   5        $ BTN_Save_Change��5      $��Save Change��6*   $
��Left=�6@   $��
17,254,0,0q�6[   $	��Top=�6o   $��32��6�   $	��139��6�   6�   �� 5   
   $��Working on Employee ID :��6   $
��Left=�63   $��180,192,0,0q�6N   $	��Top=�6c    J� RenderTransformOrigin$ 0.516,0.505&�6{   �� 5   
   -   5        $ TB_ID��5      $
��Left=�6!   $��324,195,0,0q�6<   $
 Wrap=�6Q   $��New Employee��6e   $	��Top=�6y   $��26��6�   $��93��6�   
���   �
������� �� SelectionBrush
 �����	 �� 
IsReadOnly$
	 True��6�   $ 0.5,0.5&�6�   �� 5   
   $��Orders complete :��6   $
��Left=�6,   $��182,223,0,0q�6G   $	��Top=�6\   �� 5    
   -   5        $ TB_Completed_oreders��5       $
��Left=�60   $��291,226,0,0q�6K   $
 Wrap=�6`   $��0��6t   $	��Top=�6}   $��26��6�   $��93��6�   
���   �
�������
 �����$
	 True��6�   $ 0.5,0.5&�6�   5!      5"      