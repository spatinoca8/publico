   M S B A M L   `   `   `  ����F  BEmployeesUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EmployeesUIEmployeesUI  5          EmployeesUI.Page2   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:EmployeesUI     5        N� Title$  Page2��5	      .��5      �  � ShowGridLines .  � ColumnDefinitions 5   
   �� 5      6!    � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      6   .+�5   
   �� -   5        $��0��5      $��0��6"   $	��100��6/   $��Right=�6;   .��6l   Nuevo6s   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   1   $��0��6   $��1��6$   $��Center=�6C   $	��Top=�6a   $	��167��6y   $
��1000��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ TipoIdentificacion��6h      HeaderStringFormat$ Nombre��6�      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� 
 �� Path$
 Tip_Id�   ClipboardContentBinding 6E   Z� 6�     5      $ NumeroIdentificacion��6h   $ Apellido��6�   $	 100 6�   	 6%   �� $
 Num_Id� 6E   Z� 6�     5      $ PrimerNombre��6l   $
 Sexo��6�   $	 100 6�   	 6%   �� $
 
First_Name� 6I   Z� 6�     5      $ SegundoNombre��6m   $
 Edad��6�   $	 100 6�   	 6%   �� $
 Second_Name� 6J   Z� 6�     5      $ PrimerApellido��6k   $
 Edad��6�   $	 100 6�   	 6%   �� $
 	Last_Name� 6H   Z� 6�     5      $ SegundoApellido��6m   $
 Edad��6�   $	 100 6�   	 6%   �� $
 Middle_Name� 6J   Z� 6�     5      $ 	Direccion��6h   $
 Edad��6{   $	 100 6�   	 6%   �� $
 Addres� 6E   Z� 6�     5      $ Celular��6k   $
 Edad��6|   $	 100 6�   	 6%   �� $
 	Cellphone� 6H   Z� 6�     5      $ Email��6g   $
 Edad��6v   $	 100 6�   	 6%   �� $
 Email� 6D   Z� 6�   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5       �� 5!      .R�5"      �� .+�5$   "   �� -   5        ��5$   )   �� *Num_Id+.��6b   Editar6j   5%      5&      5(      5*      5+      5,      