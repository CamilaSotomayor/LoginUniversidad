Imports System
Imports System.Web.UI
Public Class Form1


    Private servicio As New srEscuela10.WebService1SoapClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        gvEscuela.DataSource = servicio.Listar.Tables(0)

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim servicio = New srEscuela10.WebService1SoapClient()
        Dim codEscuela = TextBox3.Text.Trim()
        Dim escuela = TextBox4.Text.Trim()
        Dim respuesta As String() = servicio.Agregar(codEscuela, escuela)
        If respuesta(0) = False Then
            MsgBox("CodError: 0")
        Else
            MsgBox("CodError: 1")
        End If
        MsgBox(respuesta(1))
        gvEscuela.DataSource = servicio.Listar.Tables(0)


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim servicio = New srEscuela10.WebService1SoapClient()
        Dim codEscuela = TextBox3.Text.Trim()
        Dim respuesta As String() = servicio.Eliminar(codEscuela)
        If respuesta(0) = False Then
            MsgBox("CodError: 0")
        Else
            MsgBox("CodError: 1")
        End If
        MsgBox(respuesta(1))
        gvEscuela.DataSource = servicio.Listar.Tables(0)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim servicio = New srEscuela10.WebService1SoapClient()
        Dim codEscuela = TextBox3.Text.Trim()
        Dim escuela = TextBox4.Text.Trim()
        Dim respuesta As String() = servicio.Actualizar(codEscuela, escuela)
        If respuesta(0) = False Then
            MsgBox("CodError: 0")
        Else
            MsgBox("CodError: 1")
        End If
        MsgBox(respuesta(1))
        gvEscuela.DataSource = servicio.Listar.Tables(0)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim servicio = New srEscuela10.WebService1SoapClient()
        Dim texto As String = txtTexto.Text.Trim()
        Dim criterio As String = ddlCriterio.Text.Trim()
        gvEscuela.DataSource = servicio.Buscar(texto, criterio).Tables(0)

    End Sub




End Class
