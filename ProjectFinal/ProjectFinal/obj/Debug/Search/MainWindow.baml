   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:wndSearch	wndSearch  5   	       wndSearch.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:wndSearch     5   	     � Title$  Search��5   	   $	��450��6   $	��800��6%   $��14(�61   $
��Bold"�6?    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ invoiceGrid��5      $
��Left=�6(   $��
23,223,0,0q�6C   $	��186��6W   $	��558��6d   $	��Top=�6p   ���	#FF7095B9   HorizontalGridLinesBrush �	#FF0A047E   VerticalGridLinesBrush �	#FF0A047E$��14(�6�   $��Book Antiqua)�6�   $��2��6  �� 5   
   -   5         ��Name$ cmboxInvoiceID��5      $
��Left=�6+   $��
50,140,0,0q�6F   $	��Top=�6Z   $	��150��6r   6~   �� 5   
   -   5        $ cmboxInvoicePrice��5      $
��Left=�6.   $��345,140,0,0q�6I   $	��Top=�6^   $	��150��6v   $��2��6�   �� 5   
   -   5        $ cmboxInvoiceDate��5      $
��Left=�6-   $��218,143,0,0q�6H   $	��Top=�6]   $	��150��6u   $��1��6�   6�   �� 5   
   -   5         ��Name$ 	cmdSelect��5      $��Select��6$   $
��Left=�65   $��206,226,0,0q�6P   $	��Top=�6e   $	��162��6}   $��65��6�   $��18(�6�   $��1��6�   6�   �� 5   
   -   5        $ 	cmdCancel��5      $��Cancel��6$   $
��Left=�65   $��206,328,0,0q�6P   $	��Top=�6e   $	��162��6}   $��65��6�   $��18(�6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ lblInvoiceID��5      $��
Invoice ID��6&   $
��Left=�6;   $��
50,101,0,0q�6V   $	��Top=�6j   $��18(�6�   $
��Bold"�6�   �� 5   
   -   5        $ lblInvoicePrice��5      $��Invoice Price��6)   $
��Left=�6A   $��345,101,0,0q�6\   $	��Top=�6q   $��18(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   -	   5        $ lblInvoiceDate��5      $��Invoice Date��6(   $
��Left=�6?   $��218,104,0,0q�6Z   $	��Top=�6o   $��18(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   -
   5        $ lblInvoiceChoice��5      $4��.Please select the invoice of your choice below��6*   $
��Left=�6c   $��133,184,0,0q�6~   $	��Top=�6�   $��18(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   -   5        $ lblTitle��5      $��Invoice Search Form��6"   $
��Left=�6@   $��
162,22,0,0q�6[   $	��Top=�6o   $��48(�6�   $
��Bold"�6�   $��2��6�   5      5      