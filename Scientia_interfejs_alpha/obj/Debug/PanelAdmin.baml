   M S B A M L   `   `   `  ����S  OScientia_interfejs_alpha, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Scientia_interfejs_alphaScientia_interfejs_alpha  5   	   )    #Scientia_interfejs_alpha.PanelAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Scientia_interfejs_alpha     5   	   -   5          � Title$  
PanelAdmin��5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowState$ 	Maximized=�6A    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5	      �  � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      o� $	��Top=�6   ��5      �� 5      .R�5      ]� $��Stretch=�6$   5      .@�5      m� $��Opcje Administracyjne��6   .@�5      m� -   5         m�Name$ 
MIedytczlo��5      $��Edytuj Członków��63   6L   m� 5      -   5        $ 
MIedytzaso��5      $��Edytuj Zasoby��63   6J   5      m� 5      $��Wyloguj��6   $��Right=�6,   .@�5      m� -   5        $ MIzamk��5      $��Zamknij program��6/    m� Icon 5      �� 5      $��image/close.png��6$   $��20��6=   5      �� 5      m� 5       -   5        $ MIwroc��5       $��Wróć do przeglądania��6E    5!      �� 5"      $��image/back.png��6$   $��20��6<   5$      5%      5&      5'      �� 5(   
   $��1��6   .@�5)      �� $��Wypożycz/Oddaj��6   .��5*      �  5+      �� 5,      $��* �6(   �� 5-      $��* �6(   �� 5.      $��* �6(   �� 5/      $��* �6(   �� 50      $��* �6(   �� 51      $��* �6(   �� 52      $��* �6(    � ColumnDefinitions 54      �� 55      $	��74* �6+   �� 56      $	��30* �6+   �� 57      $
��104* �6+   �� 58      $
��104* �6+   �� 59      $
��104* �6+   �� 5:      $
��104* �6+   �� 5;      $
��103* �6+   .+�5=      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dgsprzet��5=      
   AutoGenerateColumns
 .  $��0��6M   $��0��6]   $��5��6j   $��7��6~      
IsReadOnly .    SelectionMode$ Single=�6�    �� SelectedValuePath$ 	ID_zasobu��6�    �� SelectedValue 6�   �� *	ID_zasobu+   Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 150* 61      Header$ Sprzęt��6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *Nazwa+  5@      $
 150* 61   $ 	Kategoria��6>    6Q   �� *	Kategoria+  5A      $
 200* 61   $ Opis sprzętu��6>    6T   �� *Opis+  5B      $
 100* 61   $ Stan techniczny��6>    6W   �� *Stan_techniczny+4  .System.Windows.Controls.DataGridCheckBoxColumn  5C      $
 100* 66   $ Czy wypożyczalny��6C    6]   �� *Czy_wypozyczalny+  5D      $
 100* 66   $ Stan wypożyczenia��6C    6_   �� *Status_wypozyczenia+  5E      $
 100* 61   $ Data Wypożyczenia��6>    6Y   �� *Data_wypozyczenia+  5F      $
 100* 61   $ Data Zwrotu��6>    6S   �� *
Data_zwrot+  5G      $
 100* 61   $ Przez Kogo?��6>    6S   �� *Kto+5I      �� 5J      $��6��6!   $��3��61   $��10q�6>   .+�5K      	� -   5         	�Name$ RBczl��5K   &    	� 	GroupName$ RBkto��65   6G   �� 5L      $��Członek koła��6    	� 5M      -   5        $ RBgosc��5M   &   $ RBkto��66   6H   �� 5N      $��Gość��6    5O      �� 5P      -	   5         ��Name$ SPdane��5P   !   $��6��61   $��4��6A   $y�Hidden=�6N   .+�5Q      �� -
   5         ��Name$ 
txtboximie��5Q   "   $	��200��66   $	��Top=�6B   $
��Left=�6Z   $��0,5,0,5q�6u   �� 5R      -   5        $ txtboxnazwisko��5R   "   $��20��6:   $	��200��6F   $	��Top=�6R   $
��Left=�6j   $��0,0,0,5q�6�   �� 5S      -   5        $ txtboxnumer��5S   "   $��20��67   $	��200��6C   $	��Top=�6O   $
��Left=�6g   5T      �� 5U      -   5         ��Name$ CBkto��5U      $��6��6.   $��4��6>   $��20��6K   $	��200��6W   $	��Top=�6c   $
��Left=�6{    �� 
IsEditable . $y�Hidden=�6�   $ id��6�    �� DisplayMemberPath$
 dane��6�   5W      (  "System.Windows.Controls.DatePicker  5X      -   5          Name$ DPdzis��5X   !   $��6��61   $
��Left=�6A   $��1��6]   $	��Top=�6j   {�.  6�     5Y      -   5        $ 	DPdokiedy��5Y   !   $��6��64   $
��Left=�6D   $	��Top=�6`   $��2��6x   �� 5Z      -   5         ��Name$ 
lbldzisiaj��5Z      $��Data dzisiejsza��60   $��5��6J   $��Right=�6Z   $��1��6v   $	��Top=�6�   �� 5[      -   5        $ lblkom��5[      $#��Podaj osobę wypożyczającą��6,   $��5��6P   $��Right=�6`   $��3��6}   $	��Top=�6�   �� 5\      -   5        $ SPlbl��5\   !   $��5��60   $��4��6@   $y�Hidden=�6M   .+�5]      �� -   5        $ lblimie��5]       $(��"Podaj imię osoby wypożyczającej��61   $��Right=�6[   $	��Top=�6w   �� 5^      -   5        $ lblnazw��5^       $+��%Podaj nazwisko osoby wypożyczającej��61   $��Right=�6_   $	��Top=�6{   �� 5_      -   5        $ lblnumer��5_       $1��+Podaj numer telefonu osoby wypożyczającej��62   $��Right=�6f   $	��Top=�6�   5`      �� 5a      -   5        $ lblkto2��5a      $'��!Wybierz imię i nazwisko członka��6-   $��5��6W   $��Right=�6g   $��4��6�   $	��Top=�6�   $y�Hidden=�6�   �� 5b      -   5        $ 
lblwybierz��5b      $��Wybierz datę zwrotu��60   $��5��6N   $��Right=�6^   $��2��6z   $	��Top=�6�   �� 5c      -   5         ��Name$ btnwypozycz��5c      $��	Wypożycz��62   $��6��6E   $��6��6U   6b   �� 5d      -   5        $ btnoddaj��5d      $��Oddaj��6/   $��5��6?   $��6��6O   6\   5e      5f      �� 5g      $��Przeglądaj wypożyczenia��6   .��5h      �  5i      �� 5j      $��* �6+   �� 5k      $��* �6+   .+�5m        -   5        $	 
DGprzeglad��5m       5n        5o      $	 200 61   $ Sprzęt��6=    6M   �� *Nazwa+  5p      $	 200 61   $ 	Kategoria��6=    6P   �� *	Kategoria+  5q      $	 200 61   $ Stan techniczny��6=    6V   �� *Stan_techniczny+  5r      $	 200 66   $ Czy wypożyczalny��6B    6\   �� *Czy_wypozyczalny+  5s      $	 200 66   $ Stan wypożyczenia��6B    6^   �� *Status_wypozyczenia+  5t      $	 150 61   $ Data Zwrotu��6=    6R   �� *
Data_zwrot+  5u      $	 200 61   $ Przez Kogo?��6=    6R   �� *Kto+5w      5x      5y      5z      �� 5{   
   
���   �$��1q�6%   $
��Left=�69   $	��100��6T   $��282,-53,0,0q�6a   $��2��6v   $	��Top=�6�   $	��100��6�   5|      5}      