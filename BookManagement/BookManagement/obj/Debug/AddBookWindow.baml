   M S B A M L   `   `   `  ����I  EBookManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BookManagementBookManagement  5   	   "    BookManagement.AddBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BookManagement     5   	     � Title$%  Добавление книги��5   	   $	��300��6"   $	��300��6/    � WindowStartupLocation$ CenterScreen=�6;   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��0��6   $��0��6    $��Выберите тему��6-   �� 5   
   -   5         ��Name$ comboThemes��5   0   $��0��6   $��1��6#   60   �� 5   
   $��0��6   $��2��6    $#��Выберите автора��6-   �� 5   
   -   5        $ comboAuthor��5   0   $��0��6   $��3��6#   60   �� 5   
   $��0��6   $��4��6    $0��*Введите название книги��6-   �� 5   
   -   5         ��Name$ textBoxBookName��5   /   $��0��6   $��5��6"   6/   �� 5   
   $��0��6   $��6��6    $0��*Введите описание книги��6-   �� 5    
   -   5        $ textBoxDescr��5    �   $��0��6   $��7��6"   $��2��6/    �� TextWrapping$
 Wrap=�6@   " �� VerticalScrollBarVisibility$
 Auto=�6T    �� AcceptsReturn . 6�   �� 5!   
   -   5        	 ��Name$	 buttonAddBook��5!   .   $��0��6   $��9��6!   $��Добавить��6a   5"      5$      