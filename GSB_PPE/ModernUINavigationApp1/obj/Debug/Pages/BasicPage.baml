   M S B A M L   `   `   `  ����  ModernUINavigationApp1,    &ModernUINavigationApp1.Pages.BasicPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.9.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5      .��5	      �    ContentRoot#��[  6   $��16,28,16,138q�60   .+�5
   
   �� $��0,0,0,7q�6     J� RenderTransformOrigin$  0.5,0.5&�6(   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.233Q�6$   �� 5      T� 5       T� X$ -0.496Q�6)   5      .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5      $	��312��6A   $	��Top=�6N      AutoGenerateColumns .     CanUserAddRows .  ��6)   ��    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5   "   ��  �� Orientation$ Vertical=�6-   .+�5   &   �� -   5        
���   �
���  ��.��5   f   	Supprimer6q   �� 5   &   -   5        
���   �
�������.��5   k   
Modifier6u   5   #   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Numéro��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *id+  5       $		 Nom��6)   
 66   �� *	last_name+  5!      $	 Prénom��6)   
 69   �� *
first_name+  5"      $	 Adresse��6)   
 6:   �� *	address+  5#      $	 Date de recrutement��6)   
 6F   �� *recruitment_date+  5$      $	 Département��6)   
 6>   �� *name+5&      5'      �� 5(   
   -   5        $
��Left=�5(   4   $��23��6O   $��0,348,0,-72q�6[    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��120��6�   $��Center=�6�   $��Center=�6�   �� 5)   
   $��Nom : ��6   $
��Left=�6!   $��14��6<   $��0,330,0,-45q�6H   $	��Top=�6]   $��40��6u   �� 5*   
   -   5        $
��Left=�5*   5   $��23��6P   $��125,348,0,-72q�6\   $
 Wrap=�6s   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5+   
   $��
Prénom : ��6   $
��Left=�6$   $��14��6?   $��125,329,0,-44q�6K   $	��Top=�6b   $��53��6z   �� 5,   
   -   5        $��Ajouter un Visiteur��5,   *   $
��Left=�6H   $��34��6c   $��0,391,0,-126q�6o   $	��Top=�6�   $	��166��6�   �� 5.   
   -   5        $��Rafraichir la liste��5.   '   $
��Left=�6E   $��30��6`   $��303,348,0,-49q�6l   $	��Top=�6�   $	��131��6�   50      51      