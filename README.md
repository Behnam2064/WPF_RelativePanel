# WPF_RelativePanel

For more information, you can look at the TestBPanel project

First, add WPF_RP project to the destination project (WPF) References
  Solution Explorer -> Your WPF Project Name -> References
    Right click -> Add Reference...
      Projects -> WPF_RP

Secound, add namespace to xaml
  xmlns:bp="clr-namespace:WPF_RP.Panels;assembly=BPanel"
  
Using the relative panel:
        <bp:BPanel>
            <TextBlock
                Height="100"
                Background="Yellow"
                x:Name="tbCenterPanel"
                bp:BPanel.CenterOfPanel="True"
                Text="Text in center of panel" />
         </bp:BPanel>
