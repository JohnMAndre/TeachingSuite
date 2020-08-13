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

Public Class AssignmentDocumentSelector
    Public Sub New(files() As String)

        ' This call is required by the designer.
        InitializeComponent()

        For Each strFilename As String In files
            lstAssignments.Items.Add(strFilename)
        Next
    End Sub

    Public ReadOnly Property SelectedFilename As String
        Get
            Return lstAssignments.Items(lstAssignments.SelectedIndex)
        End Get
    End Property

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnPreview_Click(sender As System.Object, e As System.EventArgs) Handles btnPreview.Click
        System.Diagnostics.Process.Start(lstAssignments.Items(lstAssignments.SelectedIndex))
    End Sub
End Class
