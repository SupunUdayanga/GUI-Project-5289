   M S B A M L   `   `   `  ����  HappyPawsHubWPF&     HappyPawsHubWPF.CustomMessageBox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Message��5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6    � SizeToContent$ WidthAndHeight=�62   
������  � AllowsTransparency . .��5      � .+�5
   
   �� $	��400��6   $	��220��6    �� Padding$ 20q�6*    �� CornerRadius$ 15��67   
�������$��1q�5   $   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 10Q�6#   
   ShadowDepth$
 0Q�63      Opacity$	 0.3Q�6C   ._�5      � $��0q�6   .+�5      �� -   5        $	��✖��5      $��30��6%   $��30��60   $��16(�6<   
������ 
�������$��0q�5   D    � Cursor$
 Hand��5      $��Right=�6'   $	��Top=�6C   ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value
 �����6;    �� Triggers 5      P� 5   "    P� Property �@J�IsMouseOver P� Value . . �5   &   ��  � ��
 �  ��6C   5   #   5       5"      �� 5%      $��Center=�6   $��Center=�68   $��0q�6U   .+�5&      �� -   5        $��
txtMessage��5&       $��22(�62   $
��Bold"�6@   
���   � �� TextAlignment$ Center=�5'       $
��Wrap=�67   $��	0,20,0,10q�6K   �� 5*      -   5        $	��140��5*   1   $��45��6=   $
 Hand��6I   ���#0078D7
�������$��18(�5+   E   $
��Bold"�5,      $��0q�6/   $��Center=�5-      .��6:   OK��5/      �� 50      " ��6$   .�51   "   ��  � �� 52   &   �� 53   *    �� 
TargetType" ��6:   .R�54   .   �� #��z��65   $ 25��55   5   $ 10q�6G   $��0q�56   5   ._�57   2   �� $��Center=�6C   $��Center=�58   C   59   /   5:   +   5<   #    5=   "   P� 5>   &    �@J�IsMouseOver . . �5?   *   ��  �@J�Opacity$
 0.85Q�6D   5@   '   P� 5A   &    � �� . . �5B   *   ��  � z� 5C   .   �� 5D   2    �� ScaleX$	 0.9Q�6A    �� ScaleY$	 0.9Q�6N   5F   +   5G   '   5I      5K      5L      5M      5N      5O      5P      