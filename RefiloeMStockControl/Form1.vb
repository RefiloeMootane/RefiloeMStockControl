Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Stock Control", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("Master Card")
        cmbPaymentMethod.Items.Add("Visa Card")
        cmbPaymentMethod.Items.Add("Visa Debit Card")

        cmbAccountType.Items.Add("Credit Account")
        cmbAccountType.Items.Add("Debit Account")
        cmbAccountType.Items.Add("Commercial Account")
        cmbAccountType.Items.Add("online Order ")
        cmbAccountType.Items.Add("Customer Account")

        cmbVAT.Items.Add("Yes")
        cmbVAT.Items.Add("No")

        cmbProductID.Items.Add("PID001")
        cmbProductID.Items.Add("PID012")
        cmbProductID.Items.Add("PID013")
        cmbProductID.Items.Add("PID014")
        cmbProductID.Items.Add("PID015")
        cmbProductID.Items.Add("PID016")
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        If cmbProductID.Text = "PID001" Then
            txtProductName.Text = "Milk"
            txtDescription.Text = "white liquid"
        ElseIf cmbProductID.Text = "PID012" Then
            txtProductName.Text = "Rice"
            txtDescription.Text = "white Seed"
        ElseIf cmbProductID.Text = "PID013" Then
            txtProductName.Text = "Cake"
            txtDescription.Text = "Flour/grain"
        ElseIf cmbProductID.Text = "PID014" Then
            txtProductName.Text = "Egg"
            txtDescription.Text = "Poultry"
        ElseIf cmbProductID.Text = "PID015" Then
            txtProductName.Text = "Apple"
            txtDescription.Text = "fruit"
        ElseIf cmbProductID.Text = "PID016" Then
            txtProductName.Text = "Beef"
            txtDescription.Text = "Meat"
        End If
    End Sub
End Class
