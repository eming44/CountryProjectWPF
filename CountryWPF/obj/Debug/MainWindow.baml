   M S B A M L   `   `   `  ����E  ACountryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CountryWPF
CountryWPF  5   	   ;"clr-namespace:CountryWPF.ViewModelCountryWPF.ViewModel  5   	       CountryWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CountryWPF     5   	   8	viewModel"clr-namespace:CountryWPF.ViewModel     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5	      $
��1024��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o    � DataContext 5      +   %CountryWPF.ViewModel.CountryViewModel  5   
   -   5        cvm��5   %    � 	Resources 5      ��%    5      .��5      � -   5        ���	#FFEEEEEE 5      �� *CurrCountry+.+�5   
   �� $	��Top=�6   .+�5      � ���	#FF0069C0$��10��6*   � 5      $��5q�6   $��Right=�6   .+�5      �� -   5         ��Name$ 
ButtonExit��5      $��30��6-   $��30��68   $��0q�6q   
���������6D   Z� ��6Z   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Power=�6.   5      5      5      � 5   
   $��
250 55 0 0q�6   .+�5      � -   5         �Name$ GridPrincipal��5      $��Center=�6+   $	��Top=�6H   5       5!      � 5#   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�5$      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��5$   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+
   Duration$
 0:0:0.2X�.��5%      � -   5        $ 
GridCursor��5%      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   5&      �� 5'      $��The Country Viewer��6   
�������$	��Top=�6I   $��Center=�6a   $��20(�6~   $��Freestyle Script)�6�   $
��0 10q�6�   �� 5)      -   5         ��Name$ ListViewMenu��5)      $��0 100q�6-   
�������$��Freestyle Script)�6S   .@�5*      �� $��60��6   .��5+      ��  �� Orientation$ 
Horizontal=�6!   .+�5,        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5-      $
��Home��6$   $��26(�60   $��Center=�6>   $
��20 0q�6Y   5.      5/      �� 50      $��60��6   .��51      �� $ 
Horizontal=�6!   .+�52        $ Planet=�62   $��30��6@   $��30��6K   $��Center=�6W   $��5q�6r   �� 53      $��	Countries��6$   $��26(�65   $��Center=�6C   $
��20 0q�6^   54      55      �� 56      $��60��6   .��57      �� $ 
Horizontal=�6!   .+�58        $ AddBox=�62   $��30��6@   $��30��6K   $��Center=�6W   $��5q�6r   �� 59      $��Add country��6$   $��26(�67   $��Center=�6E   $
��20 0q�6`   5:      5;      5<      �� 5=      $��0 0 0 10q�6   $��Center=�6+   $��Bottom=�6H   $ 
Horizontal=�6c   .+�5>      �� $��30��6   $��30��6%   $��0q�6^   
���������61   Z� ��6G   Z� .��5?        $ 	GithubBox=�6.   5@      �� 5A      $��30��6   $��30��6$   $��0q�6]   
���������60   Z� ��6F   Z� .��5B        $ Facebook=�6.   5C      �� 5D      $��30��6   $��30��6$   $��0q�6]   
���������60   Z� ��6F   Z� .��5E        $ Twitter=�6.   5F      5G      5H      5I      5J      