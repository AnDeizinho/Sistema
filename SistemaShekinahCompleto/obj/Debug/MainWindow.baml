   M S B A M L   `   `   `  ����  SistemaShekinahCompleto(    "SistemaShekinahCompleto.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6,    � WindowState$ 	Maximized=�6;    � WindowStyle$
 None=�6S    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      ��%    5      ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF250225��6    � Offset$ 0Q�6-   � 5      $ 	#FFB403B4��6   $ 1Q�6-   5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $	��75* �6   �� 5      $	��75* �6   �� 5      $	��75* �6   �� 5      $	��75* �6   �� 5      $	��75* �6   �� 5      $	��75* �6   
 � ColumnDefinitions
 5   
   �� 5      -   5         �Name$ Coluna��5      $	��300 �6-   �� 5      $
��500* �6   .+�5   
   �� -   5        $��	btnInicio��5      $��Inicio��6"   $��0��63   $��0��6C    	  Limao#��[  6P   6�   �� 5   
   -   5        $��btnSecretaria��5      $��
Secretaria��6&   $��0��6;   $��1��6K    
 Escuro#��[ 6X   ���	#FFFDFDFD6�   �� 5   
   -   5        $��Caixa��5      $��0��6!   $��2��61     Cinzento#��[ 6>   6`   �� 5   
   $��Contas de Usuários��6   $��0��6.   $��3��6>     Violeta#��[ 6K   �� 5    
   -   5        $��
btnOcultar��5       $��Ocultar��6#   $��0��65   $��4��6E   $��5q�6R   ���	#FF394BBD
�������5"      �� 5#   
   -   5        $��btnSair��5#      $
��Sair��6    $��0��6/   $��5��6?   $��5q�6L   ���	#FFA22F2F���	#FF4702026�   �� 5$   
   $��1��6   $��6��6'   .��5%       � -   5        $��meuFrime��5%        � NavigationUIVisibility$ Hidden=�6%   5'      5(      5)      5*      