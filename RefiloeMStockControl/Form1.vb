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

        For q = 18 To 28
            cmbOrderID.Items.Add("OrID" & q)
            cmbCustomerID.Items.Add("CID002" & q)

        Next
        For d = 0 To 25 Step 5
            cmbDiscount.Items.Add(d)
        Next
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        If cmbProductID.Text = "PID001" Then
            txtProductName.Text = "Milk"
            txtDescription.Text = "white liquid"
            txtStockLevel.Text = "280"
            lblReOrderLevel.Text = "10"
            lblOutofStock.Text = "15"
        ElseIf cmbProductID.Text = "PID012" Then
            txtProductName.Text = "Rice"
            txtDescription.Text = "white Seed"
            txtStockLevel.Text = "200"
            lblReOrderLevel.Text = "30"
            lblOutofStock.Text = "10"
        ElseIf cmbProductID.Text = "PID013" Then
            txtProductName.Text = "Cake"
            txtDescription.Text = "Flour/grain"
            txtStockLevel.Text = "50"
            lblReOrderLevel.Text = "15"
            lblOutofStock.Text = "25"
        ElseIf cmbProductID.Text = "PID014" Then
            txtProductName.Text = "Egg"
            txtDescription.Text = "Poultry"
            txtStockLevel.Text = "500"
            lblReOrderLevel.Text = "150"
            lblOutofStock.Text = "20"
        ElseIf cmbProductID.Text = "PID015" Then
            txtProductName.Text = "Apple"
            txtDescription.Text = "fruit"
            txtStockLevel.Text = "300"
            lblReOrderLevel.Text = "15"
            lblOutofStock.Text = "10"
        ElseIf cmbProductID.Text = "PID016" Then
            txtProductName.Text = "Beef"
            txtDescription.Text = "Meat"
            txtStockLevel.Text = "120"
            lblReOrderLevel.Text = "25"
            lblOutofStock.Text = "14"
        End If
    End Sub

    Private Sub FormClosing(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub FormClosed(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub txtNoOrder_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged
        lblItemOrdered.Text = txtProductName.Text
    End Sub

    Private Sub lblRemainder_Click(sender As Object, e As EventArgs) Handles lblRemainder.Click

    End Sub

    Private Sub txtNoOrder_TextChanged_1(sender As Object, e As EventArgs) Handles txtNoOrder.TextChanged
        lblNoItemOrdered.Text = txtNoOrder.Text

        lblRemainder.Text = Val(txtStockLevel.Text) - Val(txtNoOrder.Text)

        If (lblRemainder.Text = 2) Then
            lblAction.Text = "Order more product"
        Else
            lblAction.Text = "No Order requested"
        End If
    End Sub

End Class
