namespace RPG_GUI
{
    partial class Charactererstellung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            rbItems1 = new RadioButton();
            rbItems2 = new RadioButton();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(80, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Charactername";
            // 
            // txtName
            // 
            txtName.Location = new Point(204, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // rbItems1
            // 
            rbItems1.AutoSize = true;
            rbItems1.Location = new Point(474, 77);
            rbItems1.Name = "rbItems1";
            rbItems1.Size = new Size(136, 19);
            rbItems1.TabIndex = 2;
            rbItems1.TabStop = true;
            rbItems1.Text = "Schwert, 2 Heiltränke";
            rbItems1.UseVisualStyleBackColor = true;
            // 
            // rbItems2
            // 
            rbItems2.AutoSize = true;
            rbItems2.Location = new Point(474, 102);
            rbItems2.Name = "rbItems2";
            rbItems2.Size = new Size(117, 19);
            rbItems2.TabIndex = 3;
            rbItems2.TabStop = true;
            rbItems2.Text = "Streitaxt, Rüstung";
            rbItems2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(473, 319);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Erstellen";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(141, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Charactererstellung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(rbItems2);
            Controls.Add(rbItems1);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Charactererstellung";
            Text = "Charactererstellung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private RadioButton rbItems1;
        private RadioButton rbItems2;
        private Button btnCreate;
        private Button btnCancel;
    }
}