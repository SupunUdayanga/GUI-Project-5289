   M S B A M L   `   `   `  ����  HappyPawsHubWPF    HappyPawsHubWPF.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	Dashboard��5   	    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5
   
   �� $��Images/bg.jpg��6   $
��Fill=�6'    K� ZIndex$ -1��66   �� 5   
   ���	#88000000$ 0��6%   �� 5   
   ���	#CCFFFFFF �� CornerRadius$ 20��6(    �� Padding$ 30q�6:   $	��800��5      $	��600��6   $��Center=�5      $��Center=�6,    J� Opacity$
 0.95Q�5      ._�5      �� .+�5      �� $��Appointment Table��6   $��26(�65   $
��Bold"�6C   
���   � �� TextAlignment$ Center=�5   /   $��0,0,0,20q�6F   &   System.Windows.Controls.DataGrid  5      -   5        $��AppointmentsGrid��5         AutoGenerateColumns .  $	��300��5      $��0,20,0,0q�6(   
�������
�������	   CanUserAddRows	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Pet Type��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	PetType+6[     5      $ Pet Name��6-   $ * 6[    6?   �� *	PetName+6[     5       $ Doctor Name��6-   $ * 6a    6B   �� *
DoctorName+6a     5!      $
 Date��6-   $ * 6T    6;   �� *Date+6T     5"      $
 Time��6-   $ * 6T    6;   �� *Time+6T   4  .System.Windows.Controls.DataGridTemplateColumn  5#      $ Actions��61      CellTemplate 5$      �� 5%   "   .R�5&   &   ��  �� Orientation$ 
Horizontal=�61   .+�5'   *   �� -   5        $
��Edit��5'   1   $��5q�6^   
��� � �
�������5(   D   �� 5)   *   -   5        $��Delete��5)   1   $��5q�6b   
���  ��
�������5*   B   5+   '   5,   #   5.      50      �� 53      $ 
Horizontal=�6   $��Center=�66   $��10q�6S   .+�54      �� -   5        $��Add Appointment��54      ���#4CAF50
�������$��18(�55   E   $��45��56      $	��200��6)   $��10q�65   $��0q�6A   �� 57      -   5        $��Logout��57      ���#D32F2F
�������$��18(�58   E   $��45��59      $	��200��6)   $��10q�65   $��0q�6A   5:      5;      5<      5=      5>      