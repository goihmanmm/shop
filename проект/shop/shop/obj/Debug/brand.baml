   M S B A M L   `   `   `  ����?  ;shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:shopshop  5   	       
shop.brand   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:shop     5   	     � Title$  brand��5   	   $��359.302��6   $��472.094��6(    � 
ResizeMode$ NoResize=�68   .��5	      � .+�5
   
   �� -   5         ��Name$ 
tabControl��5
      $
��Left=�6)   $	��310��6D   $	��Top=�6Q   $	��446��6i   $��	10,10,0,0q�6u   .@�5      �� $%��Вывод информации��6   $��22��60   $	��Top=�6<   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $
��183* �6+   �� 5      $
��257* �6+   .+�5      �� -   5         ��Name$
 show��5      $��Вывести��6+   $
��Left=�6=   $��181,250,0,0q�6X   $	��Top=�6m   $��75��6�   $��2��6�   �� 5      -   5         ��Name$
 main��5      $
��Left=�6,   $	��235��6G   $��	10,10,0,0q�6T   $	��Top=�6g   $	��420��6   $��2��6�   5      5      �� 5      $'��!Добавление бренда��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5        $	 add��5      $��Добавить��6*   $
��Left=�6=   $��186,250,0,0q�6X   $	��Top=�6m   $��75��6�   6�   �� 5      -   5         ��Name$ addname��5      $
��Left=�6/   $��23��6J    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��420��6�   $��	10,44,0,0q�6�   �� 5      -   5        $ addemail��5      $
��Left=�60   $��23��6K   $
 Wrap=�6W   $	��Top=�6k   $	��420��6�   $��
10,195,0,0q�6�   �� 5      -   5        $ 	addadress��5      $
��Left=�61   $��23��6L   $
 Wrap=�6X   $	��Top=�6l   $	��420��6�   $��
10,120,0,0q�6�   �� 5      -   5         ��Name$ label��5      $2��,Введите название бренда��6+   $
��Left=�6M   $	��Top=�6h   $��	10,18,0,0q�6�   �� 5      -	   5        $ label1��5      $,��&Введите адрес бренда��6,   $
��Left=�6K   $	��Top=�6f   $��	10,89,0,0q�6~   �� 5      -
   5        $ label2��5      $'��!Введите email бренда��6,   $
��Left=�6K   $	��Top=�6f   $��
10,164,0,0q�6~   5      5      �� 5       $��Поиск бренда��6   $��24��6,   $��Bottom=�68   .��5!      � ���	#FFE5E5E5.+�5"      �� -   5        $ search��5"      $��
Найти��6-   $
��Left=�6=   $��182,250,0,0q�6X   $	��Top=�6m   $��75��6�   6�   �� 5#      -   5        $ searchbr��5#      $
��Left=�60   $��23��6K   $
 Wrap=�6W   $	��Top=�6k   $	��420��6�   $��	10,43,0,0q�6�   �� 5$      -   5        $ Search��5$      $
��Left=�6.   $	��144��6I   $	��Top=�6V   $	��420��6n   $��	10,87,0,0q�6z   �� 5%      -   5        $ label6��5%      $2��,Введите название бренда��6,   $
��Left=�6N   $	��Top=�6i   $��	10,10,0,0q�6�   $	��224��6�   5&      5'      �� 5)      $#��Удаление бренда��6   .��5*      � ���	#FFE5E5E5.+�5+      �� -   5        $ delete��5+      $��Удалить��6-   $
��Left=�6?   $��178,250,0,0q�6Z   $	��Top=�6o   $��75��6�   6�   �� 5,      -   5        $ delname��5,      $
��Left=�6/   $��23��6J   $
 Wrap=�6V   $	��Top=�6j   $	��420��6�   $��	10,44,0,0q�6�   �� 5-      -   5        $ 	deladress��5-      $
��Left=�61   $��23��6L   $
 Wrap=�6X   $	��Top=�6l   $	��420��6�   $��
10,113,0,0q�6�   �� 5.      -   5        $ delemail��5.      $
��Left=�60   $��23��6K   $
 Wrap=�6W   $	��Top=�6k   $	��420��6�   $��
10,183,0,0q�6�   �� 5/      -   5        $ label3��5/      $A��;Введите адрес удаляемого бренда��6,   $
��Left=�6V   $	��Top=�6q   $��	10,82,0,0q�6�   �� 50      -   5        $ label4��50      $<��6Введите email удаляемого бренда��6,   $
��Left=�6V   $	��Top=�6q   $��
10,152,0,0q�6�   �� 51      -   5        $ label5��51      $G��AВведите название удаляемого бренда��6,   $
��Left=�6Y   $	��Top=�6t   $��	10,13,0,0q�6�   52      53      54      56      57      