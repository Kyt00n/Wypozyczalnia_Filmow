   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       GUI.Window_Film   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Window_Film��5	   	   $	��450��6   $	��800��6*   .��5
      � .+�5   
   �� $��Tytuł film��6   $
��Left=�6%   $��45��6@   $��	10,10,0,0q�6L   $	��Top=�6_   $��80��6w   �� 5   
   $��Rezyser��6   $
��Left=�6"   $��30��6=   $��	10,60,0,0q�6I   $	��Top=�6\   $��55��6t   �� 5   
   $��Kraj produkcji��6   $
��Left=�6)   $��30��6D   $��
10,110,0,0q�6P   $	��Top=�6d   $	��100��6|   �� 5   
   $��Długość (w min)��6   $
��Left=�6*   $��35��6E   $��
10,165,0,0q�6Q   $	��Top=�6e   $	��100��6}   �� 5   
   $��Gatunek��6   $
��Left=�6"   $��25��6=   $��
10,220,0,0q�6I   $	��Top=�6]   $��80��6u   �� 5   
   -   5         ��Name$ GatunekCombo��5      $
��Left=�6)   $��25��6D   $��145,220,0,0q�6P   $	��Top=�6e   $	��170��6}   .@�5      ��
horror��6$   ��5      western��6%   ��5      wojenny��6%   ��5      
dramat��6$   ��5      
melodramat��6(   ��5      
sensacyjny��6(   ��5      musical��6%   ��5      
przygodowy��6(   ��5      	kryminał��6&   ��5      fantasy��6%   ��5      komedia��6%   5      �� 5   
   -   5         ��Name$ 
DlugoscTXT��5      $
��Left=�6&   $��35��6A   $��145,165,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��150��6�   �� 5   
   -   5        $ KrajTXT��5      $
��Left=�6#   $��30��6>   $��145,110,0,0q�6J   $
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $	��130��6�   �� 5   
   -   5        $ ReżyserTXT��5      $
��Left=�6&   $��30��6A   $��
145,60,0,0q�6M   $
 Wrap=�6a   $��TextBox��6u   $	��Top=�6�   $	��130��6�   �� 5    
   -   5        $ TytTXT��5       $
��Left=�6"   $��30��6=   $��
145,10,0,0q�6I   $
 Wrap=�6]   $��TextBox��6q   $	��Top=�6�   $	��130��6�   �� 5!   
   -   5         ��Name$ 	ZATbutton��5!      $��
Zatwierdź��6$   $
��Left=�68   $��30��6S   $��
30,320,0,0q�6_   $	��Top=�6s   $	��145��6�   6�   �� 5"   
   -   5        $ AnulujBUTTON��5"      $��Anuluj��6'   $
��Left=�68   $��30��6S   $��225,320,0,0q�6_   $	��Top=�6t   $	��160��6�   6�   �� 5#   
   -   5        $ CenaTXT��5#      $
��Left=�6#   $��20��6>   $��145,274,0,0q�6J   $
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $��80��6�   �� 5$   
   $
��Cena��6   $
��Left=�6   $��45��6:   $��
10,270,0,0q�6F   $	��Top=�6Z   $��55��6r   5&      5'      