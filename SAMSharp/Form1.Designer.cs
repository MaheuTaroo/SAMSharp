
namespace SAMSharp
{
    partial class SAMSharp
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
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSpeak = new System.Windows.Forms.CheckBox();
            this.chkOutput = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbText.Location = new System.Drawing.Point(12, 26);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(506, 170);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chkSpeak);
            this.panel1.Controls.Add(this.chkOutput);
            this.panel1.Location = new System.Drawing.Point(524, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 48);
            this.panel1.TabIndex = 1;
            // 
            // chkSpeak
            // 
            this.chkSpeak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkSpeak.AutoSize = true;
            this.chkSpeak.Checked = true;
            this.chkSpeak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpeak.Location = new System.Drawing.Point(5, 28);
            this.chkSpeak.Name = "chkSpeak";
            this.chkSpeak.Size = new System.Drawing.Size(57, 19);
            this.chkSpeak.TabIndex = 1;
            this.chkSpeak.Text = "Speak";
            this.chkSpeak.UseVisualStyleBackColor = true;
            this.chkSpeak.CheckedChanged += new System.EventHandler(this.Checks);
            // 
            // chkOutput
            // 
            this.chkOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkOutput.AutoSize = true;
            this.chkOutput.Location = new System.Drawing.Point(5, 3);
            this.chkOutput.Name = "chkOutput";
            this.chkOutput.Size = new System.Drawing.Size(79, 19);
            this.chkOutput.TabIndex = 0;
            this.chkOutput.Text = "Create file";
            this.chkOutput.UseVisualStyleBackColor = true;
            this.chkOutput.CheckedChanged += new System.EventHandler(this.Checks);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRun.Location = new System.Drawing.Point(537, 142);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // SAMSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 205);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(654, 244);
            this.MinimumSize = new System.Drawing.Size(654, 244);
            this.Name = "SAMSharp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSpeak;
        private System.Windows.Forms.CheckBox chkOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
    }
}

