   M S B A M L   `   `   `  ����  SistemaShekinahCompleto?    9SistemaShekinahCompleto.Views.ViewsSecretaria.ListaAlunos   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        .��5	   
   �   � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $
��550* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��5q�6K   $	��880��6V   .+�5      �� -   5        $��txtCod��5      $	��100��6%   64   �� 5      -   5        $��txtAluno��5      $	��300��6&   64   �� 5      -   5        $��cbTurmas��5      $	��200��6(    � DataContext 64   �� *	TurmasDAO+��5      �� 5      .R�5      �� ���	#FFA552D4$	��200��6<   $��30��6H   .+�5      �� $��16(�6C   ��6(   �� *	descricao+6C   5      5      .@�5      ��  �� ContentStringFormat$ Todos os Alunos��6   5      �� 5       -   5        $��txtano��5       $	��100��6$   62   �� 5!      -   5        $��lblTT��5!      $��Total=��6!   $��20(�62   6B   5"      &   System.Windows.Controls.DataGrid  5$      -   5        $��MeuGrid��5$      $��1��6&      AutoGenerateColumns .     HorizontalGridLinesBrush �	#FFF9F9F9   VerticalGridLinesBrush �	#FFF9F9F9   
IsReadOnly .    CanUserAddRows .  	   CanUserDeleteRows	 .  $
��1000��5'   -   $	��600��6=   $��	0,10,10,0q�6M    5%   6   �� *
AlunoEnt+��5&      �� 
   Columns
 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ CA��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
id_aluno+6F     5*      $ CC��6H    6)   �� *
id_cliente+6H     5+      $ Aluno��6B    6)   �� *nome+6B     5,      $	 Pai��6A    6)   �� *pai+6A     5-      $
 Mãe��6A    6)   �� *mae+6A     5.      $ Fone Pai��6F    6)   �� *
fone_pai+6F     5/      $ 	Fone Mãe��6F    6)   �� *
fone_mae+6F     50      $ Turma��6G    6)   �� *	descricao+6G     51      $ 
Nascimento��6H    6)   �� *
nascimento+6H     52      $ Integral��6F    6)   �� *
integral+6F     53      $
 Sexo��6B    6)   �� *sexo+6B    � ContextMenu 57      �� 58      .@�59      m� -   5        $��	btnAltera��59   6   $��Alterar Aluno��6   6a   m� 5:      $��Alterar Cliente��6   6:   m� 5;      $��Visualizar Notas��6   6;   m� 5<      $��Mais Opçôes��6   66   5=      5?      5B      5C      