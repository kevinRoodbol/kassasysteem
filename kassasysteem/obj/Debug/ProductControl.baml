   M S B A M L   `   `   `  ����G  Ckassasysteem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kassasysteemkassasysteem  5      !    kassasysteem.ProductControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kassasysteem     5      $	��683��5   7   $	��420��6C   .��5	      � $	��683��6   $	��420��6   ���	#FF23FF84.+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  	DGProduct��5
      $
��Left=�6&   $	��312��6A   $	��240��6N   $��	443,0,0,0q�6Z   $	��Top=�6m      AutoGenerateColumns .     CanUserAddRows .  ���	#FF084217   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   ClipboardContentBinding 6)   Z�    CellTemplate 5      �� 5      .R�5      ��  ��Name$ plaatje��6$   $��50��6S   $��50��6^   ��65   �� *
afbeelding+6^   5      5      0  *System.Windows.Controls.DataGridTextColumn  5         Header$
 Naam��6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *productnaam+	   ClipboardContentBinding	 6E   Z� 6h     5      $	 Cat��6h    6%   �� *omschijving+	 6E   Z� 6h     5      $ prijs��6b    6%   �� *prijs+	 6?   Z� 6b     5       5      �� 5      .R�5      �� 
 ��Name$
 btnVerwijderen��6%   -   5        $��Delete��5   =   6N   5      5      5!      � 5"   
   -   5         �Name$ GridProduct��5"      $
��Left=�6$   $	��196��6?   $	��312��6K   $��	247,0,0,0q�6X   $	��Top=�6k   ���	#FF258B115#      �� 5$   
   -   5        $
 	Toevoegen��5$      $��	toevoegen��6$   $
��Left=�68   $��
61,202,0,0q�6S   $	��Top=�6g   $��75��6   $��23��6�   6�   5%      5&      