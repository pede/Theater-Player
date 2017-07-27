Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.box1
        Label4.Text = My.Settings.play1
        TextBox3.Text = My.Settings.box2
        Label5.Text = My.Settings.play2
        TextBox6.Text = My.Settings.box3
        Label6.Text = My.Settings.play3
        TextBox2.Text = My.Settings.box4
        Label7.Text = My.Settings.play4
        TextBox4.Text = My.Settings.box5
        Label9.Text = My.Settings.play5
        TextBox5.Text = My.Settings.box6
        Label11.Text = My.Settings.play6
        TextBox7.Text = My.Settings.box7
        Label13.Text = My.Settings.play7
        TextBox8.Text = My.Settings.box8
        Label15.Text = My.Settings.play8
        TextBox9.Text = My.Settings.box9
        Label19.Text = My.Settings.play9
        TextBox10.Text = My.Settings.box10
        Label17.Text = My.Settings.play10
        TextBox11.Text = My.Settings.box11
        Label21.Text = My.Settings.play11
        TextBox12.Text = My.Settings.box12
        Label23.Text = My.Settings.play12


        OpenFileDialog1.FileName = Label4.Text
        AxWindowsMediaPlayer1.close()
        OpenFileDialog2.FileName = Label5.Text
        AxWindowsMediaPlayer2.close()
        OpenFileDialog3.FileName = Label6.Text
        AxWindowsMediaPlayer3.close()
        OpenFileDialog4.FileName = Label7.Text
        AxWindowsMediaPlayer4.close()
        OpenFileDialog5.FileName = Label9.Text
        AxWindowsMediaPlayer5.close()
        OpenFileDialog6.FileName = Label11.Text
        AxWindowsMediaPlayer6.close()
        OpenFileDialog7.FileName = Label13.Text
        AxWindowsMediaPlayer7.close()
        OpenFileDialog8.FileName = Label15.Text
        AxWindowsMediaPlayer8.close()
        OpenFileDialog9.FileName = Label19.Text
        AxWindowsMediaPlayer9.close()
        OpenFileDialog10.FileName = Label17.Text
        AxWindowsMediaPlayer10.close()
        OpenFileDialog11.FileName = Label21.Text
        AxWindowsMediaPlayer11.close()
        OpenFileDialog12.FileName = Label23.Text
        AxWindowsMediaPlayer12.close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        Label4.Text = OpenFileDialog1.FileName
        AxWindowsMediaPlayer1.close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.close()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName

    End Sub
    Private Declare Function getasynsckeystate Lib "user32" (ByVal vkey) As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        My.Settings.box1 = TextBox1.Text
        My.Settings.play1 = Label4.Text
        My.Settings.box2 = TextBox3.Text
        My.Settings.play2 = Label5.Text
        My.Settings.box3 = TextBox6.Text
        My.Settings.play3 = Label6.Text
        My.Settings.box4 = TextBox2.Text
        My.Settings.play4 = Label7.Text
        My.Settings.box5 = TextBox4.Text
        My.Settings.play5 = Label9.Text
        My.Settings.box6 = TextBox5.Text
        My.Settings.play6 = Label11.Text
        My.Settings.box7 = TextBox7.Text
        My.Settings.play7 = Label13.Text
        My.Settings.box8 = TextBox8.Text
        My.Settings.play8 = Label15.Text
        My.Settings.box9 = TextBox9.Text
        My.Settings.play9 = Label19.Text
        My.Settings.box10 = TextBox10.Text
        My.Settings.play10 = Label17.Text
        My.Settings.box11 = TextBox11.Text
        My.Settings.play11 = Label21.Text
        My.Settings.box12 = TextBox12.Text
        My.Settings.play12 = Label23.Text


        My.Settings.Save()


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        OpenFileDialog2.ShowDialog()
        AxWindowsMediaPlayer2.URL = OpenFileDialog2.FileName
        Label5.Text = OpenFileDialog2.FileName
        AxWindowsMediaPlayer2.close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer2.URL = OpenFileDialog2.FileName
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer2.close()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer3.URL = OpenFileDialog3.FileName
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer3.close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        OpenFileDialog3.ShowDialog()
        AxWindowsMediaPlayer3.URL = OpenFileDialog3.FileName
        Label6.Text = OpenFileDialog3.FileName
        AxWindowsMediaPlayer3.close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        AxWindowsMediaPlayer4.URL = OpenFileDialog4.FileName
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        AxWindowsMediaPlayer4.close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog4.ShowDialog()
        AxWindowsMediaPlayer4.URL = OpenFileDialog4.FileName
        Label7.Text = OpenFileDialog4.FileName
        AxWindowsMediaPlayer4.close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        OpenFileDialog5.ShowDialog()
        AxWindowsMediaPlayer5.URL = OpenFileDialog5.FileName
        Label9.Text = OpenFileDialog5.FileName
        AxWindowsMediaPlayer5.close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AxWindowsMediaPlayer5.URL = OpenFileDialog5.FileName
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        AxWindowsMediaPlayer5.close()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        AxWindowsMediaPlayer6.URL = OpenFileDialog6.FileName
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        AxWindowsMediaPlayer6.close()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        OpenFileDialog6.ShowDialog()
        AxWindowsMediaPlayer6.URL = OpenFileDialog6.FileName
        Label11.Text = OpenFileDialog6.FileName
        AxWindowsMediaPlayer6.close()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        AxWindowsMediaPlayer7.URL = OpenFileDialog7.FileName
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        AxWindowsMediaPlayer7.close()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        OpenFileDialog7.ShowDialog()
        AxWindowsMediaPlayer7.URL = OpenFileDialog7.FileName
        Label13.Text = OpenFileDialog7.FileName
        AxWindowsMediaPlayer7.close()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        AxWindowsMediaPlayer8.URL = OpenFileDialog8.FileName
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        AxWindowsMediaPlayer8.close()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        OpenFileDialog8.ShowDialog()
        AxWindowsMediaPlayer8.URL = OpenFileDialog8.FileName
        Label15.Text = OpenFileDialog8.FileName
        AxWindowsMediaPlayer8.close()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        AxWindowsMediaPlayer9.URL = OpenFileDialog9.FileName
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        AxWindowsMediaPlayer9.close()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        OpenFileDialog9.ShowDialog()
        AxWindowsMediaPlayer9.URL = OpenFileDialog9.FileName
        Label19.Text = OpenFileDialog9.FileName
        AxWindowsMediaPlayer9.close()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        AxWindowsMediaPlayer10.URL = OpenFileDialog10.FileName
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        AxWindowsMediaPlayer10.close()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        OpenFileDialog10.ShowDialog()
        AxWindowsMediaPlayer10.URL = OpenFileDialog10.FileName
        Label17.Text = OpenFileDialog10.FileName
        AxWindowsMediaPlayer10.close()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        AxWindowsMediaPlayer11.URL = OpenFileDialog11.FileName
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        AxWindowsMediaPlayer11.close()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        OpenFileDialog11.ShowDialog()
        AxWindowsMediaPlayer11.URL = OpenFileDialog11.FileName
        Label21.Text = OpenFileDialog11.FileName
        AxWindowsMediaPlayer11.close()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        AxWindowsMediaPlayer12.URL = OpenFileDialog12.FileName
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        AxWindowsMediaPlayer12.close()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        OpenFileDialog12.ShowDialog()
        AxWindowsMediaPlayer12.URL = OpenFileDialog12.FileName
        Label23.Text = OpenFileDialog12.FileName
        AxWindowsMediaPlayer12.close()
    End Sub


    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        TextBox1.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        TextBox1.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        TextBox1.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        TextBox1.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        TextBox1.BackColor = Color.PaleVioletRed
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        TextBox1.BackColor = Color.SlateGray
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem47.Click
        TextBox3.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        TextBox3.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem49.Click
        TextBox3.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem50.Click
        TextBox3.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem51.Click
        TextBox3.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem52.Click
        TextBox3.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem53.Click
        TextBox3.BackColor = Color.SlateGray
    End Sub

    Private Sub ToolStripMenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem54.Click
        TextBox3.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        TextBox6.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem39.Click
        TextBox6.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem40.Click
        TextBox6.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem41.Click
        TextBox6.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem42.Click
        TextBox6.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem43.Click
        TextBox6.BackColor = Color.PaleVioletRed
    End Sub

    Private Sub ToolStripMenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem44.Click
        TextBox6.BackColor = Color.SlateGray
    End Sub

    Private Sub ToolStripMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem45.Click
        TextBox6.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        TextBox2.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        TextBox2.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        TextBox2.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
        TextBox2.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem33.Click
        TextBox2.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        TextBox2.BackColor = Color.PaleVioletRed
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        TextBox2.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem36.Click
        TextBox2.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        TextBox4.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        TextBox4.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        TextBox4.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        TextBox4.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        TextBox4.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        TextBox4.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click
        TextBox4.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        TextBox4.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem92.Click
        TextBox5.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem93.Click
        TextBox5.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem94.Click
        TextBox5.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem95.Click
        TextBox5.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem96.Click
        TextBox5.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem97.Click
        TextBox5.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem98.Click
        TextBox5.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem99.Click
        TextBox5.BackColor = Color.White

    End Sub


    Private Sub ToolStripMenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem83.Click
        TextBox7.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem84.Click
        TextBox7.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem85.Click
        TextBox7.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem86.Click
        TextBox7.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem88.Click
        TextBox7.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem87.Click
        TextBox7.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem89.Click
        TextBox7.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem90.Click
        TextBox7.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem74.Click
        TextBox8.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem75.Click
        TextBox8.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem76.Click
        TextBox8.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem77.Click
        TextBox8.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem78.Click
        TextBox8.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem79.Click
        TextBox8.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem80.Click
        TextBox8.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem81.Click
        TextBox8.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem65.Click
        TextBox9.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem66.Click
        TextBox9.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem67.Click
        TextBox9.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem68.Click
        TextBox9.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem69.Click
        TextBox9.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem70.Click
        TextBox9.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem71.Click
        TextBox9.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem72.Click
        TextBox9.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        TextBox10.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        TextBox10.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        TextBox10.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        TextBox10.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        TextBox10.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        TextBox10.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        TextBox10.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        TextBox10.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem56.Click
        TextBox11.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem57.Click
        TextBox11.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem58.Click
        TextBox11.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem59.Click
        TextBox11.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem60.Click
        TextBox11.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem61.Click
        TextBox11.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem62.Click
        TextBox11.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem63.Click
        TextBox11.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem101.Click
        TextBox12.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem102.Click
        TextBox12.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem103.Click
        TextBox12.BackColor = Color.Blue
    End Sub

    Private Sub ToolStripMenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem104.Click
        TextBox12.BackColor = Color.Yellow
    End Sub

    Private Sub ToolStripMenuItem105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem105.Click
        TextBox12.BackColor = Color.Pink
    End Sub

    Private Sub ToolStripMenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem106.Click
        TextBox12.BackColor = Color.PaleVioletRed

    End Sub

    Private Sub ToolStripMenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem107.Click
        TextBox12.BackColor = Color.SlateGray

    End Sub

    Private Sub ToolStripMenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem108.Click
        TextBox12.BackColor = Color.White
    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        TextBox1.BackColor = Color.Red
        TextBox2.BackColor = Color.Red
        TextBox3.BackColor = Color.Red
        TextBox4.BackColor = Color.Red
        TextBox5.BackColor = Color.Red
        TextBox6.BackColor = Color.Red
        TextBox7.BackColor = Color.Red
        TextBox8.BackColor = Color.Red
        TextBox10.BackColor = Color.Red
        TextBox9.BackColor = Color.Red
        TextBox11.BackColor = Color.Red
        TextBox12.BackColor = Color.Red
    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        TextBox1.BackColor = Color.Green
        TextBox2.BackColor = Color.Green
        TextBox3.BackColor = Color.Green
        TextBox4.BackColor = Color.Green
        TextBox5.BackColor = Color.Green
        TextBox6.BackColor = Color.Green
        TextBox7.BackColor = Color.Green
        TextBox8.BackColor = Color.Green
        TextBox10.BackColor = Color.Green
        TextBox9.BackColor = Color.Green
        TextBox11.BackColor = Color.Green
        TextBox12.BackColor = Color.Green
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        TextBox1.BackColor = Color.Blue
        TextBox2.BackColor = Color.Blue
        TextBox3.BackColor = Color.Blue
        TextBox4.BackColor = Color.Blue
        TextBox5.BackColor = Color.Blue
        TextBox6.BackColor = Color.Blue
        TextBox7.BackColor = Color.Blue
        TextBox8.BackColor = Color.Blue
        TextBox10.BackColor = Color.Blue
        TextBox9.BackColor = Color.Blue
        TextBox11.BackColor = Color.Blue
        TextBox12.BackColor = Color.Blue
    End Sub

    Private Sub YellowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YellowToolStripMenuItem.Click
        TextBox1.BackColor = Color.Yellow
        TextBox2.BackColor = Color.Yellow
        TextBox3.BackColor = Color.Yellow
        TextBox4.BackColor = Color.Yellow
        TextBox5.BackColor = Color.Yellow
        TextBox6.BackColor = Color.Yellow
        TextBox7.BackColor = Color.Yellow
        TextBox8.BackColor = Color.Yellow
        TextBox10.BackColor = Color.Yellow
        TextBox9.BackColor = Color.Yellow
        TextBox11.BackColor = Color.Yellow
        TextBox12.BackColor = Color.Yellow
    End Sub

    Private Sub PinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PinkToolStripMenuItem.Click
        TextBox1.BackColor = Color.Pink
        TextBox2.BackColor = Color.Pink
        TextBox3.BackColor = Color.Pink
        TextBox4.BackColor = Color.Pink
        TextBox5.BackColor = Color.Pink
        TextBox6.BackColor = Color.Pink
        TextBox7.BackColor = Color.Pink
        TextBox8.BackColor = Color.Pink
        TextBox10.BackColor = Color.Pink
        TextBox9.BackColor = Color.Pink
        TextBox11.BackColor = Color.Pink
        TextBox12.BackColor = Color.Pink
    End Sub

    Private Sub PurpelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurpelToolStripMenuItem.Click
        TextBox1.BackColor = Color.PaleVioletRed
        TextBox2.BackColor = Color.PaleVioletRed
        TextBox3.BackColor = Color.PaleVioletRed
        TextBox4.BackColor = Color.PaleVioletRed
        TextBox5.BackColor = Color.PaleVioletRed
        TextBox6.BackColor = Color.PaleVioletRed
        TextBox7.BackColor = Color.PaleVioletRed
        TextBox8.BackColor = Color.PaleVioletRed
        TextBox10.BackColor = Color.PaleVioletRed
        TextBox9.BackColor = Color.PaleVioletRed
        TextBox11.BackColor = Color.PaleVioletRed
        TextBox12.BackColor = Color.PaleVioletRed
    End Sub

    Private Sub GrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrayToolStripMenuItem.Click
        TextBox1.BackColor = Color.SlateGray
        TextBox2.BackColor = Color.SlateGray
        TextBox3.BackColor = Color.SlateGray
        TextBox4.BackColor = Color.SlateGray
        TextBox5.BackColor = Color.SlateGray
        TextBox6.BackColor = Color.SlateGray
        TextBox7.BackColor = Color.SlateGray
        TextBox8.BackColor = Color.SlateGray
        TextBox10.BackColor = Color.SlateGray
        TextBox9.BackColor = Color.SlateGray
        TextBox11.BackColor = Color.SlateGray
        TextBox12.BackColor = Color.SlateGray
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteToolStripMenuItem.Click
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox5.BackColor = Color.White
        TextBox6.BackColor = Color.White
        TextBox7.BackColor = Color.White
        TextBox8.BackColor = Color.White
        TextBox10.BackColor = Color.White
        TextBox9.BackColor = Color.White
        TextBox11.BackColor = Color.White
        TextBox12.BackColor = Color.White
    End Sub

End Class
