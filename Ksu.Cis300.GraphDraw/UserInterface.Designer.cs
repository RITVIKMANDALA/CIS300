namespace Ksu.Cis300.GraphDraw
{
    partial class UserInterface
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
            this.uxGraphDrawing = new Ksu.Cis300.GraphDrawing.GraphDrawing();
            this.uxLoad = new System.Windows.Forms.Button();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxGraphDrawing
            // 
            this.uxGraphDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxGraphDrawing.AutoScroll = true;
            this.uxGraphDrawing.GraphSize = new System.Drawing.Size(150, 150);
            this.uxGraphDrawing.Location = new System.Drawing.Point(0, 0);
            this.uxGraphDrawing.Name = "uxGraphDrawing";
            this.uxGraphDrawing.Size = new System.Drawing.Size(353, 231);
            this.uxGraphDrawing.TabIndex = 0;
            // 
            // uxLoad
            // 
            this.uxLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoad.Location = new System.Drawing.Point(121, 237);
            this.uxLoad.Name = "uxLoad";
            this.uxLoad.Size = new System.Drawing.Size(107, 33);
            this.uxLoad.TabIndex = 1;
            this.uxLoad.Text = "Load a File";
            this.uxLoad.UseVisualStyleBackColor = true;
            this.uxLoad.Click += new System.EventHandler(this.uxLoad_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 282);
            this.Controls.Add(this.uxLoad);
            this.Controls.Add(this.uxGraphDrawing);
            this.MinimumSize = new System.Drawing.Size(369, 320);
            this.Name = "UserInterface";
            this.Text = "Minimum Cost Spanning Trees";
         
            this.ResumeLayout(false);

        }

        #endregion

        private GraphDrawing.GraphDrawing uxGraphDrawing;
        private System.Windows.Forms.Button uxLoad;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
    }
}

