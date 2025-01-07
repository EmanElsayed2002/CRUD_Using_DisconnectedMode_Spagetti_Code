namespace Ado_Disconnected_Mode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            resLable = new Label();
            btnGetByName = new Button();
            cmbboxNames = new ComboBox();
            btnUpdate = new Button();
            txtNumDown = new NumericUpDown();
            label5 = new Label();
            dptCmBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            btnGetAll = new Button();
            btnIInsert = new Button();
            GridViewForReadData = new DataGridView();
            btnSync = new Button();
            LabelText = new Label();
            ((System.ComponentModel.ISupportInitialize)txtNumDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewForReadData).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(639, 444);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(326, 31);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // resLable
            // 
            resLable.AutoSize = true;
            resLable.Location = new Point(648, 468);
            resLable.Name = "resLable";
            resLable.Size = new Size(0, 20);
            resLable.TabIndex = 35;
            // 
            // btnGetByName
            // 
            btnGetByName.Location = new Point(639, 365);
            btnGetByName.Margin = new Padding(3, 4, 3, 4);
            btnGetByName.Name = "btnGetByName";
            btnGetByName.Size = new Size(162, 32);
            btnGetByName.TabIndex = 34;
            btnGetByName.Text = "Get By Name";
            btnGetByName.UseVisualStyleBackColor = true;
            btnGetByName.Click += btnGetByName_Click;
            // 
            // cmbboxNames
            // 
            cmbboxNames.FormattingEnabled = true;
            cmbboxNames.Location = new Point(640, 320);
            cmbboxNames.Margin = new Padding(3, 4, 3, 4);
            cmbboxNames.Name = "cmbboxNames";
            cmbboxNames.Size = new Size(326, 28);
            cmbboxNames.TabIndex = 33;
            cmbboxNames.SelectedIndexChanged += cmbboxNames_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(807, 365);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 32);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNumDown
            // 
            txtNumDown.Location = new Point(757, 185);
            txtNumDown.Margin = new Padding(3, 4, 3, 4);
            txtNumDown.Name = "txtNumDown";
            txtNumDown.Size = new Size(209, 27);
            txtNumDown.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(632, 224);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 30;
            label5.Text = "Department";
            // 
            // dptCmBox
            // 
            dptCmBox.FormattingEnabled = true;
            dptCmBox.Location = new Point(757, 224);
            dptCmBox.Margin = new Padding(3, 4, 3, 4);
            dptCmBox.Name = "dptCmBox";
            dptCmBox.Size = new Size(209, 28);
            dptCmBox.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(697, 185);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 28;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(665, 148);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 27;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(643, 100);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 26;
            label2.Text = "Last_Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(641, 53);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 25;
            label1.Text = "First_Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(756, 147);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(210, 27);
            txtAddress.TabIndex = 24;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(755, 100);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(211, 27);
            txtLName.TabIndex = 23;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(754, 52);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(212, 27);
            txtFName.TabIndex = 22;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(639, 405);
            btnGetAll.Margin = new Padding(3, 4, 3, 4);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(326, 31);
            btnGetAll.TabIndex = 21;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnIInsert
            // 
            btnIInsert.Location = new Point(639, 265);
            btnIInsert.Margin = new Padding(3, 4, 3, 4);
            btnIInsert.Name = "btnIInsert";
            btnIInsert.Size = new Size(327, 47);
            btnIInsert.TabIndex = 20;
            btnIInsert.Text = "Insert";
            btnIInsert.UseVisualStyleBackColor = true;
            btnIInsert.Click += btnIInsert_Click;
            // 
            // GridViewForReadData
            // 
            GridViewForReadData.BackgroundColor = SystemColors.ControlDarkDark;
            GridViewForReadData.BorderStyle = BorderStyle.Fixed3D;
            GridViewForReadData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewForReadData.Location = new Point(9, 13);
            GridViewForReadData.Margin = new Padding(3, 4, 3, 4);
            GridViewForReadData.Name = "GridViewForReadData";
            GridViewForReadData.RowHeadersWidth = 51;
            GridViewForReadData.Size = new Size(615, 574);
            GridViewForReadData.TabIndex = 19;
            // 
            // btnSync
            // 
            btnSync.Location = new Point(639, 483);
            btnSync.Margin = new Padding(3, 4, 3, 4);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(326, 31);
            btnSync.TabIndex = 37;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // LabelText
            // 
            LabelText.AutoSize = true;
            LabelText.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelText.Location = new Point(650, 538);
            LabelText.Name = "LabelText";
            LabelText.Size = new Size(0, 23);
            LabelText.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 600);
            Controls.Add(LabelText);
            Controls.Add(btnSync);
            Controls.Add(btnDelete);
            Controls.Add(resLable);
            Controls.Add(btnGetByName);
            Controls.Add(cmbboxNames);
            Controls.Add(btnUpdate);
            Controls.Add(txtNumDown);
            Controls.Add(label5);
            Controls.Add(dptCmBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(btnGetAll);
            Controls.Add(btnIInsert);
            Controls.Add(GridViewForReadData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "DisConnected Mode";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtNumDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridViewForReadData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label resLable;
        private Button btnGetByName;
        private ComboBox cmbboxNames;
        private Button btnUpdate;
        private NumericUpDown txtNumDown;
        private Label label5;
        private ComboBox dptCmBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtLName;
        private TextBox txtFName;
        private Button btnGetAll;
        private Button btnIInsert;
        private DataGridView GridViewForReadData;
        private Button btnSync;
        private Label LabelText;
    }
}
