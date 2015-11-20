Friend Class InputBox
    Public Sub New(ByVal message As String, ByVal isPassword As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.lblMessage.Text = message
        If isPassword Then
            txtInput.PasswordChar = "*"
        Else
            txtInput.PasswordChar = String.Empty
        End If
    End Sub
    Public Property Input() As String
        Get
            Return txtInput.Text
        End Get
        Set(ByVal value As String)
            txtInput.Text = value
        End Set
    End Property

   
End Class