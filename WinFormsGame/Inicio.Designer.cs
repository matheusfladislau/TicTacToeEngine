namespace WinFormsGame {
    partial class Inicio {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            btnX = new Button();
            btnO = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 14);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 0;
            label1.Text = "Jogador 1, escolha o seu símbolo:";
            // 
            // btnX
            // 
            btnX.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnX.Location = new Point(12, 41);
            btnX.Name = "btnX";
            btnX.Size = new Size(169, 71);
            btnX.TabIndex = 1;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // btnO
            // 
            btnO.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnO.Location = new Point(205, 41);
            btnO.Name = "btnO";
            btnO.Size = new Size(169, 71);
            btnO.TabIndex = 2;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            btnO.Click += btnO_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 127);
            Controls.Add(btnO);
            Controls.Add(btnX);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inicio";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escolha o símbolo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnX;
        private Button btnO;
    }
}
