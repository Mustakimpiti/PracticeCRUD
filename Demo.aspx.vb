Imports System.Data.SqlClient
Imports System.Data
Partial Class Demo
    Inherits System.Web.UI.Page
    Dim cat As String


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\20BCA36\SEM_5\ASPNET\assignmet_1\App_Data\book.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand


        Try
            cn.Open()
            cmd.CommandText = "Insert into book(book_id,book_name,author,publisher,date_of_publish,price,no_of_pages,catagories)VALUES (@bid,@bname,@author,@publisher,@date_of_publish,@price,@no_of_pages,@categories)"
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@bid", TextBox1.Text)
            cmd.Parameters.AddWithValue("@bname", TextBox2.Text)
            cmd.Parameters.AddWithValue("@author", TextBox3.Text)
            cmd.Parameters.AddWithValue("@publisher", TextBox4.Text)
            cmd.Parameters.AddWithValue("@date_of_publish", TextBox5.Text)
            cmd.Parameters.AddWithValue("@price", TextBox6.Text)
            cmd.Parameters.AddWithValue("@no_of_pages", TextBox7.Text)
            cmd.Parameters.AddWithValue("@categories", cat)


            cmd.ExecuteNonQuery()

            cn.Close()
            MsgBox("ADD")


        Catch ex As Exception

        End Try

    End Sub

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
End Class
