   M S B A M L   `   `   `  ����G  Ckassasysteem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kassasysteemkassasysteem  5          kassasysteem.KlantControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kassasysteem     5      $	��683��5   7   $	��420��6C   .��5	      � ���	#FFFF0D0D$	��683��6"   $	��420��6.   .+�5
   
   �� -   5          ��Name$  KlantNaamBox��5
      $
��Left=�6(   $��23��6C   $��	27,11,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $��Klantvoornaam��6v   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $  StadBox��5      $
��Left=�6#   $��23��6>   $��	27,95,0,0q�6J   $
 Wrap=�6]   $
��Stad��6q   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $  	MobielBox��5      $
��Left=�6%   $��23��6@   $��	27,67,0,0q�6L   $
 Wrap=�6_   $��Telefoonnummer��6s   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $  EmailBox��5      $
��Left=�6$   $��23��6?   $��
27,123,0,0q�6K   $
 Wrap=�6_   $��Email��6s   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ Opslaanklantbtn��5      $��Opslaan��6*   $
��Left=�6<   $��
27,151,0,0q�6W   $	��Top=�6k   $	��120��6�   6�   �� 5   
   -   5        $ UpdateKlantbtn��5      $��Update��6)   $
��Left=�6:   $��
27,175,0,0q�6U   $	��Top=�6i   $	��120��6�   6�   � 5   
   $
��Left=�6   $	��253��6*   $��
418,67,0,0q�67   $	��Top=�6K   $	��265��6c    J� RenderTransformOrigin$ 0.522,0.842&�6o   ��5      �� 5       �� ImageSource$ leaf.jpg��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGKlant��5      $	��332��6$   $��
163,21,0,0q�61   $	��280��6E   
���   �   AutoGenerateColumns .  $
��Left=�6�   $	��Top=�6�      CanUserAddRows .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Voornaam��6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	firstname+   ClipboardContentBinding 6C   Z� 6f     5      $
 
Achternaam��6e    6%   �� *
lastname+ 6B   Z� 6e     5         
Foreground
 �   �$

 Stad��6t    6%   �� *city+ 6>   Z� 6t     5      $
 TelefoonNummer��6h    6%   �� *phonenumber+ 6E   Z� 6h     5      $
 Email��6b    6%   �� *email+ 6?   Z� 6b   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $ btnVerwijderenKlant��6%   -   5        $��Delete��5   B   6S   5       5"      5$      �� 5%   
   -	   5        $  KlantAchterBox��5%      $
��Left=�6*   $��23��6E   $��	27,39,0,0q�6Q   $
 Wrap=�6d   $��KlantAchterNaam��6x   $	��Top=�6�   $	��120��6�   �� 5&   
   $
��Left=�6   $��	163,0,0,0q�6/   $
��Wrap=�6B   $"��dubbel klik om te selecteren��6V   $	��Top=�6z   $��21��6�   $	��166��6�   ���	#FFFFEA326�   5'      5(      