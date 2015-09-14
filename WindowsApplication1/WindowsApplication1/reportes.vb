Public Class reportes
    Public texto As String

    Private Sub reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbDataSet.ventasComisionesEmpleado' table. You can move, or remove it, as needed.
        Me.ventasComisionesEmpleadoTableAdapter.Fill(Me.dbDataSet.ventasComisionesEmpleado)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Reporte_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Public Sub New(ByVal textos As String, ByVal fecha1 As Date, ByVal fecha2 As Date)

        ' This call is required by the designer.
        texto = textos
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ventaBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class