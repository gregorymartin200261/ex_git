   M S B A M L   `   `   `  ����A  =chalet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:chaletchalet  5   	       chalet.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:chalet     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $
��21px(�65   ���#f2ab27.��5	      �  � RowDefinitions 5
   
   �� 5      $
��131* �6   �� 5      $	��86* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��2��6   $��	0,0,266,0q�6)   .+�5      �� $��TYPE DE LOGEMENT��6   $��10 30 10 30q�61   
�������$	��160��6Z   .��5      �� $��Center=�6   $��50��6;   .+�5      	� -   5         	�Name$ radbtnChalet��5   "   .��6R   CHALET6Z   	� 5      -   5        $ radbtnTente��5   "   .��6S   TENTE6Z   5      5      �� 5      -   5         ��Name$ ChckBxReserv��5   #   $��10q�6   .��6P   RESERVATION6]   5      �� 5   
   $
��left=�6   $��	RESULTATS��6.   $��10,30,30,30q�6A   
�������$��1��6j   $��2��6w   $	��470��6�   .��5      �� .+�5      �� -   5         ��Name$ 
txtblcPrix��5   /   $��	0 14 0 10q�6   Prix a payer :6S   �� 5       -   5        $ txtblcSemaine��5       Nombre de semaines :6I   5!      5"      �� 5$   
   $��1��6   $��Center=�6"   $��2��6=   .+�5%      �� -   5         ��Name$ 	btnCalcul��5%   *   $��35 30 35 30q�6   .��6U   
CALCULER6_   �� 5&      -   5        $ btnInit��5&   )   $��
35 0 35 25q�6   $y�Hidden=�6:   .��6N   INIT6T   5'      �� 5)   
   $(��"Paramètrage du jeu et des joueurs��6   $��
35,35,35,0q�6>   $��1��6R   $��2��6b   .��5*      �� .+�5+      ]� .+�5,      �� $��5q�6   .��6'   !Nbre de Personnes (entre1 a 6):6H   �� 5-      -   5         ��Name$ txtbxNbrPersonne��5-   @   $��5q�6   $��40��6)   $��30��64   
�������6o   5.      ]� 5/      .+�50      �� $��5q�6   .��6'   Date d'arrivée :69   �� 51      -	   5        $ txtbxArrive��51   A   $��5q�6   $	��200��6)   $��30��65   
�������6V   52      ]� 53      .+�54      �� $��5q�6   .��6'   Date de sortie :69   �� 55      -
   5        $ txtbxSortie��55   A   $��5q�6   $	��200��6)   $��30��65   
�������6k   56      ]� 57      .+�58      �� -   5        $ btnAdd��58      $��	10 0 50 0q�6-   .��6U   DUREE SORTIE6c   �� 59      -   5        $ DureeSem��59       Durée en semaines6E   5:      5<      5=      5>      5?      