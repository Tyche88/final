   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjectFinal.ItemsProjectFinal.Items  5   	   !    ProjectFinal.Items.wndItems   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjectFinal.Items     5   	   -   5          � Title$  Items��5	   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��listItemDisplay��5   �   $
��Left=�6   $	��399��6.   $��	10,10,0,0q�6;   $	��Top=�6N   $	��361��6f      
IsReadOnly . 6�   �� 5   
   $��Add Item��6   $
��Left=�6%   $	��193��6@   $��
376,35,0,0q�6M   $	��Top=�6a   $	��406��6y   .��5      � $
��Left=�6   $	��157��6.   $��
10,10,-2,0q�6;   $	��Top=�6O   $	��386��6g   .+�5      �� -   5        $��inputAddCost��5   �    �� 	MaxLength$ 19��6   $
��Left=�6)   $��23��6D   $��
161,10,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $��$0.00��6x   $	��Top=�6�   $	��215��6�   6�   �� 5      -   5        $��inputAddDescription��5   �   $ 50��6   $
��Left=�6)   $��23��6D   $��
161,74,0,0q�6P   $
 Wrap=�6d   $��Item Description��6x   $	��Top=�6�   $	��215��6�   6�   �� 5      -   5        $��buttonAddItem��5   l   $
��Left=�6   $��
10,125,0,0q�64   $	��Top=�6H   $	��366��6`   .��5      �� $
��Wrap=�6    $��Add New Item��64   5      �� 5      $
��Cost��6   $
��Left=�6'   $��15,6,0,0q�6B   $	��Top=�6T   $	��146��6l   �� 5      $��Description��6   $
��Left=�6.   $��	15,70,0,0q�6I   $	��Top=�6\   $	��141��6t   5      5      �� 5   
   $��	Edit Item��6   $
��Left=�6&   $	��151��6A   $��376,233,0,0q�6N   $	��Top=�6c   $	��406��6{   .��5      � $
��Left=�6   $	��141��6.   $��10,0,-2,-12q�6;   $	��Top=�6P   $	��386��6h   .+�5      �� -   5        $��inputEditCost��5   )   $ 19��6   $
��Left=�6>   $��23��6Y   $��
172,10,0,0q�6e   $
 Wrap=�6y   $�� ��6�   $	��Top=�6�   $	��204��6�    �� 
IsReadOnly . ��.  6�   �� 5      -   5        $��inputEditDescription��5   )   $ 50��6   $
��Left=�6E   $��23��6`   $��
172,57,0,0q�6l   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��204��6�   ��.   . 6�   �� 5      $
��Cost��6   $
��Left=�6'   $��10,6,0,0q�6B   $	��Top=�6T   $	��157��6l   �� 5      $��Description��6   $
��Left=�6.   $��	10,54,0,0q�6I   $	��Top=�6\   $	��157��6t   �� 5      -   5        $��buttonEditItem��5   �   $
��Left=�6   $��
10,104,0,0q�64   $	��Top=�6H   $	��366��6`   {�.  .��5      �� $
��Wrap=�6    $��Edit Existing Item��64   5      5       5!      �� 5"   
   -	   5        $��buttonDeleteItem��5"   e   $
��Left=�6   $��376,389,0,0q�6,   $	��Top=�6A   $	��406��6Y   {�.  .��5#      �� $
��Wrap=�6   $��Delete Item��6,   5$      �� 5%   
   -
   5        $��
buttonExit��5%   �   $
��Left=�6   $��
376,10,0,0q�6,   $	��Top=�6@   $	��406��6X    J� RenderTransformOrigin$ 
0.48,0.493&�6d   .��5&      �� $
��Wrap=�6   $��Return��6,   5'      5(      5)      