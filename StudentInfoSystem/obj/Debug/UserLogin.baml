   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   !    StudentInfoSystem.UserLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  	UserLogin��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �� $��Username��6   $
��Left=�6#   $	��Top=�6>   $��179,111,0,0q�6V   �� 5   
   -   5        $��Username��5      $
��Left=�6"   $��23��6=   $��269,114,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�5      $	��120��6*   .��66   ��5      �� 5       �� Path$ Username�6    �� UpdateSourceTrigger$ PropertyChanged=�6*    �� ValidatesOnDataErrors .  �� ValidatesOnExceptions .  �� ValidationRules 5      4   .StudentInfoSystem.RequiredLengthValidationRule  5         ErrorMessage$= 7Username is required and must be at least 5 characters.��5         	MinLength$ 5��6d   5      .��5      	 =� ErrorTemplate	 5      �� 5      .R�5      ]� .+�5      �� $��Bottom=�6$   
���  ��$��10(�6M   ��5   $   �� *[0].ErrorContent+�� 5      5      5      .��5   (   5      �� 5   
   $��Password��6   $
��Left=�6#   $	��Top=�6>   $��179,174,0,0q�6V   �� 5    
   -   5        $��Password��5       $
��Left=�6"   $��23��6=   $��269,177,0,0q�6I   $
 Wrap=�6^   $	��Top=�5!      $	��120��6*   .��66   ��5"      �� 5#      $ Password�6   $ PropertyChanged=�6*    .  .  5$        5%      $= 7Password is required and must be at least 5 characters.��5&      $ 5��6d   5(      .��5)      	 5*      �� 5+      .R�5,      ]� .+�5-      �� $��Bottom=�6$   
���  ��$��10(�6M   ��5.   $   �� *[0].ErrorContent+�� 5/      50      51      .��52   (   53      �� 54   
   $��Login��6   $
��Left=�6!   $��269,253,0,0q�6<   $	��Top=�6Q   $��66��6i   $��24��55      ��6   �� *LoginCommand+��6?   �� *.+56      57      58      