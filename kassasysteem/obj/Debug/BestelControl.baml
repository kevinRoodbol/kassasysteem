   M S B A M L   `   `   `  ����G  Ckassasysteem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kassasysteemkassasysteem  5           kassasysteem.BestelControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kassasysteem     5      $	��420��5   7   $	��683��6D   .��5	      � $	��683��6   $	��420��6   ���	#FF8EE1FF.+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  DGbestel��5
      $
��Left=�6%   $	��322��6@   $	��Top=�6M   $	��178��6e   $��	505,0,0,0q�6q      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 naam��6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *productnaam+   ClipboardContentBinding 6E   Z� 6h     5      $ omschijving��6g    6%   �� *
omshijving+ 6D   Z� 6g     5      $ prijs��6b    6%   �� *prijs+ 6?   Z� 6b   5        5   
   -   5        $  DGproducten��5      $
��Left=�6(   $	��420��6C   $	��Top=�6P   $	��246��6h    .   5        5      $
 naam��6h    6%   �� *productnaam+ 6E   Z� 6h     5      $ omschijving��6h    6%   �� *omschijving+ 6E   Z� 6h     5      $ prijs��6b    6%   �� *prijs+ 6?   Z� 6b   5      �� 5   
   -   5         ��Name$ 
opslaanbtn��5      $��opslaan��6%   $
��Left=�67   $��537,356,0,0q�6R   $	��Top=�6g   $	��114��6   $��44��6�   6�   �� 5   
   -   5         ��Name$ KlantCMB��5       �� DisplayMemberPath$ 	firstname��6%   $
��Left=�6C   $��
287,79,0,0q�6^   $	��Top=�6r   $	��120��6�   �� 5   
   $
��Left=�6   $��
251,79,0,0q�6/   $
��Wrap=�6C   $��Klant:��6W   $	��Top=�6e   $��22��6}   $��31��6�   5      5      