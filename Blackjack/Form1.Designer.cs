namespace Blackjack
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
            txtBox = new TextBox();
            btnCarta = new Button();
            btnStop = new Button();
            txtBoxOpp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxMessaggi = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox.Location = new Point(12, 49);
            txtBox.Name = "txtBox";
            txtBox.ReadOnly = true;
            txtBox.Size = new Size(215, 82);
            txtBox.TabIndex = 0;
            // 
            // btnCarta
            // 
            btnCarta.Location = new Point(12, 147);
            btnCarta.Name = "btnCarta";
            btnCarta.Size = new Size(94, 29);
            btnCarta.TabIndex = 1;
            btnCarta.Text = "CARTA";
            btnCarta.UseVisualStyleBackColor = true;
            btnCarta.Click += btnCarta_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(133, 147);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 2;
            btnStop.Text = "FERMATI";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtBoxOpp
            // 
            txtBoxOpp.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOpp.Location = new Point(564, 49);
            txtBoxOpp.Name = "txtBoxOpp";
            txtBoxOpp.ReadOnly = true;
            txtBoxOpp.Size = new Size(215, 82);
            txtBoxOpp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mistral", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 27);
            label1.TabIndex = 4;
            label1.Text = "YOU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mistral", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(675, 12);
            label2.Name = "label2";
            label2.Size = new Size(104, 27);
            label2.TabIndex = 5;
            label2.Text = "OPPONENT";
            // 
            // txtBoxMessaggi
            // 
            txtBoxMessaggi.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxMessaggi.Location = new Point(12, 364);
            txtBoxMessaggi.Multiline = true;
            txtBoxMessaggi.Name = "txtBoxMessaggi";
            txtBoxMessaggi.ReadOnly = true;
            txtBoxMessaggi.Size = new Size(767, 64);
            txtBoxMessaggi.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 329);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 7;
            btnStart.Text = "AVVIA";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 440);
            Controls.Add(btnStart);
            Controls.Add(txtBoxMessaggi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxOpp);
            Controls.Add(btnStop);
            Controls.Add(btnCarta);
            Controls.Add(txtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btnCarta;
        private Button btnStop;
        private TextBox txtBoxOpp;
        private Label label1;
        private Label label2;
        private TextBox txtBoxMessaggi;
        private Button btnStart;
    }
}
