Public Class Menu
  


    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MAIN MENU image
        Dim folder As String = "N:\res"
        PictureBox1.Image = Image.FromFile(folder + "\pngtree.png")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'getting from menu to game when they click the button
        Main_page.Show()
 
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class