# WPF_RelativePanel
**For more information, you can look at the TestBPanel project**

**How do I use it?**

<p>First, add WPF_RP project to the destination project (WPF) References</p>
  <p></p>Solution Explorer -> Your WPF Project Name -> References</p>
    <p></p>Right click -> Add Reference...</p>
      <p></p>Projects -> WPF_RP</p>

<p>Secound, add namespace to xaml</p>

``````xaml
xmlns:bp="clr-namespace:WPF_RP.Panels;assembly=BPanel"
``````

Using the relative panel:

``````xaml
  <bp:BPanel>
            <TextBlock
                Background="Yellow"
                x:Name="tbCenterPanel"
                bp:BPanel.CenterOfPanel="True"
                Text="Text in the middle of the window" />
     </bp:BPanel>
``````
