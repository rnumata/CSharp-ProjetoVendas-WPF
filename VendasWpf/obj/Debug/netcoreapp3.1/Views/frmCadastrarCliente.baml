   M S B A M L   `   `   `  ����D  @VendasWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VendasWpf.ViewsVendasWpf.Views  5      )    #VendasWpf.Views.frmCadastrarCliente   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VendasWpf.Views     5      X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      .��5
      � .+�5   
   ]� .+�5      �� 
�������.+�5      �� $��Manter Cliente��6   $��0q�63   $��20q�6>   $	��500��6K   $	��450��6W   .��5      �� .+�5      �� -   5          ��Name$  lblId��5   $   $
��Id :��63   �� 5      -   5         ��Name$ txtId��5   "   $
��Left=�61   $	��0,5q�6L    �� TextWrapping$
 Wrap=�6Y   $	��150��6m   $��0��6y   $��16(�6�   ${�False��6�   �� 5      $��Nome :��6$   �� 5      -   5        $ txtNome��5   "   $
��Left=�63   $	��0,5q�6N   $
 Wrap=�6[   $	��250��6o   $��1��6{   $��16(�6�   �� 5      $��CPF :��6$   %  Xceed.Wpf.Toolkit.MaskedTextBox  5      -   5          Name$ txtCpf��5   -      Mask$ 000,000,000-00��6=   $
��Left=�6S   $	��0,5q�6n   $
 Wrap=�6{   $	��150��6�   $��2��6�   $��16(�6�   �� 5      $��Email��6$   �� 5      -   5        $ txtEmail��5   "   $
��Left=�64   $	��0,5q�6O   $
 Wrap=�6\   $	��250��6p   $��3��6|   $��16(�6�   �� 5      $��Criado em :��6$   �� 5      -   5        $ txtCriadoem��5   "   $
��Left=�67   $	��0,5q�6R   $
 Wrap=�6_   $	��250��6s   $��4��6   $��16(�6�   ${�False��6�   �� 5      -   5         ��Name$ btnAtualizarCliente��5   !   $��	Atualizar��6>   $	��100��6R   $��30��6^   $��
0,0,-300,0q�6j   $��5��6~   $
��Bold"�6�   ${�False��6�   6�   �� 5      -   5        $ btnRemoverCliente��5   !   $��Remover��6<   $	��100��6N   $��30��6Z   $��10,0,-40,-130q�6f   $��6��6}   $
��Bold"�6�   ${�False��6�   6�   �� 5      -	   5        $ btnConsultarCliente��5   !   $��	Consultar��6>   $	��100��6R   $��30��6^   $��0,10,-300,0q�6j   $��7��6   $
��Bold"�6�   6�   �� 5      -
   5        $ btnCadastrarCliente��5   !   $��	Cadastrar��6>   $	��100��6R   $��30��6^   $��0,10,-300,0q�6j   $��8��6   $
��Bold"�6�   $
{�True��6�   6�   5      5      5      5       5!      5"      