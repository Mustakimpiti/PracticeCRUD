
Imports System.Data.SqlClient
Imports System.Data
Partial Class book
    Inherits System.Web.UI.Page
    Dim cat As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If RadioButton1.Checked Then
            cat = "facinity"
        End If
        If RadioButton2.Checked Then
            cat = "horror"
        End If
        If RadioButton3.Checked Then
            cat = "histoey"
        End If
        If RadioButton4.Checked Then
            cat = "cartoon"
        End If
        If RadioButton5.Checked Then
            cat = "mystery"
        End If
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\20BCA36\SEM_5\ASPNET\assignmet_1\App_Data\book.mdf;Integrated Security=True")

        'COMMAND BUIELDER 

        ' Dim cmd As SqlCommand = New SqlCommand("select * from book", cn)
        'Dim adp As SqlDataAdapter = New SqlDataAdapter(cmd)
        'Dim ds As DataSet = New DataSet
        'adp.Fill(ds, "book")
        'Dim newrow As DataRow = ds.Tables("book").NewRow
        'Dim cb As New SqlCommandBuilder(adp)
        cn.Open()

        'Try

        'newrow.Item(0) = TextBox1.Text
        ' newrow.Item(1) = TextBox2.Text
        'newrow.Item(2) = TextBox3.Text
        ' newrow.Item(3) = TextBox4.Text
        'newrow.Item(4) = TextBox5.Text
        ' newrow.Item(5) = TextBox6.Text
        'newrow.Item(6) = TextBox7.Text
        'newrow.Item(7) = cat

        'ds.Tables("book").Rows.Add(newrow)
        'adp.Update(ds, "book")
        ' MsgBox("RECORD ADDED SUCCESSFULLY")

        ' Catch ex As Exception
        'End Try


        'PARAMITERISED QUERY
        Dim cmd As New SqlCommand("Insert into book(book_id,book_name,author,publisher,date_of_publish,price,no_of_pages,categories)values(@b_id,@book_name,@author,@publisher,@date_of_publish,@price,@no_of_pages,@categories)", cn)
        cmd.Parameters.AddWithValue("@b_id", TextBox1.Text)
        cmd.Parameters.AddWithValue("@book_name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@author", TextBox3.Text)
        cmd.Parameters.AddWithValue("@publisher", TextBox4.Text)
        cmd.Parameters.AddWithValue("@date_of_publish", TextBox5.Text)
        cmd.Parameters.AddWithValue("@price", TextBox6.Text)
        cmd.Parameters.AddWithValue("@no_of_pages", TextBox7.Text)
        cmd.Parameters.AddWithValue("@categories", cat)
        cmd.ExecuteNonQuery()


        cn.Close()
        MsgBox("add")






    End Sub
End Class
