   M S B A M L   `   `   `  ����   HappyPawsHubWPF&     HappyPawsHubWPF.CustomMessageBox   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Message�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � SizeToContent$ WidthAndHeight=�
������  � AllowsTransparency . .��� .+��� ���	#88000000�� $	��400��$	��220�� �� Padding$ 20q� �� CornerRadius$ 15��
�������$��1q�
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  	   
BlurRadius$	 15Q�
   ShadowDepth$
 2Q�   Opacity$	 0.4Q�._�� .+��� -   $	��✖��$��30��$��30��$��16(�
������ 
�������$��0q� � Cursor$
 Hand��$��Right=�$	��Top=�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 ����� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��
 �  ���� $��Center=�$��Center=�$��10q�.+��� -   $��
txtMessage��$��22(�$
��Bold"�
���   � �� TextAlignment$ Center=�$
��Wrap=�$��	0,20,0,10q��� -   $	��140��$��45��$
 Hand�����#0078D7
�������$��18(�$
��Bold"�$��0q�$��Center=�.��OK���� " ��.���  � �� ��  �� 
TargetType" ��.R��� #��z��$ 25��$ 10q�$��0q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  �@J�Opacity$
 0.85Q�P�  � �� . . ���  � z� ��  �� ScaleX$	 0.9Q� �� ScaleY$	 0.9Q�