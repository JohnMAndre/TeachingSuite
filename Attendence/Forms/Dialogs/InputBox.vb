'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Teaching Suite Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Teaching Suite.  If Not, see < https: //www.gnu.org/licenses/>.
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