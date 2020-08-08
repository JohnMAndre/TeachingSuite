'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Foobar Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Foobar.  If Not, see < https: //www.gnu.org/licenses/>.
Public Class EditManualScheduleItem

    Private m_item As ActualSessionItem

    Public Sub New(item As ActualSessionItem)

        ' This call is required by the designer.
        InitializeComponent()

        m_item = item

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        m_item.Topic = txtTopic.Text
        m_item.Notes = txtNotes.Text
        m_item.Location = txtLocation.Text
        m_item.StartDateTime = dtpDate.Value.AddMinutes(dtpTime.Value.TimeOfDay.TotalMinutes)
        m_item.Prepped = chkPrepped.Checked
        m_item.StudentsEmailed = chkSent.Checked
        m_item.ScheduleType = dudType.SelectedIndex
        m_item.DurationInMinutes = nudDurationInMinutes.Value

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub EditManualScheduleItem_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            dtpDate.Value = m_item.StartDateTime.Date
            dtpTime.Value = m_item.StartDateTime
            txtTopic.Text = m_item.Topic
            txtNotes.Text = m_item.Notes
            txtLocation.Text = m_item.Location
            chkPrepped.Checked = m_item.Prepped
            chkSent.Checked = m_item.StudentsEmailed
            dudType.SelectedIndex = m_item.ScheduleType
            nudDurationInMinutes.Value = m_item.DurationInMinutes
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading this schedule time: " & ex.Message)
        End Try


        txtTopic.Focus()
    End Sub

End Class
