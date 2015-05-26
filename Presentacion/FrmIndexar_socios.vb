Public Class FrmIndexar_socios
    Private Sub FrmIndexar_socios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ObjSocios As New Socios 'Creamos el objeto de la clase socio
        ObjSocios.Llenar_sexo(CBSexo)
        ObjSocios.Llenar_acceso(CBAcceso)
        ObjSocios.Mostrar_socios(Grilla)
        BtnEliminar.Enabled = False
        BtnEditar.Enabled = False
    End Sub
   
    Dim Monto As Decimal = 0

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click
        If TBNombre.Text <> "" And TBApellido.Text <> "" And TBDni.Text <> "" And CBAcceso.Text <> "" And CBSexo.Text <> "" Then
            Dim Nombre As String = TBNombre.Text
            Dim Apellido As String = TBApellido.Text
            Dim Dni As String = TBDni.Text
            Dim Sexo As String = CBSexo.Text
            Dim Acceso As String = CBAcceso.Text
            Dim Precio As Decimal = LblPrecio.Text

            Dim ObjSocio As New Socios

            If ObjSocio.Agregar_socio(Nombre, Apellido, Dni, Sexo, Acceso, Precio) Then
                MessageBox.Show("Socio agregado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjSocio.Mostrar_socios(Grilla)
            Else
                MessageBox.Show("Error al guardar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CBSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBSexo.SelectedIndexChanged
        If CBSexo.Text = "Hombre" Then
            Monto = 150
            LblPrecio.Text = Monto
        ElseIf CBSexo.Text = "Mujer" Then
            Monto = 110
            LblPrecio.Text = Monto
        End If
    End Sub

    Private Sub CBAcceso_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBAcceso.SelectedIndexChanged
        If CBAcceso.Text = "Pase libre" And CBSexo.Text = "Hombre" Then
            Monto = 150 + 30
            LblPrecio.Text = Monto
        Else
            If CBAcceso.Text = "Pase libre" And CBSexo.Text = "Mujer" Then
                Monto = 110 + 40
                LblPrecio.Text = Monto
            Else
                If CBAcceso.Text = "3 veces por semana" And CBSexo.Text = "Hombre" Then
                    Monto = 150
                    LblPrecio.Text = Monto
                ElseIf CBAcceso.Text = "3 veces por semana" And CBSexo.Text = "Mujer" Then
                    Monto = 110
                    LblPrecio.Text = Monto
                End If
            End If
        End If
    End Sub

    Private Sub Limpiar()
        LblID.Text = ""
        TBNombre.Text = ""
        TBApellido.Text = ""
        TBDni.Text = ""
        LblPrecio.Text = ""
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        
        If TBNombre.Text <> "" And TBApellido.Text <> "" And TBDni.Text <> "" And CBAcceso.Text <> "" And CBSexo.Text <> "" Then
            Dim ID As Integer = LblID.Text
            Dim Nombre As String = TBNombre.Text
            Dim Apellido As String = TBApellido.Text
            Dim Dni As String = TBDni.Text
            Dim Sexo As String = CBSexo.Text
            Dim Acceso As String = CBAcceso.Text
            Dim Precio As Decimal = LblPrecio.Text

            Dim ObjSocio As New Socios
            If ObjSocio.Editar_socio(ID, Nombre, Apellido, Dni, Sexo, Acceso, Precio) Then
                MessageBox.Show("Socio editado con exito", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                ObjSocio.Mostrar_socios(Grilla)
            Else
                MessageBox.Show("Error al editar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Complete los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Completa las cajas de texto para su consulta 
        LblID.Text = Grilla.SelectedCells.Item(0).Value
        TBNombre.Text = Grilla.SelectedCells.Item(1).Value
        TBApellido.Text = Grilla.SelectedCells.Item(2).Value
        TBDni.Text = Grilla.SelectedCells.Item(3).Value
        CBSexo.Text = Grilla.SelectedCells.Item(4).Value
        CBAcceso.Text = Grilla.SelectedCells.Item(5).Value
        LblPrecio.Text = Grilla.SelectedCells(6).Value
        'Deshabilita el boton Agregar
        BtnAgregar.Enabled = False
        BtnEditar.Enabled = True
        BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
        BtnAgregar.Enabled = True
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        Dim ID As Integer = LblID.Text
        Dim ObjSocio As New Socios
        Dim Pregunta As String = "Deseas eliminar el registros seleccionados?"
        Dim Resultado As DialogResult = MessageBox.Show(Pregunta, "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            If ObjSocio.Eliminar_socio(ID) Then
                MessageBox.Show("Socio eliminado con exito", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ObjSocio.Mostrar_socios(Grilla) 'Refresca la grilla 
            Else
                MessageBox.Show("Error al eliminar socio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ObjSocio.Mostrar_socios(Grilla)
            End If
        Else
            MessageBox.Show("La eliminacion ha sido cancelada", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ObjSocio.Mostrar_socios(Grilla)
        End If
    End Sub
End Class