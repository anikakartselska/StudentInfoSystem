   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseItHome   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      � $��
10,0,10,10q�6   .+�5
   
   �� $��1��6   ��6    ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" � �� Path$ MainCaptionText�6�   �� 5   
    �� Padding$ 5q�6   ���#4E87D4$��1��62   $��543,10.4,0,145.4q�6?   $��2��6Y   ._�5      �� $��Center=�6   $��1��60   
�������$��5.2,-5.8,-4.4,5.4q�6P   .��6k   Names6r   5      �� 5   
   -   5         ��Name$ 	MyListBox��5   /   $��1��6   $��1��6"   $��0,67.4,0,25.4q�6B    �� DisplayMemberPath$
 Name��5      ��5   Y   ��  �� " �$ ExpenseDataSource�5      �� 5   
   $��1��6   $��10,67.4,5,25.4q�6K   ��6   �� $ PersonsChecked�6K   �� 5   
   -   5        $��0,10,0,0q�5      $��2��6#   $��3��63   $	��125��6@   $��25��6L   $��Right=�6X   ��6�   ��  �� ElementName$ 	MyListBox��$ SelectedItem.Name�6�   �� 5   
   $��0��6   $��3��6    $��-10,0,10,0.4q�6M   ��6-   �� *LastChecked+6M   ��5   
   �� 5      	 �� ImageSource$	 watermark.png.jpeg��6   
 � ColumnDefinitions
 5   
   �� 5      �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5       $
��Auto �6   �� 5!      5#      5$      