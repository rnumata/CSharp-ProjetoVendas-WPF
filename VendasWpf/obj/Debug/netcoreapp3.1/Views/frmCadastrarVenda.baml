   M S B A M L   `   `   `  ����D  @VendasWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VendasWpf.ViewsVendasWpf.Views  5      '    !VendasWpf.Views.frmCadastrarVenda   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VendasWpf.Views     5      X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      -   5        .��5
      � .+�5   
   ]� .+�5      �� 
�������.+�5      �� $��Manter Venda��6   $��0q�61   $��20q�6<   $	��500��6I   $	��480��6U   .��5      �� .+�5      �� $��	Cliente :��6$   $
��Left=�65   $	��0,5q�6P   $
��Wrap=�6]   $	��150��6q   �� 5      -   5          ��Name$  cboClientes��5   #   $	��250��68   $
��Left=�6D   $��0q�6_   �� 5      $��
Vendedor :��6$   $
��Left=�66   $	��0,5q�6Q   $
��Wrap=�6^   $	��150��6r   �� 5      -   5        $  cboVendedores��5   #   $	��250��6:   $
��Left=�6F   $��0q�6a   �� 5      $��	Produto :��6$   $
��Left=�65   $	��0,5q�6P   $
��Wrap=�6]   $	��150��6q   �� 5      -   5        $  cboProdutos��5   #   $	��250��68   $
��Left=�6D   $��0q�6_   �� 5      $��
Quantidade��6$   $
��Left=�66   $	��0,5q�6Q   $
��Wrap=�6^   �� 5      -   5         ��Name$ txtQuantidade��5   "   $
��Left=�69   $	��0,5q�6T    �� TextWrapping$
 Wrap=�6a   $	��150��6u   $��16(�6�   �� 5      -   5         ��Name$ btnAdicionarItem��5   !   $��	Adicionar��6;   $��80��6O   $��30��6Z   $��	0,-30,0,0q�6f   $��5��6y   $
��Bold"�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dtaProdutos��5   #   $	��150��68   $
��0,10q�6E      AutoGenerateColumns$ False��6S      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   "   ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��65      Width5  /System.Windows.Controls.DataGridLengthConverter$	 40* 6C   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6O   �� *Nome+  5   "   $ Preço��65   $	 20* 6D   	 6P   �� *Preco+  5   "   $ 
Quantidade��65   $	 20* 6I   	 6U   �� *
Quantidade+  5   "   $ Subtotal��65   $	 20* 6G   	 6S   �� *
Subtotal+5      �� 5       -   5        
 ��Name$
 lblTotal��5        $��Total��62   $
��Left=�6B   �� 5!      -	   5        $ btnCadastrar��5!   !   $��	Cadastrar��67   $��Right=�6K   $��5,-15q�6g   $��80��6v   $��30��6�   $��6��6�   $
��Bold"�6�   6�   5"      5#      5$      5%      5(      5)      