   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	   D @projekcik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:projekcik;assembly=projekcik	projekcik 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6F       GUI.Wypożyczenie   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   @	projekcik*clr-namespace:projekcik;assembly=projekcik     5   	   9System&clr-namespace:System;assembly=mscorlib     6F     � Title$  Wypożyczenie��5	   	   $	��450��6   $	��800��6+   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��30* �6   �� 5      $
��367* �6   .+�5   
   �� $
��Left=�6   $��30��6-   $��	40,40,0,0q�69    �� TextWrapping$
 Wrap=�6L   $
��Film��6`   $	��Top=�6l   $	��120��6�   $��2��6�   �� 5   
   $
��Left=�6   $��25��6-   $��	40,80,0,0q�69   $
 Wrap=�6L   $��Klient��6`   $	��Top=�6n   $	��120��6�   $��2��6�   �� 5   
   $
��Left=�6   $��23��6-   $��
40,120,0,0q�69   $
 Wrap=�6M   $��Data od ��6a   $	��Top=�6q   $	��120��6�   $��2��6�   �� 5   
   $
��Left=�6   $��23��6-   $��
40,160,0,0q�69   $
 Wrap=�6M   $��Data do��6a   $	��Top=�6p   $	��120��6�   $��2��6�   �� 5   
   -   5         ��Name$ 
Data_odTXT��5      $
��Left=�6&   $��23��6A   $��125,120,0,0q�6M   $
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5   
   -   5        $ 
Data_doTXT��5      $
��Left=�6&   $��23��6A   $��125,160,0,0q�6M   $
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5   
   -   5         ��Name$ FilmCOMB��5      $
��Left=�6%   $��30��6@   $��
125,40,0,0q�6L   $	��Top=�6`   $	��120��6x   $��1��6�   5      �� 5   
   -   5        $ 
KlientCOMB��5      $
��Left=�6'   $��30��6B   $��
125,75,0,0q�6N   $	��Top=�6b   $	��120��6z   $��1��6�   �� 5   
   -   5         ��Name$ ZatBTN��5      $��2��6!   $��
Zatwierdź��65   $
��Left=�6I   $��25��6d   $��
40,220,0,0q�6p   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $ AnulBTN��5      $��Anuluj��6"   $
��Left=�63   $��25��6N   $��125,220,0,0q�6Z   $	��Top=�6o   $	��120��6�   $��1��6�   6�   5      5      