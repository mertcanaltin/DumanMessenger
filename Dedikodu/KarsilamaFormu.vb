Public NotInheritable Class KarsilamaFormu

    Private Sub KarsilamaFormu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TimerDedikodu.Stop()
    End Sub

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub KarsilamaFormu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        TimerDedikodu.Start()
    End Sub
    'Karsilama formunun ekrana tüm formlardan önce gelmesi için PROJECT menüsünden Dedikodu Properties seçeneğine tıkla
    'Açılan Formdan SplashScreen seçeneğinden KarsilamaFormu nu seç
    Private Sub TimerDedikodu_Tick(sender As Object, e As EventArgs) Handles TimerDedikodu.Tick
        If ProgressBarTarama.Value < ProgressBarTarama.Maximum Then
            ProgressBarTarama.Value += 1
        Else
            ProgressBarTarama.Value = 0
        End If
    End Sub
End Class
