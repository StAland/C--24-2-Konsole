namespace RPG_GUI
{
    partial class RPGForm
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
            label1 = new Label();
            btnContinue = new Button();
            btnNew = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 0;
            label1.Text = "Menü";
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(300, 77);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(103, 23);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Fortsetzen";
            btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(300, 118);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(103, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "Neues Spiel";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // RPGForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNew);
            Controls.Add(btnContinue);
            Controls.Add(label1);
            Name = "RPGForm";
            Text = "RPGForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnContinue;
        private Button btnNew;
    }
}