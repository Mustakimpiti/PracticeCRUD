Imports System.Data.SqlClient
Imports System.Data

Partial Class book_data
    Inherits System.Web.UI.Page
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim maxrow, inc As Integer
    Dim flag As String



    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        connect()
        If Not IsPostBack Then
            flag = "N"
        End If
        If flag = "N" Then
            diprecord()
        End If

    End Sub
    Private Sub connect()
        Try
            cn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\20BCA36\SEM_5\ASPNET\assignmet_1\App_Data\book.mdf;Integrated Security=True")
            cn.Open()
            cmd = New SqlCommand("select * from book", cn)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(ds, "book")
            maxrow = ds.Tables("book").Rows.Count



        Catch ex As Exception

        End Try
    End Sub
    Private Sub diprecord()
        Try
            inc = CInt(Session("inc"))
            If maxrow <= 0 Then
                Session("inc") = -1
                inc = CInt(Session("inc"))
                MsgBox("empty table")
            End If
            If inc <> -1 Then
                TextBox1.Text = ds.Tables("book").Rows(inc).Item(0)
                TextBox2.Text = ds.Tables("book").Rows(inc).Item(1)
                TextBox3.Text = ds.Tables("book").Rows(inc).Item(2)
                TextBox4.Text = ds.Tables("book").Rows(inc).Item(3)
                TextBox5.Text = ds.Tables("book").Rows(inc).Item(4)
                TextBox6.Text = ds.Tables("book").Rows(inc).Item(5)
                TextBox7.Text = ds.Tables("book").Rows(inc).Item(6)
                TextBox8.Text = ds.Tables("book").Rows(inc).Item(7)
            Else
                TextBox1.Text = "no record"
                TextBox2.Text = "no record"
                TextBox3.Text = "no record"
                TextBox4.Text = "no record"
                TextBox5.Text = "no record"
                TextBox6.Text = "no record"
                TextBox7.Text = "no record"
                TextBox8.Text = "no record"




            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            inc = CInt(Session("inc"))
            If inc = -1 Then
                MsgBox("EMPTY TABLE")
            ElseIf inc <> 0 Then
                Session("inc") = 0
                inc = CInt(Session("inc"))
                diprecord()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            inc = CInt(Session("inc"))
            If inc = -1 Then
                MsgBox("empty table")
            ElseIf inc = 0 Then
                MsgBox("BIGINNING OF RECORD")
            Else
                inc -= 1
                Session("inc") = inc
                diprecord()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            inc = CInt(Session("inc"))
            If inc = -1 Then
                MsgBox("empty table")
            ElseIf inc = maxrow - 1 Then
                MsgBox("END OF RECORD")
            Else
                inc += 1
                Session("inc") = inc
                diprecord()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            inc = CInt(Session("inc"))
            If inc = -1 Then
                MsgBox("empty table")
            ElseIf inc <> maxrow - 1 Then
                inc = maxrow - 1
                Session("inc") = inc
                diprecord()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Try
        '    inc = CInt(Session("inc"))
        '    If inc <> -1 Then
        '        If MsgBox("ARE YOU SURE YOU WANT TO DELETE THIS RECORD?", MsgBoxStyle.YesNoCancel, "DELETE RECORD") = Microsoft.VisualBasic.MsgBoxResult.Yes Then
        '            Dim cb As New SqlCommandBuilder(adp)
        '            adp.Update(ds, "book")
        '            MsgBox("RECORD DELETED SUCCESSFULLY")
        '            cn.Close()
        '            ds.Clear()
        '            Session("inc") = 0
        '            connect()
        '            diprecord()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("SOME EXCEPTION ARE ENCOUNTERD")
        'End Try


        'PARAMETERISED QERY


        Dim cmd As New SqlCommand("Delete from book where book_id=@bid", cn)
        cmd.Parameters.AddWithValue("@bid", TextBox1.Text)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("DELETED SUCCESSFULLY")



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        '    inc = CInt(Session("inc"))
        '    If inc <> -1 Then
        '        Dim cb As New SqlCommandBuilder(adp)
        '        ds.Tables("book").Rows(inc).Item(0) = TextBox1.Text
        '        ds.Tables("book").Rows(inc).Item(1) = TextBox2.Text
        '        ds.Tables("book").Rows(inc).Item(2) = TextBox3.Text
        '        ds.Tables("book").Rows(inc).Item(3) = TextBox4.Text
        '        ds.Tables("book").Rows(inc).Item(4) = TextBox5.Text
        '        ds.Tables("book").Rows(inc).Item(5) = TextBox6.Text
        '        ds.Tables("book").Rows(inc).Item(6) = TextBox7.Text
        '        ds.Tables("book").Rows(inc).Item(7) = TextBox8.Text
        '        adp.Update(ds, "book")
        '        MsgBox("RECORD UPDATED SUCCESSFULLY")

        '    End If


        'Catch ex As Exception
        '    MsgBox("SOME EXCEPTION ENCOUNTERD")
        '    cn.Close()
        '    ds.Clear()
        '    connect()
        '    diprecord()



        'End Try



        'PARAMNETERISED QUERY
        Dim cmd As New SqlCommand("Update book set book_name=@bname,author=@author,publisher=@publisher,date_of_publish=@dop,price=@price,no_of_pages=@nop,categories=@cat where book_id=@bid", cn)
        cmd.Parameters.AddWithValue("@bid", TextBox1.Text)
        cmd.Parameters.AddWithValue("@bname", TextBox2.Text)
        cmd.Parameters.AddWithValue("@author", TextBox3.Text)
        cmd.Parameters.AddWithValue("@publisher", TextBox4.Text)
        cmd.Parameters.AddWithValue("@dop", TextBox5.Text)
        cmd.Parameters.AddWithValue("@price", TextBox6.Text)
        cmd.Parameters.AddWithValue("@nop", TextBox7.Text)
        cmd.Parameters.AddWithValue("@cat", TextBox8.Text)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("UPDATED")
    End Sub
End Class
