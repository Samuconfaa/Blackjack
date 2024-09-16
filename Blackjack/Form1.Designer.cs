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
            components = new System.ComponentModel.Container();
            txtBox = new TextBox();
            btnCarta = new Button();
            btnStop = new Button();
            txtBoxOpp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxMessaggi = new TextBox();
            btnStart = new Button();
            btnReset = new Button();
            txtYou = new TextBox();
            txtAvv = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox.Location = new Point(12, 49);
            txtBox.Name = "txtBox";
            txtBox.ReadOnly = true;
            txtBox.Size = new Size(134, 82);
            txtBox.TabIndex = 0;
            txtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCarta
            // 
            btnCarta.BackColor = Color.Lime;
            btnCarta.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarta.Location = new Point(424, 285);
            btnCarta.Name = "btnCarta";
            btnCarta.Size = new Size(134, 73);
            btnCarta.TabIndex = 1;
            btnCarta.Text = "CARTA";
            btnCarta.UseVisualStyleBackColor = false;
            btnCarta.Click += btnCarta_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(564, 285);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(134, 73);
            btnStop.TabIndex = 2;
            btnStop.Text = "FERMATI";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // txtBoxOpp
            // 
            txtBoxOpp.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOpp.Location = new Point(564, 49);
            txtBoxOpp.Name = "txtBoxOpp";
            txtBoxOpp.ReadOnly = true;
            txtBoxOpp.Size = new Size(134, 82);
            txtBoxOpp.TabIndex = 3;
            txtBoxOpp.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 4;
            label1.Text = "TE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(530, 12);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 5;
            label2.Text = "AVVERSARIO";
            // 
            // txtBoxMessaggi
            // 
            txtBoxMessaggi.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxMessaggi.Location = new Point(12, 364);
            txtBoxMessaggi.Multiline = true;
            txtBoxMessaggi.Name = "txtBoxMessaggi";
            txtBoxMessaggi.ReadOnly = true;
            txtBoxMessaggi.Size = new Size(686, 64);
            txtBoxMessaggi.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(255, 255, 192);
            btnStart.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(12, 285);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(134, 73);
            btnStart.TabIndex = 7;
            btnStart.Text = "AVVIA";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 255, 192);
            btnReset.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(152, 285);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 73);
            btnReset.TabIndex = 8;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtYou
            // 
            txtYou.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYou.Location = new Point(294, 285);
            txtYou.Name = "txtYou";
            txtYou.Size = new Size(59, 27);
            txtYou.TabIndex = 9;
            txtYou.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAvv
            // 
            txtAvv.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvv.Location = new Point(359, 285);
            txtAvv.Name = "txtAvv";
            txtAvv.Size = new Size(59, 27);
            txtAvv.TabIndex = 10;
            txtAvv.TextAlign = HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(294, 260);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 12;
            label3.Text = "PUNTEGGIO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(712, 440);
            Controls.Add(label3);
            Controls.Add(txtAvv);
            Controls.Add(txtYou);
            Controls.Add(btnReset);
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
        private Button btnReset;
        private TextBox txtYou;
        private TextBox txtAvv;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
    }
}
